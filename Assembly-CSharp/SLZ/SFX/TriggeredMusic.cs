using System;
using UnityEngine;

namespace SLZ.SFX
{
	public class TriggeredMusic : MonoBehaviour
	{
		[Serializable]
		public struct MusicCue
		{
			public AudioClip clipIntro;

			public AudioClip clipMain;

			[Tooltip("checked on, will only play once, otherwise will loop")]
			public bool onlyPlayOnce;

			[HideInInspector]
			public bool hasPlayedOnce;
		}

		public MusicCue[] tracks;

		[Range(0f, 1f)]
		public float volume;

		[Range(0f, 10f)]
		public float fadeInTime;

		[Range(0f, 10f)]
		public float fadeOutTime;

		[Tooltip("This lives on the player head.  RigManager > PhysicsRig > Head > MusicAmbience2dSFX")]
		public MusicAmbience2dSFX musicAmb2dSFX;

		private int _currentTrack;

		public void PlayMusic(int clip)
		{
		}

		public void StopMusic(float fadeTime)
		{
		}

		private void Play(MusicAmbience2dSFX headSfx, int clip)
		{
		}

		public TriggeredMusic()
			: base()
		{
		}
	}
}
