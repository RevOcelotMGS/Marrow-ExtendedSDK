using System.ComponentModel;

namespace Oculus.Platform
{
	public enum CloudStorageDataStatus
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("IN_SYNC")]
		InSync = 1,
		[Description("NEEDS_DOWNLOAD")]
		NeedsDownload = 2,
		[Description("REMOTE_DOWNLOADING")]
		RemoteDownloading = 3,
		[Description("NEEDS_UPLOAD")]
		NeedsUpload = 4,
		[Description("LOCAL_UPLOADING")]
		LocalUploading = 5,
		[Description("IN_CONFLICT")]
		InConflict = 6
	}
}
