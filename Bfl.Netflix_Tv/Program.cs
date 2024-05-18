using Bfl.Netflix_Tv.StartupExtensions;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{

    options.Limits.MaxRequestBodySize = 52428800; // 50 MB
});
builder.Host.UseSerilog((HostBuilderContext context, IServiceProvider services, LoggerConfiguration config) =>
{
    config.ReadFrom.Configuration(context.Configuration).ReadFrom.Services(services);

});
builder.Services.ConfigureServices(builder.Configuration);

var app = builder.Build();

app.ConfigureApp(app.Configuration);

app.Run();
