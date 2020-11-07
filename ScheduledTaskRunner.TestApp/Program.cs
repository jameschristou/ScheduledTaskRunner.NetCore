using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using JcCore.ScheduledTaskRunner;
using JcCore.ScheduledTaskRunner.Extensions;

namespace JcCore.ScheduledTaskRunner.TestApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var serviceProvider = ConfigureServices().BuildServiceProvider();

            // run the startup tasks
            await serviceProvider.SetUpScheduledTasks();

            // wait for eternity :-)
            Thread.Sleep(-1);
        }

        private static IServiceCollection ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddHostedService<ExampleScheduledTask>();

            return serviceCollection;
        }
    }
}
