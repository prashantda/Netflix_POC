using Bfl.Netflix.Exceptions;
using Bfl.Netflix_Tv.Core.Configurations;
using Microsoft.Data.SqlClient;
using Serilog;

namespace Bfl.Netflix_Tv.StartupExtensions
{
    public static class AppConfiguration
    {
        public static WebApplication ConfigureApp(this WebApplication app,IConfiguration configuration)
        {

            app.UseStaticFiles();
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
                Configuration.SP_SQL_PATH = string.Concat(Directory.GetCurrentDirectory()+"/wwwroot/NetflixTvShow.sql");
                Endpoints.GRPCUrl = configuration["MoviesGrpc"];
            }
       

            if (app.Environment.IsProduction()) {
                Configuration.SP_SQL_PATH = @"/app/wwwroot/NetflixTvShow.sql";
                Endpoints.GRPCUrl = string.Concat("http://", Environment.GetEnvironmentVariable("GRPCURL"), ":6769");

            }


            #region SQL script - Stored Procedure
            string script = File.ReadAllText(Configuration.SP_SQL_PATH);
            string[] batches = script.Split(new[] { "GO\r\n", "GO ", "GO\t" }, StringSplitOptions.RemoveEmptyEntries);
            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();
                foreach (string batch in batches)
                {
                    using (SqlCommand command = new SqlCommand(batch, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            #endregion


            /*    #region EndpointsConfiguration
                Endpoints.Host= string.Concat("http://",Environment.GetEnvironmentVariable("CLIENTHOST") ?? "localhost:5069","/api/");
                Endpoints.SaveTvshowCast = Endpoints.Host + "TVShowCast/Add";
                Endpoints.DeleteTvshowCast = Endpoints.Host + "TVShowCast/Delete";
                Endpoints.SaveTvshowCategory = Endpoints.Host + "TVShowCategory/Add";
                Endpoints.DeleteTvshowCategory = Endpoints.Host + "TVShowCategory/Delete";


                #endregion*/
            app.UseMiddleware<ExceptionMiddleware>();
            app.UseSerilogRequestLogging();
            //app.UseCors("AllowAll");
            app.UseStaticFiles();
            app.UseRouting();      
           
            
            app.MapControllers();
            return app;
        }
    }
}
