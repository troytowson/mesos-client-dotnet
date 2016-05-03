using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Scheduler.Messaging;
using Scheduler.Utils;

namespace Scheduler.Internals
{
	/// <summary>
	/// Represents a logic handler for the Scheduler Client.
	/// </summary>
	internal class SchedulerClientLogicHandler
	{
		private ConcurrentQueue<IMessage> _qeueue;
		private Dictionary<Type, Action<IMessage>> _handlers;
		
		/// <summary>
		/// Initalises a new instance of the SchedulerClientLogicHandler class.
		/// </summary>
		public SchedulerClientLogicHandler()
		{
			_qeueue = new ConcurrentQueue<IMessage>();	
			_handlers = new Dictionary<Type, Action<IMessage>>();
		}
		
		/// <summary>
		/// Enqueues a message.
		/// </summary>
		public void Enqueue<T>(T message) where T : IMessage
		{
			Check.NotNull(message);
			_qeueue.Enqueue(message);
		}
		
		/// <summary>
		/// Registers a message handler.
		/// </summary>
		public void RegisterHandler<T>(IMessageHandler<T> handler) where T : IMessage
		{
			_handlers.Add(typeof(T), msg => handler.Handle((T)msg));
		}
			
		/// <summary>
		/// Processes the Queue.
		/// </summary>
		private void ProcessQueue()
		{
		}
	}
}