namespace Ufrgs.ExatoLP.WebApi.Extensions;

public static class WebApplicationExtensions
{
    /// <summary>
    /// Registers middlewares required by Web API layer in <see cref="WebApplication"/>.
    /// </summary>
    /// <param name="app">The web application instance.</param>
    /// <returns>The <see cref="WebApplication"/> so that additional calls can be chained.</returns>
    public static WebApplication UseWebApiMiddlewares(this WebApplication app)
    {
        app.UseHttpsRedirection();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        return app;
    }
}
