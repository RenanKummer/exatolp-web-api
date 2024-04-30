using Microsoft.Extensions.DependencyInjection;
using Ufrgs.ExatoLP.Infrastructure.Database;

namespace Ufrgs.ExatoLP.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers services required by Infrastructure layer in 
    /// the <see cref="IServiceCollection">services collection</see>.
    /// </summary>
    /// <param name="services">The services collection instance.</param>
    /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services) => 
        services.AddDbContext<AppDatabaseContext>();
}
