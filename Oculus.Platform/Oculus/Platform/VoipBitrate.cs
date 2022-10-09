using System.ComponentModel;

namespace Oculus.Platform
{
	public enum VoipBitrate
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("B16000")]
		B16000 = 1,
		[Description("B24000")]
		B24000 = 2,
		[Description("B32000")]
		B32000 = 3,
		[Description("B64000")]
		B64000 = 4,
		[Description("B96000")]
		B96000 = 5,
		[Description("B128000")]
		B128000 = 6
	}
}
