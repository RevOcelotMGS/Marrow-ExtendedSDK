using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace MK.Glow.URP
{
	[VolumeComponentMenu("Post-processing/MK/MKGlow")]
	[ExecuteInEditMode]
	public class MKGlow : VolumeComponent, IPostProcessComponent, ISettings
	{
		[Serializable]
		public sealed class RenderPriorityParameter : VolumeParameter<RenderPriority>
		{

			public RenderPriorityParameter()
				: base()
			{
			}
		}

		[Serializable]
		public sealed class Texture2DParameter : VolumeParameter<Texture2D>
		{


			public Texture2DParameter()
				: base()
			{
			}
		}

		[Serializable]
		public sealed class DebugViewParameter : VolumeParameter<DebugView>
		{


			public DebugViewParameter()
				: base()
			{
			}
		}

		[Serializable]
		public sealed class QualityParameter : VolumeParameter<Quality>
		{


			public QualityParameter()
				: base()
			{
			}
		}

		[Serializable]
		public sealed class AntiFlickerModeParameter : VolumeParameter<AntiFlickerMode>
		{


			public AntiFlickerModeParameter()
				: base()
			{
			}
		}

		[Serializable]
		public sealed class WorkflowParameter : VolumeParameter<Workflow>
		{


			public WorkflowParameter()
				: base()
			{
			}
		}

		[Serializable]
		public sealed class LayerMaskParameter : VolumeParameter<LayerMask>
		{


			public LayerMaskParameter()
				: base()
			{
			}
		}

		[Serializable]
		public sealed class MinMaxRangeParameter : VolumeParameter<MinMaxRange>
		{


			public MinMaxRangeParameter()
				: base()
			{
			}
		}

		[Serializable]
		public sealed class GlareStyleParameter : VolumeParameter<GlareStyle>
		{


			public GlareStyleParameter()
				: base()
			{
			}
		}

		[Serializable]
		public sealed class LensFlareStyleParameter : VolumeParameter<LensFlareStyle>
		{


			public LensFlareStyleParameter()
				: base()
			{
			}
		}

		public BoolParameter allowGeometryShaders;

		public BoolParameter allowComputeShaders;

		public RenderPriorityParameter renderPriority;

		public DebugViewParameter debugView;

		public QualityParameter quality;

		public AntiFlickerModeParameter antiFlickerMode;

		public WorkflowParameter workflow;

		public LayerMaskParameter selectiveRenderLayerMask;

		[Range(-1f, 1f)]
		public ClampedFloatParameter anamorphicRatio;

		[Range(0f, 1f)]
		public ClampedFloatParameter lumaScale;

		[Range(0f, 1f)]
		public ClampedFloatParameter blooming;

		[MinMaxRange(0f, 10f)]
		public MinMaxRangeParameter bloomThreshold;

		[Range(1f, 10f)]
		public ClampedFloatParameter bloomScattering;

		public FloatParameter bloomIntensity;

		public BoolParameter allowLensSurface;

		public Texture2DParameter lensSurfaceDirtTexture;

		public FloatParameter lensSurfaceDirtIntensity;

		public Texture2DParameter lensSurfaceDiffractionTexture;

		public FloatParameter lensSurfaceDiffractionIntensity;

		public BoolParameter allowLensFlare;

		public LensFlareStyleParameter lensFlareStyle;

		[Range(0f, 25f)]
		public ClampedFloatParameter lensFlareGhostFade;

		public FloatParameter lensFlareGhostIntensity;

		[MinMaxRange(0f, 10f)]
		public MinMaxRangeParameter lensFlareThreshold;

		[Range(0f, 8f)]
		public ClampedFloatParameter lensFlareScattering;

		public Texture2DParameter lensFlareColorRamp;

		[Range(-100f, 100f)]
		public ClampedFloatParameter lensFlareChromaticAberration;

		[Range(0f, 5f)]
		public ClampedIntParameter lensFlareGhostCount;

		[Range(-1f, 1f)]
		public ClampedFloatParameter lensFlareGhostDispersal;

		[Range(0f, 25f)]
		public ClampedFloatParameter lensFlareHaloFade;

		public FloatParameter lensFlareHaloIntensity;

		[Range(0f, 1f)]
		public ClampedFloatParameter lensFlareHaloSize;

		public BoolParameter allowGlare;

		[Range(0f, 1f)]
		public ClampedFloatParameter glareBlend;

		public FloatParameter glareIntensity;

		[Range(0f, 360f)]
		public ClampedFloatParameter glareAngle;

		[MinMaxRange(0f, 10f)]
		public MinMaxRangeParameter glareThreshold;

		[Range(1f, 4f)]
		public ClampedIntParameter glareStreaks;

		[Range(0f, 4f)]
		public ClampedFloatParameter glareScattering;

		public GlareStyleParameter glareStyle;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample0Scattering;

		[Range(0f, 360f)]
		public ClampedFloatParameter glareSample0Angle;

		public FloatParameter glareSample0Intensity;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample0Offset;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample1Scattering;

		[Range(0f, 360f)]
		public ClampedFloatParameter glareSample1Angle;

		public FloatParameter glareSample1Intensity;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample1Offset;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample2Scattering;

		[Range(0f, 360f)]
		public ClampedFloatParameter glareSample2Angle;

		public FloatParameter glareSample2Intensity;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample2Offset;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample3Scattering;

		[Range(0f, 360f)]
		public ClampedFloatParameter glareSample3Angle;

		public FloatParameter glareSample3Intensity;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample3Offset;

		public bool IsActive()
		{
			return default(bool);
		}

		public bool IsTileCompatible()
		{
			return default(bool);
		}

		public bool GetAllowGeometryShaders()
		{
			return default(bool);
		}

		public bool GetAllowComputeShaders()
		{
			return default(bool);
		}

		public RenderPriority GetRenderPriority()
		{
			return default(RenderPriority);
		}

		public RenderPriority SetRenderPriority(RenderPriority TargetParameter)
		{
			return default(RenderPriority);
		}

		public DebugView GetDebugView()
		{
			return default(DebugView);
		}

		public Quality SetQuality(Quality InputQuality)
		{
			return default(Quality);
		}

		public Quality GetQuality()
		{
			return default(Quality);
		}

		public AntiFlickerMode GetAntiFlickerMode()
		{
			return default(AntiFlickerMode);
		}

		public Workflow GetWorkflow()
		{
			return default(Workflow);
		}

		public LayerMask GetSelectiveRenderLayerMask()
		{
			return default(LayerMask);
		}

		public float GetAnamorphicRatio()
		{
			return default(float);
		}

		public float GetLumaScale()
		{
			return default(float);
		}

		public float GetBlooming()
		{
			return default(float);
		}

		public MinMaxRange GetBloomThreshold()
		{
			return default(MinMaxRange);
		}

		public float GetBloomScattering()
		{
			return default(float);
		}

		public float GetBloomIntensity()
		{
			return default(float);
		}

		public bool GetAllowLensSurface()
		{
			return default(bool);
		}

		public Texture2D GetLensSurfaceDirtTexture()
		{
			return null;
		}

		public float GetLensSurfaceDirtIntensity()
		{
			return default(float);
		}

		public Texture2D GetLensSurfaceDiffractionTexture()
		{
			return null;
		}

		public float GetLensSurfaceDiffractionIntensity()
		{
			return default(float);
		}

		public bool GetAllowLensFlare()
		{
			return default(bool);
		}

		public LensFlareStyle GetLensFlareStyle()
		{
			return default(LensFlareStyle);
		}

		public float GetLensFlareGhostFade()
		{
			return default(float);
		}

		public float GetLensFlareGhostIntensity()
		{
			return default(float);
		}

		public MinMaxRange GetLensFlareThreshold()
		{
			return default(MinMaxRange);
		}

		public float GetLensFlareScattering()
		{
			return default(float);
		}

		public Texture2D GetLensFlareColorRamp()
		{
			return null;
		}

		public float GetLensFlareChromaticAberration()
		{
			return default(float);
		}

		public int GetLensFlareGhostCount()
		{
			return default(int);
		}

		public float GetLensFlareGhostDispersal()
		{
			return default(float);
		}

		public float GetLensFlareHaloFade()
		{
			return default(float);
		}

		public float GetLensFlareHaloIntensity()
		{
			return default(float);
		}

		public float GetLensFlareHaloSize()
		{
			return default(float);
		}

		public void SetLensFlareGhostFade(float fade)
		{
		}

		public void SetLensFlareGhostCount(int count)
		{
		}

		public void SetLensFlareGhostDispersal(float dispersal)
		{
		}

		public void SetLensFlareHaloFade(float fade)
		{
		}

		public void SetLensFlareHaloSize(float size)
		{
		}

		public bool GetAllowGlare()
		{
			return default(bool);
		}

		public float GetGlareBlend()
		{
			return default(float);
		}

		public float GetGlareIntensity()
		{
			return default(float);
		}

		public float GetGlareAngle()
		{
			return default(float);
		}

		public MinMaxRange GetGlareThreshold()
		{
			return default(MinMaxRange);
		}

		public int GetGlareStreaks()
		{
			return default(int);
		}

		public void SetGlareStreaks(int count)
		{
		}

		public float GetGlareScattering()
		{
			return default(float);
		}

		public GlareStyle GetGlareStyle()
		{
			return default(GlareStyle);
		}

		public float GetGlareSample0Scattering()
		{
			return default(float);
		}

		public float GetGlareSample0Angle()
		{
			return default(float);
		}

		public float GetGlareSample0Intensity()
		{
			return default(float);
		}

		public float GetGlareSample0Offset()
		{
			return default(float);
		}

		public void SetGlareSample0Scattering(float scattering)
		{
		}

		public void SetGlareSample0Angle(float angle)
		{
		}

		public void SetGlareSample0Intensity(float intensity)
		{
		}

		public void SetGlareSample0Offset(float offset)
		{
		}

		public float GetGlareSample1Scattering()
		{
			return default(float);
		}

		public float GetGlareSample1Angle()
		{
			return default(float);
		}

		public float GetGlareSample1Intensity()
		{
			return default(float);
		}

		public float GetGlareSample1Offset()
		{
			return default(float);
		}

		public void SetGlareSample1Scattering(float scattering)
		{
		}

		public void SetGlareSample1Angle(float angle)
		{
		}

		public void SetGlareSample1Intensity(float intensity)
		{
		}

		public void SetGlareSample1Offset(float offset)
		{
		}

		public float GetGlareSample2Scattering()
		{
			return default(float);
		}

		public float GetGlareSample2Angle()
		{
			return default(float);
		}

		public float GetGlareSample2Intensity()
		{
			return default(float);
		}

		public float GetGlareSample2Offset()
		{
			return default(float);
		}

		public void SetGlareSample2Scattering(float scattering)
		{
		}

		public void SetGlareSample2Angle(float angle)
		{
		}

		public void SetGlareSample2Intensity(float intensity)
		{
		}

		public void SetGlareSample2Offset(float offset)
		{
		}

		public float GetGlareSample3Scattering()
		{
			return default(float);
		}

		public float GetGlareSample3Angle()
		{
			return default(float);
		}

		public float GetGlareSample3Intensity()
		{
			return default(float);
		}

		public float GetGlareSample3Offset()
		{
			return default(float);
		}

		public void SetGlareSample3Scattering(float scattering)
		{
		}

		public void SetGlareSample3Angle(float angle)
		{
		}

		public void SetGlareSample3Intensity(float intensity)
		{
		}

		public void SetGlareSample3Offset(float offset)
		{
		}

		public MKGlow()
			: base()
		{
		}
	}
}
