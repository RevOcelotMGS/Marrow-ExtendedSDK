using Assets.Marrow_ExtendedSDK.StubClasses;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Steam.VR.Features
{
	public class PosePredictionFeature : OpenXRFeature
	{
		internal delegate int Type_xrLocateSpace(ulong space, ulong baseSpace, long time, IntPtr location);

		public const string featureId = "com.valve.openxr.poseprediction";

		private ulong instanceHandle;

		public long additionalPrediction;

		private Type_xrGetInstanceProcAddr xrGetInstanceProcAddrDelegate;

		private Type_xrLocateSpace xrLocateSpace;

		private IntPtr realLocateSpacePointer;

		private IntPtr realGetProcPointer;

		public bool initialized;

		private List<Delegate> callbacks;

		protected override bool OnInstanceCreate(ulong xrInstance)
		{
			return default(bool);
		}

		protected override void OnInstanceDestroy(ulong xrInstance)
		{
		}

		private void InitializeFunctions()
		{
		}

		protected IntPtr GetCallback<T>(T functionAddr) where T : Delegate
		{
			return default(IntPtr);
		}

		protected override IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return default(IntPtr);
		}

		public int override_xrGetInstanceProcAddr(ulong instance, string name, [Out] IntPtr function)
		{
			return default(int);
		}

		public int override_xrLocateSpace(ulong space, ulong baseSpace, long time, IntPtr location)
		{
			return default(int);
		}

		public PosePredictionFeature()
			: base()
		{
		}
	}
}
