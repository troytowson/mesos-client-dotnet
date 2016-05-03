using Scheduler.Resources;

namespace Scheduler
{
    /// <summary>
    /// Represents a contract for all schedulers.
    /// </summary>
    public interface IScheduler
    {
        /// <summary>
        /// Called when the Scheduler is Registered.
        /// </summary>
        void Registered(ISchedulerClient client, FrameworkID frameworkId, MasterInformation master);
    }
}
