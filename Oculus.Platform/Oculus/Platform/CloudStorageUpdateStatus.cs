using System.ComponentModel;

namespace Oculus.Platform
{
	public enum CloudStorageUpdateStatus
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("OK")]
		Ok = 1,
		[Description("BETTER_VERSION_STORED")]
		BetterVersionStored = 2,
		[Description("MANUAL_MERGE_REQUIRED")]
		ManualMergeRequired = 3
	}
}
