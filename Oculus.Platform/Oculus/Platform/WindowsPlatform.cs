using System;
using System.Runtime.InteropServices;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class WindowsPlatform
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void UnityLogDelegate(IntPtr tag, IntPtr msg);

		private void CPPLogCallback(IntPtr tag, IntPtr message)
		{
		}

		private IntPtr getCallbackPointer()
		{
			return default(IntPtr);
		}

		public bool Initialize(string appId)
		{
			return default(bool);
		}

		public Request<PlatformInitialize> AsyncInitialize(string appId)
		{
			return null;
		}

		public WindowsPlatform()
			: base()
		{
		}
	}
}
