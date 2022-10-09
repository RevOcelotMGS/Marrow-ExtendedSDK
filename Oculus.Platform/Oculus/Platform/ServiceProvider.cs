using System.ComponentModel;

namespace Oculus.Platform
{
	public enum ServiceProvider
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("DROPBOX")]
		Dropbox = 1,
		[Description("FACEBOOK")]
		Facebook = 2,
		[Description("GOOGLE")]
		Google = 3,
		[Description("INSTAGRAM")]
		Instagram = 4,
		[Description("REMOTE_MEDIA")]
		RemoteMedia = 5
	}
}
