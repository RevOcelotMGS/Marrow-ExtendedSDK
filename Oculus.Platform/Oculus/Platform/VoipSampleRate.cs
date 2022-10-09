using System.ComponentModel;

namespace Oculus.Platform
{
	public enum VoipSampleRate
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("HZ24000")]
		HZ24000 = 1,
		[Description("HZ44100")]
		HZ44100 = 2,
		[Description("HZ48000")]
		HZ48000 = 3
	}
}
