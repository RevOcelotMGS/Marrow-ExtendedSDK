using System;
using UnityEngine;

namespace HTC.UnityPlugin.FoveatedRendering
{
	public class ViveFoveatedRenderingAPI
	{
		public delegate void UnityStrCallback(string str);

		private const string LIB_NAME = "ViveFoveatedRendering";

		public static extern IntPtr GetRenderEventFunc();

		public static extern bool InitializeFoveatedRendering(float verticalFov, float aspectRatio);

		public static extern void ReleaseFoveatedRendering();

		public static extern void SetRenderMode(RenderMode mode);

		public static extern void SetFoveatedRenderingPatternPreset(ShadingPatternPreset preset);

		public static extern void SetFoveatedRenderingShadingRatePreset(ShadingRatePreset preset);

		public static extern void SetRegionRadii(TargetArea targetArea, Vector2 radii);

		public static extern void SetShadingRate(TargetArea targetArea, ShadingRate rate);

		public static extern void SetNormalizedGazeDirection(Vector3 leftEyeDir, Vector3 rightEyeDir);

		public static extern void InitializeNativeLogger(UnityStrCallback log);

		public static extern void ReleaseNativeLogger();

		public static extern void GetVidPid(UnityStrCallback addVidCallback, UnityStrCallback addPidCallback);

		public ViveFoveatedRenderingAPI()
			: base()
		{
		}
	}
}
