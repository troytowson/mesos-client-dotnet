using System.Collections.Concurrent;

namespace Scheduler.Messaging
{
	/// <summary>
	/// 
	/// </summary>
	public interface IMessage
	{
		
	}
	
	/// <summary>
	/// 
	/// </summary>
	public interface IMessageHandler<T> where T : IMessage 
	{
		/// <summary>
		/// 
		/// </summary>
		void Handle(T message);
	}
	
	public class MessageQueue 
	{
		private ConcurrentQueue<object> _queue;
		
		
	}
}