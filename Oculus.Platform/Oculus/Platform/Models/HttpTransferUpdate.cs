using System;

namespace Oculus.Platform.Models
{
	public class HttpTransferUpdate
	{
		public readonly ulong ID;

		public readonly byte[] Payload;

		public readonly bool IsCompleted;

		public HttpTransferUpdate(IntPtr o)
			: base()
		{
		}
	}
}
