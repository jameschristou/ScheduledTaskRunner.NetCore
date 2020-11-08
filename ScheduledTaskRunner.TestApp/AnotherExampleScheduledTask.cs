using System;
using System.Threading;
using System.Threading.Tasks;

namespace JcCore.ScheduledTaskRunner.TestApp
{
    public class AnotherExampleScheduledTask : ScheduledTaskServiceBase
    {
        private readonly IServiceProvider _serviceProvider;

        public AnotherExampleScheduledTask() 
                : base(new TimeSpan(0, 0, 15))
        {
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            System.Console.WriteLine("Starting AnotherExampleScheduledTask scheduled task");

            await base.StartAsync(cancellationToken);
        }

        public override async Task DoWork(CancellationToken cancellationToken)
        {
            System.Console.WriteLine("Rerunning AnotherExampleScheduledTask");
        }
    }
}