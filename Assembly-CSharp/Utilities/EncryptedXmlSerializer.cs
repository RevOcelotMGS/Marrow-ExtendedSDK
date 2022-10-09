using System.Security.Cryptography;

namespace Utilities
{
	public static class EncryptedXmlSerializer
	{
		private static readonly string PrivateKey;

		public static T Load<T>(string path) where T : class
		{
			return null;
		}

		public static void Save<T>(string path, object value) where T : class
		{
		}

		private static string EncryptData(string toEncrypt)
		{
			return null;
		}

		private static string DecryptData(string toDecrypt)
		{
			return null;
		}

		private static RijndaelManaged CreateRijndaelManaged()
		{
			return null;
		}
	}
}
