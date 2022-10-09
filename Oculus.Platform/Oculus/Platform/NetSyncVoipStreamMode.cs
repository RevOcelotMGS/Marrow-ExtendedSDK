using System.ComponentModel;

namespace Oculus.Platform
{
	public enum NetSyncVoipStreamMode
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("AMBISONIC")]
		Ambisonic = 1,
		[Description("MONO")]
		Mono = 2
	}
}
