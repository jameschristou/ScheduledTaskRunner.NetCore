using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace JcCore.ScheduledTaskRunner.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static async Task SetUpScheduledTasks(this IServiceProvider serviceProvider)
        {
            var tasks = serviceProvider.GetService<IEnumerable<IScheduledTask>>();

            foreach (var startUpTask in tasks)
            {
                //await startUpTask.Run();
            }
        }
    }
}