using Serilog;
using Serilog.Events;
using Serilog.Exceptions;
using Serilog.Formatting.Compact;
using Ufrgs.ExatoLP.Infrastructure.Extensions;
using Ufrgs.ExatoLP.WebApi.Constants;
using Ufrgs.ExatoLP.WebApi.Extensions;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .MinimumLevel.Override(Namespaces.MicrosoftAspNetCore, LogEventLevel.Warning)
    .Enrich.WithMachineName()
    .Enrich.WithEnvironmentName()
    .Enrich.WithExceptionDetails()
    .WriteTo.Console(new CompactJsonFormatter())
    .CreateLogger();

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder
        .ConfigureOptions()
        .ConfigureLoggingProvider();

    builder.Services
        .AddInfrastructureServices()
        .AddWebApiServices();

    var app = builder.Build();
    
    app.UseWebApiMiddlewares();

    app.Run();
}
catch (Exception ex)
{
    if (ex.Source != Namespaces.MicrosoftEntityFrameworkCoreDesign)
        Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
