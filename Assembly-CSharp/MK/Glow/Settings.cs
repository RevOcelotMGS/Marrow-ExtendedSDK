using UnityEngine;

namespace MK.Glow
{
	internal abstract class Settings
	{
		protected bool _allowGeometryShaders;

		protected bool _allowComputeShaders;

		protected RenderPriority _renderPriority;

		protected DebugView _debugView;

		protected Quality _quality;

		protected AntiFlickerMode _antiFlickerMode;

		protected Workflow _workflow;

		protected LayerMask _selectiveRenderLayerMask;

		protected float _anamorphicRatio;

		protected float _lumaScale;

		protected float _blooming;

		protected MinMaxRange _bloomThreshold;

		protected float _bloomScattering;

		protected float _bloomIntensity;

		protected bool _allowLensSurface;

		protected Texture2D _lensSurfaceDirtTexture;

		protected float _lensSurfaceDirtIntensity;

		protected Texture2D _lensSurfaceDirtDistortionTexture;

		protected float _lensSurfaceDirtDistortion;

		protected Texture2D _lensSurfaceDiffractionTexture;

		protected float _lensSurfaceDiffractionIntensity;

		protected bool _allowLensFlare;

		protected LensFlareStyle _lensFlareStyle;

		protected float _lensFlareGhostFade;

		protected float _lensFlareGhostIntensity;

		protected MinMaxRange _lensFlareThreshold;

		protected float _lensFlareScattering;

		protected Texture2D _lensFlareColorRamp;

		protected float _lensFlareChromaticAberration;

		protected int _lensFlareGhostCount;

		protected float _lensFlareGhostDispersal;

		protected float _lensFlareHaloFade;

		protected float _lensFlareHaloIntensity;

		protected float _lensFlareHaloSize;

		protected bool _allowGlare;

		protected float _glareBlend;

		protected float _glareIntensity;

		protected float _glareAngle;

		protected MinMaxRange _glareThreshold;

		protected int _glareStreaks;

		protected float _glareScattering;

		protected GlareStyle _glareStyle;

		protected float _glareSample0Scattering;

		protected float _glareSample0Angle;

		protected float _glareSample0Intensity;

		protected float _glareSample0Offset;

		protected float _glareSample1Scattering;

		protected float _glareSample1Angle;

		protected float _glareSample1Intensity;

		protected float _glareSample1Offset;

		protected float _glareSample2Scattering;

		protected float _glareSample2Angle;

		protected float _glareSample2Intensity;

		protected float _glareSample2Offset;

		protected float _glareSample3Scattering;

		protected float _glareSample3Angle;

		protected float _glareSample3Intensity;

		protected float _glareSample3Offset;

		internal bool allowGeometryShaders
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal bool allowComputeShaders
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal RenderPriority renderPriority
		{
			get
			{
				return default(RenderPriority);
			}
			set
			{
			}
		}

		internal DebugView debugView
		{
			get
			{
				return default(DebugView);
			}
			set
			{
			}
		}

		internal Quality quality
		{
			get
			{
				return default(Quality);
			}
			set
			{
			}
		}

		internal AntiFlickerMode antiFlickerMode
		{
			get
			{
				return default(AntiFlickerMode);
			}
			set
			{
			}
		}

		internal Workflow workflow
		{
			get
			{
				return default(Workflow);
			}
			set
			{
			}
		}

		internal LayerMask selectiveRenderLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		internal float anamorphicRatio
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float lumaScale
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float blooming
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal MinMaxRange bloomThreshold
		{
			get
			{
				return default(MinMaxRange);
			}
			set
			{
			}
		}

		internal float bloomScattering
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float bloomIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal bool allowLensSurface
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal Texture2D lensSurfaceDirtTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal float lensSurfaceDirtIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal Texture2D lensSurfaceDirtDistortionTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal float lensSurfaceDirtDistortion
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal Texture2D lensSurfaceDiffractionTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal float lensSurfaceDiffractionIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal bool allowLensFlare
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal LensFlareStyle lensFlareStyle
		{
			get
			{
				return default(LensFlareStyle);
			}
			set
			{
			}
		}

		internal float lensFlareGhostFade
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float lensFlareGhostIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal MinMaxRange lensFlareThreshold
		{
			get
			{
				return default(MinMaxRange);
			}
			set
			{
			}
		}

		internal float lensFlareScattering
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal Texture2D lensFlareColorRamp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal float lensFlareChromaticAberration
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal int lensFlareGhostCount
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		internal float lensFlareGhostDispersal
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float lensFlareHaloFade
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float lensFlareHaloIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float lensFlareHaloSize
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal bool allowGlare
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal float glareBlend
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareAngle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal MinMaxRange glareThreshold
		{
			get
			{
				return default(MinMaxRange);
			}
			set
			{
			}
		}

		internal int glareStreaks
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		internal float glareScattering
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal GlareStyle glareStyle
		{
			get
			{
				return default(GlareStyle);
			}
			set
			{
			}
		}

		internal float glareSample0Scattering
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample0Angle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample0Intensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample0Offset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample1Scattering
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample1Angle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample1Intensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample1Offset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample2Scattering
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample2Angle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample2Intensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample2Offset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample3Scattering
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample3Angle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample3Intensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal float glareSample3Offset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		internal void SetLensFlarePreset(LensFlareStyle lensFlareStyle)
		{
		}

		internal void SetGlarePreset(GlareStyle glareStyle)
		{
		}

		public Settings()
			: base()
		{
		}
	}
}
