using System;

namespace Scheduler.Utils
{
	public class Check
	{
		public static void NotNull(object value) 
		{
			if (value == null)
			{
				throw new NullReferenceException();
			}
		}
	}
}