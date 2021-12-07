using Microsoft.Extensions.DependencyInjection;
using Winstanley.BlazorMauiHybrid.Core.Data;

namespace Winstanley.BlazorMauiHybrid.Core
{
    public static class DependencyInjection
    {
        public static void AddCore(this IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();
        }
    }
}
