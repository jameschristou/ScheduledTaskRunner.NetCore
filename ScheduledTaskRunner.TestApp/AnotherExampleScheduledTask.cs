using JcCore.ScheduledTaskRunner;
using System.Threading.Tasks;

namespace JcCore.ScheduledTaskRunner.TestApp
{
    public class AnotherExampleScheduledTask : IScheduledTask
    {
        public async Task Run()
        {
            System.Console.WriteLine("Running AnotherExampleScheduledTask");
        }
    }
}