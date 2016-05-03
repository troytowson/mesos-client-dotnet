using System.Threading.Tasks;

namespace Scheduler
{
	/// <summary>
	/// Represents the status of the driver.
	/// </summary>
	public enum SchedulerClientStatus
	{
		/// <summary>
		/// Represents the driver is running.
		/// </summary>
		DRIVER_RUNNING = 0
	}
	
	/// <summary>
	/// Represents a contract for all drivers 
	/// </summary>
	public interface ISchedulerClient
    {
        Task<SchedulerClientStatus> Run();
		
		void Stop();
    }	
}