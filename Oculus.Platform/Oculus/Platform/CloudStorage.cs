using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class CloudStorage
	{
		public static Request<CloudStorageUpdateResponse> Delete(string bucket, string key)
		{
			return null;
		}

		public static Request<CloudStorageData> Load(string bucket, string key)
		{
			return null;
		}

		public static Request<CloudStorageMetadataList> LoadBucketMetadata(string bucket)
		{
			return null;
		}

		public static Request<CloudStorageConflictMetadata> LoadConflictMetadata(string bucket, string key)
		{
			return null;
		}

		public static Request<CloudStorageData> LoadHandle(string handle)
		{
			return null;
		}

		public static Request<CloudStorageMetadata> LoadMetadata(string bucket, string key)
		{
			return null;
		}

		public static Request<CloudStorageUpdateResponse> ResolveKeepLocal(string bucket, string key, string remoteHandle)
		{
			return null;
		}

		public static Request<CloudStorageUpdateResponse> ResolveKeepRemote(string bucket, string key, string remoteHandle)
		{
			return null;
		}

		public static Request<CloudStorageUpdateResponse> Save(string bucket, string key, byte[] data, long counter, string extraData)
		{
			return null;
		}

		public static Request<CloudStorageMetadataList> GetNextCloudStorageMetadataListPage(CloudStorageMetadataList list)
		{
			return null;
		}
	}
}
