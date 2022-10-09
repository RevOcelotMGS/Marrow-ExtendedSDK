using System.ComponentModel;

namespace Oculus.Platform
{
	public enum SdkAccountType
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("OCULUS")]
		Oculus = 1,
		[Description("FACEBOOK_GAMEROOM")]
		FacebookGameroom = 2
	}
}
