using Serilog;
using Serilog.Enrichers.Span;
using Serilog.Exceptions;
using Serilog.Formatting.Compact;
using Ufrgs.ExatoLP.Core.Configs;
using Ufrgs.ExatoLP.WebApi.Constants;

namespace Ufrgs.ExatoLP.WebApi.Extensions;

public static class WebApplicationBuilderExtensions
{
    /// <summary>
    /// Registers configurations from <c>appsettings.{Environment}.json</c> 
    /// in the <see cref="IServiceCollection">services collection</see>.
    /// </summary>
    /// <param name="builder">The builder instance.</param>
    /// <returns>The <see cref="WebApplicationBuilder"/> so that additional calls can be chained.</returns>
    public static WebApplicationBuilder ConfigureOptions(this WebApplicationBuilder builder)
    {
        var configs = builder.Configuration;

        builder.Services
            .Configure<ConnectionStringConfigs>(configs.GetRequiredSection(ConfigSections.ConnectionStrings));

        return builder;
    }

    /// <summary>
    /// Configures the logging provider.
    /// </summary>
    /// <param name="builder">The builder instance.</param>
    /// <returns>The <see cref="WebApplicationBuilder"/> so that additional calls can be chained.</returns>
    public static WebApplicationBuilder ConfigureLoggingProvider(this WebApplicationBuilder builder)
    {
        builder.Host.UseSerilog((_, _, logConfigs) =>
        {
            logConfigs
                .ReadFrom.Configuration(builder.Configuration)
                .Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .Enrich.WithEnvironmentName()
                .Enrich.WithSpan()
                .Enrich.WithExceptionDetails()
                .WriteTo.Console(new CompactJsonFormatter());
        });
        
        return builder;
    }
}
