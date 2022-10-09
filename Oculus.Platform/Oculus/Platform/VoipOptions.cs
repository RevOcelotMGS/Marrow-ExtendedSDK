using System;

namespace Oculus.Platform
{
	public class VoipOptions
	{
		private IntPtr Handle;

		public void SetBitrateForNewConnections(VoipBitrate value)
		{
		}

		public void SetCreateNewConnectionUseDtx(VoipDtxState value)
		{
		}

		public static explicit operator IntPtr(VoipOptions options)
		{
			return default(IntPtr);
		}

		~VoipOptions()
		{
		}

		public VoipOptions()
			: base()
		{
		}
	}
}
