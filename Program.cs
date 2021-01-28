using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CompositionAndDI
{
    static class Program
    {
        static Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            using IServiceScope serviceScope = host.Services.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;
            WindowManager windowManager = provider.GetRequiredService<WindowManager>();
            windowManager.CreateRectangleWithUserParams(new RectangleParameters() { width = 15, height = 20 });
            windowManager.CreateCircleWithUserParams(new CirlceParameters() { radius = 8 });

            return host.RunAsync();
        }
        static IHostBuilder CreateHostBuilder(string[] args) 
        {
            return Host.CreateDefaultBuilder(args).ConfigureServices((context, services) => ConfigureServices(services));
        }

        static IServiceCollection ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IShapeFactory<Rectangle>, RectangleFactory>();
            services.AddTransient<IShapeFactory<Cirlce>, CirlceFactory>();
            services.AddTransient<WindowManager>();

            return services;
        }
    }
}
