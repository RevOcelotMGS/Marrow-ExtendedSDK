using System.Collections.Generic;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class UserDataStore
	{
		public static Request<UserDataStoreUpdateResponse> PrivateDeleteEntryByKey(ulong userID, string key)
		{
			return null;
		}

		public static Request<Dictionary<string, string>> PrivateGetEntries(ulong userID)
		{
			return null;
		}

		public static Request<Dictionary<string, string>> PrivateGetEntryByKey(ulong userID, string key)
		{
			return null;
		}

		public static Request<UserDataStoreUpdateResponse> PrivateWriteEntry(ulong userID, string key, string value)
		{
			return null;
		}

		public static Request<UserDataStoreUpdateResponse> PublicDeleteEntryByKey(ulong userID, string key)
		{
			return null;
		}

		public static Request<Dictionary<string, string>> PublicGetEntries(ulong userID)
		{
			return null;
		}

		public static Request<Dictionary<string, string>> PublicGetEntryByKey(ulong userID, string key)
		{
			return null;
		}

		public static Request<UserDataStoreUpdateResponse> PublicWriteEntry(ulong userID, string key, string value)
		{
			return null;
		}
	}
}
