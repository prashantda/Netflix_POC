using Bfl.Netflix.Core.Configurations;
using Bfl.Netflix.Exceptions;
using Bfl.Netflix_Movies.Core.SyncDataServices.GRPC;
using Newtonsoft.Json;
using Serilog;

namespace Bfl.Netflix_Service1.StartupExtensions
{
    public static class AppConfiguration
    {
        public static WebApplication ConfigurePath(this WebApplication app)
        {
             app.UseCors("AllowAll");
           // app.UseCors("AllowSpecificOrigins");
            app.UseHsts();
            app.UseHttpsRedirection();
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseMiddleware<ExceptionMiddleware>();
            app.UseSerilogRequestLogging();
            
           
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();//Read identity cookie
            app.UseAuthorization();//validate access permissions of user
            app.MapControllers();

            if (app.Environment.IsDevelopment())
            {
                Configuration.CategoriesPath = @"../Bfl.Netflix_Movies.Infrastructure/Database/Categories.json";
                Configuration.VideoPath = @"../Videos";
                Configuration.Environment = "Development";
                
            }
            if (app.Environment.IsProduction())
            {
                Configuration.CategoriesPath = @"/app/Database/Categories.json";
                Configuration.VideoPath = @"/app/wwwroot/Files";
                Configuration.Environment = "Production";
                Configuration.Volume_MOUNT = Environment.GetEnvironmentVariable("VOLUME_MOUNT");

                Netflix.Core.Helpers.ConfigurationManager.AppSetting["Kestrel:Endpoints:Grpc:Url"] =
                    string.Concat("http://", Environment.GetEnvironmentVariable("GRPCURL") ?? "movies-clusterip");
                Netflix.Core.Helpers.ConfigurationManager.AppSetting["Kestrel:Endpoints:webApi:Url"] =
                    string.Concat("http://", Environment.GetEnvironmentVariable("GRPCURL") ?? "movies-clusterip", ":80");
            }
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<GrpcMoviesService>(); // add Grpc
                endpoints.MapGet("protos/movies.proto",async context =>
                {
                    await context.Response.WriteAsync(File.ReadAllText("Protos/Movies.proto"));
                });
            });


            return app;

        }      
    }
}
