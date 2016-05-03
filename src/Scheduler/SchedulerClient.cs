using System;
using System.Threading.Tasks;
using Scheduler.Utils;

namespace Scheduler
{
    /// <summary>
    /// Represents a scheduler client.
    /// </summary>
    public class SchedulerClient : ISchedulerClient
    {
        /// <summary>
        /// 
        /// </summary>
        public SchedulerClientStatus Status
        {
            get;
            private set;
        }

        private SchedulerClient() {}

        /// <summary>
        /// Creates a Scheduler client.
        /// </summary>
        public static ISchedulerClient Create(SchedulerClientConfiguration configuration)
        {
            Check.NotNull(configuration);
            Check.NotNull(configuration.Scheduler);
            Check.NotNull(configuration.Framework);

            return new SchedulerClient();
        }

        /// <summary>
        /// Runs the client.
        /// </summary>
        public Task<SchedulerClientStatus> Run()
        {
            return Task.FromResult(SchedulerClientStatus.DRIVER_RUNNING);
        }

        /// <summary>
        /// Stops the client.
        /// </summary>
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}