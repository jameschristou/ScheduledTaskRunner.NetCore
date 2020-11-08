using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using JcCore.ScheduledTaskRunner;
using JcCore.ScheduledTaskRunner.Extensions;

namespace JcCore.ScheduledTaskRunner.TestApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = new HostBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                ConfigureServices(services);
            });

            await builder.RunConsoleAsync();
        }

        private static IServiceCollection ConfigureServices(IServiceCollection services)
        {
            services.AddHostedService<ExampleScheduledTask>();
            services.AddHostedService<AnotherExampleScheduledTask>();
            services.AddHostedService<MyApplication>();

            return services;
        }
    }
}
