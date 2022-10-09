using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Utilities
{
	public class AudioPlayer : SpawnEvents
	{
		private static ComponentCache<AudioPlayer> _cache;

		[SerializeField]
		private AudioSource _source;

		private bool _hasStartedPlaying;

		private AudioMixerGroup _defaultMixerGroup;

		private float _defaultVolume;

		private bool _defaultLoop;

		private float _defaultPitch;

		private float _defaultMinDistance;

		private float _defaultSpatialBlend;

		private float _defaultDopplerLevel;

		private const float _lowPitchRange = 0.88f;

		private const float _highPitchRange = 1.12f;

		public static ComponentCache<AudioPlayer> Cache
		{
			get
			{
				return null;
			}
		}

		public AudioSource source
		{
			get
			{
				return null;
			}
		}

		protected void Awake()
		{
		}

		protected override void OnDespawn(GameObject go)
		{
		}

		protected override void OnSpawn(GameObject go)
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public static void PlayAtPoint(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup = default(AudioMixerGroup), float? volume = default(float?), bool? isLooping = default(bool?), float? pitch = default(float?), float? minDistance = default(float?))
		{
		}

		public static void PlayAtPoint(AudioClip[] clips, Vector3 position, AudioMixerGroup mixerGroup = default(AudioMixerGroup), float? volume = default(float?), bool? isLooping = default(bool?), float? pitch = default(float?), float? minDistance = default(float?))
		{
		}

		public void Play(AudioClip clip, AudioMixerGroup mixerGroup = default(AudioMixerGroup), float? volume = default(float?), bool? isLooping = default(bool?), float? pitch = default(float?), float? minDistance = default(float?), float? spatialBlend = default(float?))
		{
		}

		public void Play(AudioClip[] clips, AudioMixerGroup mixerGroup = default(AudioMixerGroup), float? volume = default(float?), bool? isLooping = default(bool?), float? pitch = default(float?), float? minDistance = default(float?), float? spatialBlend = default(float?))
		{
		}

		public void Attenuate(float? volume = default(float?), float? pitch = default(float?), float? minDistance = default(float?))
		{
		}

		public void Stop()
		{
		}

		public void SetSpatialBlend(float blend)
		{
		}

		public AudioPlayer()
			: base()
		{
		}
	}
}
