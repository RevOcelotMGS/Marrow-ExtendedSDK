using System;
using System.Runtime.InteropServices;

namespace Steam.VR.Features
{
	internal delegate int Type_xrGetInstanceProcAddr(ulong instance, string name, [Out] IntPtr function);
}
