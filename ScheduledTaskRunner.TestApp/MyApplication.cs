using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace JcCore.ScheduledTaskRunner.TestApp
{
    // This is the class where you start your main application code
    public class MyApplication : IHostedService, IDisposable
    {
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            // start main application code here
            System.Console.WriteLine("Starting MyApplication");
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            System.Console.WriteLine("Stopping MyApplication");

            await Task.CompletedTask;
        }

        public void Dispose()
        {
        }
    }
}
