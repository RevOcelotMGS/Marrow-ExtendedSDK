using System;
using System.Runtime.InteropServices;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public sealed class StandalonePlatform
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void UnityLogDelegate(IntPtr tag, IntPtr msg);

		public Request<PlatformInitialize> InitializeInEditor()
		{
			return null;
		}

		public Request<PlatformInitialize> AsyncInitialize(ulong appID, string accessToken)
		{
			return null;
		}

		public StandalonePlatform()
			: base()
		{
		}
	}
}
