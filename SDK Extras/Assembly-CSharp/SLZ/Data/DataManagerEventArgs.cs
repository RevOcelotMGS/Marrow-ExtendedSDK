using System;

namespace SLZ.Data
{
	public class DataManagerEventArgs : EventArgs
	{
		public readonly string EventName;

		public readonly object EventObject;

		public DataManagerEventArgs(string eventName, object obj)
			: base()
		{
		}
	}
}
