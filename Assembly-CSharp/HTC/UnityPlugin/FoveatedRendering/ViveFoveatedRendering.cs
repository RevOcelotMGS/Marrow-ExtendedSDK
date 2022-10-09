using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace HTC.UnityPlugin.FoveatedRendering
{
	[RequireComponent(typeof(Camera))]
	public class ViveFoveatedRendering : MonoBehaviour
	{
		private Camera thisCamera;

		private CommandBufferManager commandBufferMgr;

		private bool foveatedRenderingInited;

		private bool foveatedRenderingActivated;

		private RenderMode renderMode;

		[SerializeField]
		private bool manualAdjustment;

		[SerializeField]
		private ShadingRatePreset shadingRatePreset;

		[SerializeField]
		private ShadingPatternPreset patternPreset;

		[SerializeField]
		private Vector2 innerRegionRadii;

		[SerializeField]
		private Vector2 middleRegionRadii;

		[SerializeField]
		private Vector2 peripheralRegionRadii;

		[SerializeField]
		private ShadingRate innerShadingRate;

		[SerializeField]
		private ShadingRate middleShadingRate;

		[SerializeField]
		private ShadingRate peripheralShadingRate;

		public void EnableFoveatedRendering(bool activate)
		{
		}

		public void SetShadingRatePreset(ShadingRatePreset inputPreset)
		{
		}

		public ShadingRatePreset GetShadingRatePreset()
		{
			return default(ShadingRatePreset);
		}

		public void SetPatternPreset(ShadingPatternPreset inputPreset)
		{
		}

		public ShadingPatternPreset GetPatternPreset()
		{
			return default(ShadingPatternPreset);
		}

		public void SetShadingRate(TargetArea targetArea, ShadingRate rate)
		{
		}

		public ShadingRate GetShadingRate(TargetArea targetArea)
		{
			return default(ShadingRate);
		}

		public void SetRegionRadii(TargetArea targetArea, Vector2 radii)
		{
		}

		public Vector2 GetRegionRadii(TargetArea targetArea)
		{
			return default(Vector2);
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPreRender()
		{
		}

		public ViveFoveatedRendering()
			: base()
		{
		}
	}
}
