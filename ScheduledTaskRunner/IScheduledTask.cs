using System.Threading.Tasks;

namespace JcCore.ScheduledTaskRunner
{
    public interface IScheduledTask
    {
        Task Run();
    }
}