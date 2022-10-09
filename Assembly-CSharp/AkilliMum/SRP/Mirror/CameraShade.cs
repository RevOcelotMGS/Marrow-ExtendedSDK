using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace AkilliMum.SRP.Mirror
{
	[ExecuteAlways]
	public class CameraShade : EffectBase
	{
		[Tooltip("Please use this to enable/disable the script. DO NOT USE script's enable/disable check box!")]
		public bool IsEnabled;

		[Tooltip("You can name your script for to understand what is it for. Because if you use a lot of reflection scripts, you can forget which one is which :)")]
		public string Name;

		[Tooltip("Please use this to enable/disable the mirror in mirror effect. Use careful for performance reasons!")]
		public bool IsMirrorInMirror;

		[Tooltip("Please use this to give unique id's to mirrors which will be drawn together. So if you want to see a mirror inside another mirror, their id must be same!")]
		public string MirrorInMirrorId;

		[Tooltip("Check this if you suffer reflection glitches. Because camera may occlude some objects according to unity settings!")]
		public bool TurnOffOcclusion;

		[Tooltip("Use object bounds for viewport? Use this if you have only one mirror object attached to the script.")]
		public bool UseObjectBoundsForViewport;

		[Tooltip("Please select the correct Device Type (Normal for stand alone, AR for augmented reality, Correct VR device for virtual reality device etc.!")]
		public DeviceType DeviceType;

		[Tooltip("'Reflect' (mirror, reflective surface, transparent glass etc.) and 'Transparent' (transparent AR surface) is supported only right now.")]
		public WorkType WorkType;

		[Tooltip("The mirror object's normal direction. Most of the time default 'GreenY' works perfectly. But try others if you get strange behavior.")]
		public FollowVector UpVector;

		[Tooltip("Reflection intensity. 0 none to 1 perfect.")]
		[Range(0f, 1f)]
		public float Intensity;

		[Tooltip("Disables the GI, if you want perfect reflections check this (like mirrors)")]
		public bool DisableGBuffer;

		[Range(1f, 20f)]
		[Tooltip("Runs the script for every Xth frame; you may gain the fps, but you will lose the reality (realtime) of reflection!")]
		public int RunForEveryXthFrame;

		[Range(0f, 10f)]
		[Tooltip("Starts to drawing at this level of LOD. So if you do not creating perfect mirrors, you can use lower lods for surface and gain fps.")]
		public int CameraLODLevel;

		[Range(0f, 10f)]
		[Tooltip("Creates the mipmaps of the texture and uses the Xth value, you can use it specially for blur effects.")]
		public int TextureLODLevel;

		private int _oldTextureLODLevel;

		[Tooltip("Enables the HDR, so post effects will be visible (like bloom) on the reflection.")]
		public bool HDR;

		private bool _oldHDR;

		[Tooltip("Enables the anti aliasing (if only enabled in the project settings) for reflection.")]
		public bool MSAA;

		[Tooltip("Disables the point and spot lights for the reflection. You may gain the fps, but you will lose the reality of reflection.")]
		public bool DisablePixelLights;

		private IList<SceneLights> _additionalLights;

		[Tooltip("Enables the shadow on reflection. If you disable it; you may gain the fps, but you will lose the reality of reflection.")]
		public bool Shadow;

		[Tooltip("Enables the culling distance calculations.")]
		public bool Cull;

		[Tooltip("Cull circle distance, so it just draws the objects in the distance. You may gain the fps, but you will lose the reality of reflection.")]
		public float CullDistance;

		[Tooltip("Easy selection for reflection quality. Select 'Full' for perfect reflections! VR can render half; so select x2 etc. and try to find the best visual!")]
		public TextureSizeType TextureSize;

		[Tooltip("The size (quality) of the reflection if manual is selected above! It should be set to width of the screen for perfect reflection! But try lower values to gain fps.")]
		public int ManualSize;

		private int _oldTextureSize;

		[Tooltip("Does not works right now, will be used on next releases.")]
		public bool UseCameraClipPlane;

		[Tooltip("Clipping distance to draw the reflection X units from the surface.")]
		public float ClipPlaneOffset;

		[Tooltip("Only these layers will be rendered by the reflection. So you can select what to be reflected with the reflection by putting them on certain layers.")]
		public LayerMask ReflectLayers;

		[Tooltip("Only these layers will be rendered by the direct render (like water). So you can select what to be rendered with the direct-render by putting them on certain layers.")]
		public LayerMask DirectLayers;

		[Tooltip("Use this option if you use CULL-ing or Reflect-Layers != Everything. So, not reflected surfaces blend with texture nicely.")]
		public bool MixBlackColor;

		[Tooltip("Enables the advanced depth blur calculations.")]
		public bool EnableDepthBlur;

		private bool _oldEnableDepthBlur;

		[Tooltip("Depth blur shader to run on reflection texture.")]
		public Shader DepthBlurShader;

		private Material _depthBlurMaterial;

		[Range(0f, 30f)]
		[Tooltip("Changes the depth distance, so the objects near to the reflective surface becomes more visible or not.")]
		public float DepthBlurCutoff;

		[Tooltip("Runs the depth blur shader on reflection texture X times. Larger iterations make more blurry images (but may decrease the fps)!")]
		[Range(1f, 20f)]
		public int DepthBlurIterations;

		[Tooltip("This option makes the less blur on the pixels which are closer to surface. So you can make the far away pixels (on depth) more blurry!")]
		[Range(1f, 20f)]
		public float DepthBlurSurfacePower;

		[Range(1f, 50f)]
		[Tooltip("Normally depth blur makes a circle blur. You can change this value if you want more horizontal blur!")]
		public int DepthBlurHorizontalMultiplier;

		[Range(1f, 50f)]
		[Tooltip("Normally depth blur makes a circle blur. You can change this value if you want more vertical blur!")]
		public int DepthBlurVerticalMultiplier;

		[Tooltip("Enables the simple depth calculations.")]
		public bool EnableSimpleDepth;

		private bool _oldEnableSimpleDepth;

		[Range(0f, 10f)]
		[Tooltip("Changes the depth distance, so the objects near to the reflective surface becomes more visible or not.")]
		public float SimpleDepthCutoff;

		[Tooltip("Reflective surfaces (gameObjects) must be put here with their's shader! Script calculates the reflection according to their position etc.")]
		public Shade[] Shades;

		private List<Renderer> _renderers;

		[Tooltip("Enables some effects on reflection, like blur etc.")]
		public bool EnableFinalShader;

		[Tooltip("Effect shader (like blur) must be put here to run on reflection texture.")]
		public Shader FinalShader;

		private Material _finalMaterial;

		[Tooltip("In full transparent AR, blur may mix with black color. This option may reduce the artifacts.")]
		public bool EnableARMode;

		[Tooltip("Runs the effect shader on reflection texture X times. For example if it is a blur, larger iterations makes more blury images (but may decrease the fps)!")]
		[Range(1f, 20f)]
		public int Iterations;

		[Tooltip("Takes the Xth neighbour pixel on blur calculations. Change it until you get desired effect.")]
		public float NeighbourPixels;

		[Tooltip("Does not works right now. Will be used on next releases.")]
		public float BlockSize;

		[Tooltip("Enables the refraction on reflection.")]
		public bool EnableRefraction;

		[Tooltip("You can give refractions to the reflection. Use a refraction normal map here.")]
		public Texture2D RefractionTexture;

		[Tooltip("Refraction intensity according to the 'Refraction Texture'. Bigger values creates more refraction!")]
		public float Refraction;

		[Tooltip("Enables a simple wave simulation on the surface.")]
		public bool EnableWaves;

		[Tooltip("Noise texture to create the wave effect.")]
		public Texture2D WaveNoiseTexture;

		[Tooltip("Wave size. Just adapt it according to your needs.")]
		public float WaveSize;

		[Tooltip("Refraction distortion size. Just adapt it according to your needs.")]
		public float WaveDistortion;

		[Tooltip("Speed of the wave simulation. Just adapt it according to your needs.")]
		public float WaveSpeed;

		[Tooltip("Enables a simple ripple simulation on the surface.")]
		public bool EnableRipples;

		[Tooltip("Ripple normal map to create the ripple effect.")]
		public Texture2D RippleTexture;

		[Tooltip("Ripple size. Just adapt it according to your needs.")]
		public float RippleSize;

		[Tooltip("Refraction distortion size. Just adapt it according to your needs.")]
		public float RippleRefraction;

		[Tooltip("Ripple density size. Just adapt it according to your needs.")]
		public float RippleDensity;

		[Tooltip("Speed of the ripple simulation. Just adapt it according to your needs.")]
		public float RippleSpeed;

		[Tooltip("Enables masking on the surface. So you can create wetness, semi reflective surfaces, ices etc.")]
		public bool EnableMask;

		[Tooltip("Alpha based masking texture.")]
		public Texture2D MaskTexture;

		[Tooltip("Tiling for the texture if you want to replicate the masking along the surface.")]
		public Vector2 MaskTiling;

		[Tooltip("Mask cutoff to change the alpha based calculations.")]
		[Range(0f, 1f)]
		public float MaskCutoff;

		[Tooltip("Gives a little darkness to the edges of the alpha base texture. So you can simulate a fake depth (like water) on masking.")]
		[Range(1f, 50f)]
		public float MaskEdgeDarkness;

		private int _stereoEye;

		private bool _isObjectVisible;

		private bool _usePreviousTexture;

		public const string CamNameStartsWith = "Mirror Refl Camera id ";

		[NonSerialized]
		public Camera _camera;

		public Camera _cameraAttachedTo;

		[NonSerialized]
		public ScriptableRenderContext _context;

		private GameObject ReflectionCameraPrefab;

		private GameObject _reflectionCameraPrefabInstance;

		private Hashtable _reflectionCameras;

		private RenderTexture _reflectionTexture1;

		private RenderTexture _reflectionTexture1Other;

		private RenderTexture _reflectionTexture2;

		private RenderTexture _reflectionTexture2Other;

		private RenderTexture _reflectionTexture3;

		private RenderTexture _reflectionTexture3Other;

		private RenderTexture _opaqueTexture1;

		private RenderTexture _opaqueTexture1Other;

		private RenderTexture _reflectionTextureDepth;

		private RenderTexture _reflectionTextureOtherDepth;

		private RenderTexture _reflectionTexture1_copy;

		private RenderTexture _reflectionTexture1Other_copy;

		private RenderTexture _reflectionTexture2_copy;

		private RenderTexture _reflectionTexture2Other_copy;

		private RenderTexture _reflectionTexture3_copy;

		private RenderTexture _reflectionTexture3Other_copy;

		private RenderTexture _reflectionTextureDepth_copy;

		private RenderTexture _reflectionTextureOtherDepth_copy;

		protected virtual void OnEnable()
		{
		}

		public void InitializeProperties()
		{
		}

		private void Update()
		{
		}

		private void OnGUI()
		{
		}

		public void ExecuteBeforeCameraRender(ScriptableRenderContext context, Camera cameraSrp)
		{
		}

		public virtual IList<Camera> RenderReflective(CameraShadeMultiManager manager, Camera sentCamera = default(Camera), bool invert = true, bool renderCam = true)
		{
			return null;
		}

		private Camera GetCamera(Camera sentCamera)
		{
			return null;
		}

		public virtual void CommonRender(ScriptableRenderContext context, Camera cameraSrp)
		{
		}

		private Camera RenderMe(CameraShadeMultiManager manager, Camera sentCamera, bool invert = true, bool renderCam = true)
		{
			return null;
		}

		private Rect GetBoundRect(Matrix4x4 mat)
		{
			return default(Rect);
		}

		private Matrix4x4 GetBoundMatrix(Rect rect)
		{
			return default(Matrix4x4);
		}

		private Vector3 WorldPointToViewport(Matrix4x4 mat, Vector3 point)
		{
			return default(Vector3);
		}

		public bool CheckFrustum(Camera cam)
		{
			return default(bool);
		}

		public bool IsObjectVisible(Camera cam)
		{
			return default(bool);
		}

		public void UpdateMaterialProperties(Camera sentCamera)
		{
		}

		public IList<RenderTexture> CopyTextures()
		{
			return null;
		}

		public void PasteTextures(IList<RenderTexture> textures)
		{
		}

		private Vector4 CameraSpacePlane(Matrix4x4 worldToCameraMatrix, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		private static float sgn(float a)
		{
			return default(float);
		}

		private static void MakeProjectionMatrixOblique(Matrix4x4 matrix, Vector4 clipPlane)
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		public int[] GetTextureSizes()
		{
			return null;
		}

		private void CreateMirrorObjects(Camera currentCamera, [Out] Camera reflectionCamera)
		{
		}

		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		private void CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		private T CopyComponent<T>(T original, GameObject destination) where T : Component
		{
			return null;
		}

		public CameraShade()
			: base()
		{
		}
	}
}
