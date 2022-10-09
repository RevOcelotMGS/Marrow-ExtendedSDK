using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.SFX
{
	public class AmbientSFX : MonoBehaviour
	{
		public AudioMixerGroup mixerGroup;

		public AudioClip[] longPlay;

		public AudioClip powerUp;

		public AudioClip powerDown;

		[Tooltip("Higher than 1 numbers increase min sphere by 1 meter per unit over 1")]
		[Range(0f, 1f)]
		public float volume;

		[Tooltip("Volume of power up event sounds")]
		[Range(0f, 1f)]
		public float powerUpVolume;

		[Range(0.1f, 4f)]
		[Tooltip("Higher number fades faster")]
		public float fadeSpeed;

		[Tooltip("Radius of min sphere")]
		[Range(0f, 10f)]
		public float sourceRadius;

		[Tooltip("Should source loop?")]
		public bool loop;

		[Tooltip("Should source restart when retriggered?")]
		public bool restartLoop;

		[Tooltip("Should source continue to play even if out of range?")]
		public bool playWhileInaudible;

		[Tooltip("Block trigger exits from stopping source?")]
		public bool blockTriggerExit;

		[Tooltip("Is the sound 2d or 3d?")]
		[Range(0f, 1f)]
		public float spatialBlend;

		private float _playheadTime;

		private float _syncTime;

		private float _baseVolume;

		private bool _fadeActive;

		private AudioPlayer _ap;

		public AudioPlayer audioPlayer
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void PowerUp(bool powerUpSound = false)
		{
		}

		public void PowerDown(bool powerDownSound = false)
		{
		}

		public void SetVolume(float attenuation, bool powerSound = false)
		{
		}

		public void SetVolumeDirect(float attenuation)
		{
		}

		private void OnTriggerEnter(Collider c)
		{
		}

		private void PlayNew(Action callback = default(Action))
		{
		}

		private void OnTriggerExit(Collider c)
		{
		}

		private IEnumerator Fade(float fadeTarget, float fadeTime)
		{
			return null;
		}

		public AmbientSFX()
			: base()
		{
		}
	}
}
