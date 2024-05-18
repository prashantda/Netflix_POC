using Grpc.AspNetCore.Server.Model;
using Bfl.Netflix.Exceptions;
using Bfl.Netflix.StartupExtensions;
using Bfl.Netflix_Service1.StartupExtensions;
using Serilog;
using System;
using System.Text;
using Bfl.Netflix_Movies.Core.SyncDataServices.GRPC;
using Bfl.Netflix_Movies.Core.AsyncDataServices;

var builder = WebApplication.CreateBuilder(args);


builder.Services.ConfigureServices(builder.Configuration);

builder.WebHost.ConfigureKestrel(options =>
{

    options.Limits.MaxRequestBodySize = 52428800; // 50 MB
});
builder.Host.UseSerilog((HostBuilderContext context,IServiceProvider services,LoggerConfiguration config) =>
{
    config.ReadFrom.Configuration(context.Configuration).ReadFrom.Services(services);

});

var app = builder.Build();

app.ConfigurePath();
app.Run();
