using System.Runtime.CompilerServices;

namespace Oculus.Platform
{
	public sealed class Request<T> : Request
	{
		private Message<T>.Callback callback_;

		public Request(ulong requestID)
			: base(requestID)
		{
		}

		public Request<T> OnComplete(Message<T>.Callback callback)
		{
			return null;
		}

		public override void HandleMessage(Message msg)
		{
		}
	}
	public class Request
	{
		private Message.Callback callback_;

		public ulong RequestID { get; set; }

		public Request(ulong requestID)
			: base()
		{
		}

		public Request OnComplete(Message.Callback callback)
		{
			return null;
		}

		public virtual void HandleMessage(Message msg)
		{
		}

		public static void RunCallbacks(uint limit = 0u)
		{
		}
	}
}
