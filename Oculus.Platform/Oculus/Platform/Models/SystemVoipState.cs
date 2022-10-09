using System;

namespace Oculus.Platform.Models
{
	public class SystemVoipState
	{
		public readonly VoipMuteState MicrophoneMuted;

		public readonly SystemVoipStatus Status;

		public SystemVoipState(IntPtr o)
			: base()
		{
		}
	}
}
