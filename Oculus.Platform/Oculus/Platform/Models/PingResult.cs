using System.Runtime.CompilerServices;

namespace Oculus.Platform.Models
{
	public class PingResult
	{
		private ulong? pingTimeUsec;

		public ulong ID { get; private set; }

		public ulong PingTimeUsec
		{
			get
			{
				return default(ulong);
			}
		}

		public bool IsTimeout
		{
			get
			{
				return default(bool);
			}
		}

		public PingResult(ulong id, ulong? pingTimeUsec)
			: base()
		{
		}
	}
}
