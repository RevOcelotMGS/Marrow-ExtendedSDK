using HTC.UnityPlugin.FoveatedRendering;

namespace UnityEngine.Rendering.Universal
{
	public class VRSPlugin : ScriptableRendererFeature
	{
		public struct RegionShadingRates
		{
			public ShadingRatePreset preset;

			public ShadingRate inner;

			public ShadingRate middle;

			public ShadingRate peripheral;
		}

		public struct RegionRadii
		{
			public ShadingPatternPreset preset;

			public Vector2 inner;

			public Vector2 middle;

			public Vector2 peripheral;
		}

		private class VRSInitialize : ScriptableRenderPass
		{
			private VRSPlugin caller;

			private RegionShadingRates shadeRates;

			private RegionRadii radii;

			public VRSInitialize(RenderPassEvent evt, VRSPlugin caller)
				: base()
			{
			}

			public override void OnCameraSetup(CommandBuffer cmd, RenderingData renderingData)
			{
			}

			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		private class VRSDisable : ScriptableRenderPass
		{
			public VRSDisable(RenderPassEvent evt)
				: base()
			{
			}

			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		private class VRSReEnable : ScriptableRenderPass
		{
			public VRSReEnable(RenderPassEvent evt)
				: base()
			{
			}

			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		private static bool hasInitialized;

		[SerializeField]
		public bool HBAOCompatibility;

		[SerializeField]
		public ShadingRatePreset shadingRatePreset;

		[SerializeField]
		public ShadingRate innerShadingRate;

		[SerializeField]
		public ShadingRate middleShadingRate;

		[SerializeField]
		public ShadingRate peripheralShadingRate;

		[SerializeField]
		public ShadingPatternPreset shadingPatternPreset;

		public Vector2 innerRadii;

		public Vector2 middleRadii;

		public Vector2 peripheralRadii;

		private VRSInitialize initPass;

		private VRSDisable disableBeforeHBAO;

		private VRSReEnable enableAfterHBAO;

		private VRSDisable disableBeforeBlitPass;

		private VRSReEnable enableAfterBlitPass;

		private VRSDisable disableAfterRenderPass;

		public override void Create()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		public static void Initialize(float verticalFOV, float aspectRatio, bool isVR, RegionShadingRates rates, RegionRadii radii)
		{
		}

		public VRSPlugin()
			: base()
		{
		}
	}
}
