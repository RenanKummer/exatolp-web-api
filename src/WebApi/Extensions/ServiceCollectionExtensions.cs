using System.Text.Json;
using System.Text.Json.Serialization;
using Ufrgs.ExatoLP.WebApi.Middlewares;

namespace Ufrgs.ExatoLP.WebApi.Extensions;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers services required by Web API layer in the <see cref="IServiceCollection">services collection</see>.
    /// </summary>
    /// <param name="services">The services collection instance.</param>
    /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
    public static IServiceCollection AddWebApiServices(this IServiceCollection services)
    {
        services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                options.JsonSerializerOptions.AllowTrailingCommas = true;
                options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
            });

        services.AddProblemDetails()
            .AddExceptionHandler<GlobalExceptionHandler>();

        services.AddSwaggerGen();

        return services;
    }
}
