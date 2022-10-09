using System.Diagnostics;
using UnityEngine;
using VRCAudioLink.Editor;

namespace VRCAudioLink
{
	public class AudioLink : MonoBehaviour
	{
		private const float AUDIOLINK_VERSION_NUMBER = 2.0800083f;

		[Header("Main Settings")]
		[Tooltip("Should be used with AudioLinkInput unless source is 2D. WARNING: if used with a custom 3D audio source (not through AudioLinkInput), audio reactivity will be attenuated by player position away from the Audio Source")]
		public AudioSource audioSource;

		[Tooltip("Warning: this setting might be taken over by AudioLinkController")]
		[Header("Basic EQ")]
		[Range(0f, 2f)]
		public float gain;

		[Tooltip("Warning: this setting might be taken over by AudioLinkController")]
		[Range(0f, 2f)]
		public float bass;

		[Range(0f, 2f)]
		[Tooltip("Warning: this setting might be taken over by AudioLinkController")]
		public float treble;

		[Header("4 Band Crossover")]
		[Range(0f, 0.168f)]
		[Tooltip("Bass / low mid crossover")]
		public float x0;

		[Range(0.242f, 0.387f)]
		[Tooltip("Bass / low mid crossover")]
		public float x1;

		[Tooltip("Low mid / high mid crossover")]
		[Range(0.461f, 0.628f)]
		public float x2;

		[Tooltip("High mid / treble crossover")]
		[Range(0.704f, 0.953f)]
		public float x3;

		[Tooltip("Bass threshold level (lower is more sensitive)")]
		[Range(0f, 1f)]
		[Header("4 Band Threshold Points (Sensitivity)")]
		public float threshold0;

		[Range(0f, 1f)]
		[Tooltip("Low mid threshold level (lower is more sensitive)")]
		public float threshold1;

		[Tooltip("High mid threshold level (lower is more sensitive)")]
		[Range(0f, 1f)]
		public float threshold2;

		[Tooltip("Treble threshold level (lower is more sensitive)")]
		[Range(0f, 1f)]
		public float threshold3;

		[Tooltip("Amplitude fade amount. This creates a linear fade-off / trails effect. Warning: this setting might be taken over by AudioLinkController")]
		[Range(0f, 1f)]
		[Header("Fade Controls")]
		public float fadeLength;

		[Tooltip("Amplitude fade exponential falloff. This attenuates the above (linear) fade-off exponentially, creating more of a pulsed effect. Warning: this setting might be taken over by AudioLinkController")]
		[Range(0f, 1f)]
		public float fadeExpFalloff;

		[StringInList(new string[] { "ColorChord Colors", "Custom" })]
		[Tooltip("Enable for custom theme colors for Avatars to use.")]
		[Header("Theme Colors")]
		public int themeColorMode;

		public Color customThemeColor0;

		public Color customThemeColor1;

		public Color customThemeColor2;

		public Color customThemeColor3;

		[Header("Internal (Do not modify)")]
		public Material audioMaterial;

		public GameObject audioTextureExport;

		private Shader _shaderAudioLinkExport;

		public RenderTexture audioRenderTexture;

		[Header("Experimental (Limits performance)")]
		[Tooltip("Enable Udon audioData array. Required by AudioReactiveLight and AudioReactiveObject. Uses ReadPixels which carries a performance hit. For experimental use when performance is less of a concern")]
		public bool audioDataToggle;

		public Color[] audioData;

		public Texture2D audioData2D;

		private float[] _spectrumValues;

		private float[] _spectrumValuesTrim;

		private float[] _audioFramesL;

		private float[] _audioFramesR;

		private float[] _samples;

		private float _audioLinkInputVolume;

		private double _masterInstanceJoinTime;

		private double _elapsedTime;

		private double _elapsedTimeMSW;

		private int _networkTimeMS;

		private double _networkTimeMSAccumulatedError;

		private bool _hasInitializedTime;

		private double _FPSTime;

		private int _FPSCount;

		private float _ReadbackTime;

		private Stopwatch stopwatch;

		private int _rightChannelTestDelay;

		private int _rightChannelTestCounter;

		private bool _ignoreRightChannel;

		private double GetElapsedSecondsSince2019()
		{
			return default(double);
		}

		private void Start()
		{
		}

		private void FPSUpdate()
		{
		}

		private void Update()
		{
		}

		private void OnPostRender()
		{
		}

		public void UpdateSettings()
		{
		}

		public void UpdateThemeColors()
		{
		}

		public void SendAudioOutputData()
		{
		}

		private float Remap(float t, float a, float b, float u, float v)
		{
			return default(float);
		}

		public AudioLink()
			: base()
		{
		}
	}
}
