using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.SFX
{
	public class MusicAmbience2dSFX : MonoBehaviour
	{
		[Serializable]
		public class AmbAndMusic
		{
			public AudioSource ambMus;

			public AudioClip clip;

			public bool isFading;

			public float fadeTarget;

			public float fadePerSec;

			public void UpdateFade()
			{
			}

			public void FadeOut(float fadeOutTime)
			{
			}

			public void FadeIn(AudioClip ambClip, float fadeTar, float fadeInTime)
			{
			}

			public void AttenuateCurrent(float fadeTar, float fadeInTime)
			{
			}

			public AmbAndMusic()
				: base()
			{
			}
		}

		private static ComponentCache<MusicAmbience2dSFX> _cache;

		public AmbAndMusic[] ambAndMusics;

		public AudioMixerGroup AmbientMixerGroup;

		public AudioMixerGroup MusicMixerGroup;

		private int _curAmb;

		private int _curMus;

		private Coroutine _loopPending;

		private bool _isOverride;

		private bool _overridenHasIntro;

		private AudioClip _overridenMusicClip;

		private float _overridenTargetVol;

		private float _overridenFadeInTime;

		private float _overridenFadeOutTime;

		private bool _overridenLoop;

		private AudioClip _overridenMusicIntro;

		private float _overridenLoopTransitionFade;

		private IEnumerator _overrideCallback;

		private float[] tempData;

		private float minFadeTime;

		private Coroutine fadeRoutine;

		public AudioMixer mixer;

		public AudioReverbData prevReverbObj;

		public AudioReverbData reverbObj;

		public static ComponentCache<MusicAmbience2dSFX> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void CueOverrideMusic(AudioClip musicClip, float targetVol, float fadeInTime, float fadeOutTime, bool loop = true, bool timedRelease = true)
		{
		}

		public void StopOverrideMusic(AudioClip musicClip, float fadeOutTime)
		{
		}

		private IEnumerator OverrideCallback(float releaseTime)
		{
			return null;
		}

		public void CueAmbience(AudioClip ambienceClip, float targetVol, float fadeInTime, float fadeOutTime)
		{
		}

		public void CueMusic(AudioClip musicClip, float targetVol, float fadeInTime, float fadeOutTime, bool loop = true)
		{
		}

		public void CueMusicLoopWithIntro(AudioClip musicIntro, AudioClip musicLoop, float targetVol, float fadeInTime, float fadeOutTime, float loopTransitionFade)
		{
		}

		public void StopMusic(AudioClip musicClip, float fadeOutTime)
		{
		}

		private void Update()
		{
		}

		private IEnumerator LoopCue(AudioClip loop, float introLength, float tranFade)
		{
			return null;
		}

		public float GetParamVal(string name, float value)
		{
			return default(float);
		}

		public void FadeToNewReverb(AudioReverbData reverbData)
		{
		}

		private IEnumerator CoFadeReverbData(float fadeTime)
		{
			return null;
		}

		private void StopFadeRoutine()
		{
		}

		public MusicAmbience2dSFX()
			: base()
		{
		}
	}
}
