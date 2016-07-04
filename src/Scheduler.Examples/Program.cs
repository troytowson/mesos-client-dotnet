using System;
using System.Threading.Tasks;
using Scheduler;
using Scheduler.Resources;

namespace Scheduler.Examples
{
    public class Program
    {
        public class Scheduler : IScheduler
        {
            public void Registered(ISchedulerDriver driver, FrameworkID frameworkId, MasterInfo masterInfo)
            {
                throw new NotImplementedException();
            }
        }

        public void Main(string[] args)
        {
            RunMesos().Wait();
        }
        

        private async static Task RunMesos()
        {
            var configuration = new SchedulerDriverConfiguration();
            configuration.RegisterScheduler(new Scheduler());
            configuration.RegisterFramework(new FrameworkInfo());

            var driver = SchedulerDriver.Create(configuration);
            var status = await driver.Run();
        }
    }
}
