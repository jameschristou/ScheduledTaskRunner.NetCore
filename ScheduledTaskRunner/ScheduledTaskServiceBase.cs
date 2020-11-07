using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace JcCore.ScheduledTaskRunner
{
    public abstract class ScheduledTaskServiceBase : IHostedService, IDisposable
    {
        private readonly TimeSpan _scheduleInterval;
        private System.Timers.Timer _timer;

        protected ScheduledTaskServiceBase(TimeSpan scheduleInterval)
        {
            _scheduleInterval = scheduleInterval;
        }

        public virtual async Task StartAsync(CancellationToken cancellationToken)
        {
            await ScheduleJob(cancellationToken);
        }

        protected virtual async Task ScheduleJob(CancellationToken cancellationToken)
        {
            _timer = new System.Timers.Timer(_scheduleInterval.TotalMilliseconds);

            _timer.Elapsed += async (sender, args) =>
            {
                _timer.Dispose();  // reset and dispose timer
                _timer = null;

                if (!cancellationToken.IsCancellationRequested)
                {
                    await DoWork(cancellationToken);
                }

                if (!cancellationToken.IsCancellationRequested)
                {
                    await ScheduleJob(cancellationToken);    // schedule next
                }
            };

            _timer.Start();

            await Task.CompletedTask;
        }

        public virtual async Task DoWork(CancellationToken cancellationToken)
        {
            await Task.Delay(5000, cancellationToken);
        }

        public virtual async Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Stop();

            await Task.CompletedTask;
        }

        public virtual void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
