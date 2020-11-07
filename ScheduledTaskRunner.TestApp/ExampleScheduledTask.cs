using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace JcCore.ScheduledTaskRunner.TestApp
{
    public class ExampleScheduledTask : ScheduledTaskServiceBase
    {
        private readonly IServiceProvider _serviceProvider;

        public ExampleScheduledTask() 
                : base(new TimeSpan(0, 0, 30))
        {
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            System.Console.WriteLine("Starting ExampleScheduledTask scheduled task");

            await base.StartAsync(cancellationToken);
        }

        public override async Task DoWork(CancellationToken cancellationToken)
        {
            System.Console.WriteLine("Rerunning ExampleScheduledTask");
        }
    }
}