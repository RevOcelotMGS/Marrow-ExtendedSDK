using SLZ.Zones;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.SFX
{
	public class ZoneMusic : ZoneItem
	{
		public bool onlyPlayOnce;

		public AudioClip clipIntro;

		[FormerlySerializedAs("clipToCue")]
		public AudioClip clipMain;

		[Range(0f, 1f)]
		public float volume;

		public bool loop;

		[Range(0f, 10f)]
		public float fadeInTime;

		[Range(0f, 10f)]
		public float fadeOutTime;

		[Header("OnEnter")]
		public bool playOnEnter;

		public bool stopOnEnter;

		[Header("OnExit")]
		public bool stopOnExit;

		private bool _hasPlayedOnce;

		private void Play(MusicAmbience2dSFX headSfx)
		{
		}

		public void PlayMusic(float fadeTime)
		{
		}

		public void StopMusic(float fadeTime)
		{
		}

		private void Stop(MusicAmbience2dSFX headSfx)
		{
		}

		public override void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneExited(GameObject playerObject)
		{
		}

		public ZoneMusic()
			: base()
		{
		}
	}
}
