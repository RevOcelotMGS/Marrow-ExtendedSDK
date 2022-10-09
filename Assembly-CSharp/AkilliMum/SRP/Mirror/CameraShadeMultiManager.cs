using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace AkilliMum.SRP.Mirror
{
	public class CameraShadeMultiManager : EffectBase
	{
		private IList<CameraShade> _originalCameraShades;

		private CameraShade[,] _copyCameraShades;

		private IList<RenderTexture>[,] _copyTextures;

		[Tooltip("Mirror in mirror recursive count")]
		[Range(1f, 10f)]
		public int Depth;

		[Tooltip("Please use this to give unique id's to mirrors which will be drawn together. So if you want to see a mirror inside another mirror, their id must be same!")]
		public string MirrorInMirrorId;

		[Tooltip("Decreases the size of the reflection 2 over X times for each depth, so you may gain performance but may lose reality!")]
		[Range(0f, 10f)]
		public float DecreaseSize2OverXTimes;

		[Tooltip("Draws shadows only for first X depth (if applicable on real mirror, if it is not; if will disable it anyway)!")]
		[Range(1f, 10f)]
		public int ShadowDepth;

		[Tooltip("Disables the MSAA after Xth depth (if applicable on real mirror, if it is not; if will disable it anyway)!")]
		[Range(1f, 10f)]
		public int DisableMSAAAfterXthDepth;

		[Range(1f, 10f)]
		[Tooltip("Disables the pixel lights after Xth depth (if applicable on real mirror, if it is not; if will disable it anyway)!")]
		public int DisablePixelLightsAfterXthDepth;

		[NonSerialized]
		public Camera _camera;

		[NonSerialized]
		public ScriptableRenderContext _context;

		private Camera[] cameraList;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void InitializeProperties()
		{
		}

		public void ExecuteBeforeCameraRender(ScriptableRenderContext context, Camera cameraSrp)
		{
		}

		private int GetNextCamIndex(int camIndex)
		{
			return default(int);
		}

		public void RenderReflective()
		{
		}

		public CameraShadeMultiManager()
			: base()
		{
		}
	}
}
