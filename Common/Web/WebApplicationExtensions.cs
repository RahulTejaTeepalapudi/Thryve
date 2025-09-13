using Microsoft.AspNetCore.Builder;

namespace Thryve.Common.Web
{
    public static class WebApplicationExtensions
    {
        public static WebApplication UseThryveDefaults(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();

            return app;
        }
    }
}
