

using Bfl.Netflix_Tv.Core.AsyncDataServices;
using Bfl.Netflix_Tv.Core.Configurations;
using Bfl.Netflix_Tv.Core.Domain.RepositoryContracts;
using Bfl.Netflix_Tv.Core.Helpers;
using Bfl.Netflix_Tv.Core.ServiceContracts;
using Bfl.Netflix_Tv.Core.Services;
using Bfl.Netflix_Tv.Core.SyncDataServices;
using Bfl.Netflix_Tv.Core.SyncDataServices.GRPC;
using Bfl.Netflix_Tv.Filters.AuthorizationFilters;
using Bfl.Netflix_Tv.Infrastructure.Repositories;
using Configurations;
using Confluent.Kafka;
using MassTransit;
using Microsoft.OpenApi.Models;

namespace Bfl.Netflix_Tv.StartupExtensions
{
    public static class ConfigureServiceExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddControllers();

            #region Database Connection
            var host = Environment.GetEnvironmentVariable("HOST") ?? "PRASHANT\\SQLEXPRESS";
            var db = Environment.GetEnvironmentVariable("DATABASE") ?? "Netflix";
            var userId = Environment.GetEnvironmentVariable("USERID") ?? "root";
            var password = Environment.GetEnvironmentVariable("PASSWORD") ?? "zxcvbnm";
            var connection = $"Data Source={host}; Initial Catalog={db};User ID={userId};Password={password};Connect Timeout=30; Encrypt=False;";
           Configuration.ConnectionString = connection;

            
            #endregion

            #region Services For DI
            services.AddTransient<RoleValidationAuthorizationFilter>();
            services.AddAutoMapper(typeof(AutoMapperConfiguration));
            services.AddHttpClient<ITvShowCastDataServices, HttpTvShowCastDataClient>();
            services.AddHttpClient<ITvShowCategoryDataServices, HttpTvShowCategoryDataClient>();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(/*options =>
            {
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Authentication Token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JsonWebToken",
                    Scheme = "Bearer"
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference=new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id="Bearer"
                            }
                        },
                       new string[]{}
                    }
                });
            }*/);
            services.AddSingleton<IKfkaTvCategoryClient, KfkaTvCategoryClient>();
            services.AddScoped<ITvShowsRepository, TvShowRepository>();
            services.AddScoped<ITvShowsService, TvShowService>();
            services.AddScoped<IRmqTvShowDataClient, RmqTvShowCastDataClient>();
            services.AddScoped<IGrpcTvDataClientServices,GrpcTvDataClientServices>();
           
            services.AddMassTransit(x =>
            {
                x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config =>
                {
                    config.Host(new Uri(RabbitMqConfiguration.RmqUri), h =>
                    {
                        h.Username(RabbitMqConfiguration.UserName);
                        h.Password(RabbitMqConfiguration.Password);
                    });
                }));
            });







            #endregion

            #region Kafka Configuration
            var kafkaProducerBinding = new ProducerConfig();
            var producerSection = configuration.GetSection("KafkaProducer");
            Endpoints.KafkaServer = Environment.GetEnvironmentVariable("KAFKASERVER") ?? producerSection["bootstrapservers"];
            producerSection["bootstrapservers"]=Endpoints.KafkaServer;
            ConfigurationBinder.Bind(producerSection, kafkaProducerBinding);
            services.AddSingleton(kafkaProducerBinding);
            #endregion
            return services;    
        }

    }
}
