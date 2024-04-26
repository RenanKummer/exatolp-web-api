namespace Ufrgs.ExatoLP.WebApi.Extensions;

public static class WebApplicationExtensions
{
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
