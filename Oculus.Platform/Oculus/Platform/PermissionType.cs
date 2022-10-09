using System.ComponentModel;

namespace Oculus.Platform
{
	public enum PermissionType
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("MICROPHONE")]
		Microphone = 1,
		[Description("WRITE_EXTERNAL_STORAGE")]
		WriteExternalStorage = 2
	}
}
