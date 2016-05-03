using System;
using Scheduler.Resources;

namespace Scheduler
{
    /// <summary>
    /// Represents a configuration for the Scheduler Client.
    /// </summary>
    public class SchedulerClientConfiguration
    {
        /// <summary>
        /// Gets the IP Address.
        /// </summary>
        public Uri Address
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the scheduler.
        /// </summary>
        public IScheduler Scheduler
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the framework.
        /// </summary>
        public FrameworkInformation Framework
        {
            get;
            private set;
        }

        /// <summary>
        /// Initialises a new instance of the SchedulerDriverConfiguration class.
        /// </summary>
        public SchedulerClientConfiguration(Uri address)
        {
            Address = address;
        }

        /// <summary>
        /// Registers a scheduler. 
        /// </summary>
        public void RegisterScheduler(IScheduler scheduler)
        {
            Scheduler = scheduler;
        }

        /// <summary>
        /// Registers the framework.
        /// </summary>
        public void RegisterFramework(FrameworkInformation framework)
        {
            Framework = framework;
        }
    }
}
