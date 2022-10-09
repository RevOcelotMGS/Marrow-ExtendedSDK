using System.ComponentModel;

namespace Oculus.Platform
{
	public enum LivestreamingMicrophoneStatus
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("MICROPHONE_ON")]
		MicrophoneOn = 1,
		[Description("MICROPHONE_OFF")]
		MicrophoneOff = 2
	}
}
