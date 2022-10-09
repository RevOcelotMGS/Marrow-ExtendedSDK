using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Zones
{
	public class Zone3dSound : ZoneItem
	{
		public Transform[] targetTran;

		public AudioClip clip;

		[Tooltip("Putting clips into random will override and randomize which clip it plays")]
		public AudioClip[] randomClip;

		public AudioMixerGroup mixerGroup;

		[Range(0f, 1f)]
		[Tooltip("Higher than 1 numbers increase min sphere by 1 meter per unit over 1")]
		public float primaryVolume;

		[Range(0f, 1f)]
		[Tooltip("Higher than 1 numbers increase min sphere by 1 meter per unit over 1")]
		public float secondaryVolume;

		public float pitch;

		[Tooltip("Higher number fades faster")]
		[Range(0.1f, 4f)]
		public float fadeSpeed;

		[Range(0.1f, 10f)]
		[Tooltip("Radius of min sphere")]
		public float sourceRadius;

		[Tooltip("Should source loop?")]
		public bool loop;

		private bool _fadeActive;

		private bool _inPrimary;

		private AudioPlayer _ap;

		private float _curVol;

		[Tooltip("0 = no delays, any other value, will cause wait to happen randomly between value and 50% of value")]
		public float waitTime;

		private float _nextFirable;

		private bool _useRandomClip;

		private int _randomClipIndex;

		private int _randomTransformIndex;

		public AudioPlayer audioPlayer
		{
			get
			{
				return null;
			}
		}

		public void SetSecondaryVolume(float volume)
		{
		}

		public override void OnSecondaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneExited(GameObject playerObject)
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		private void PlayNew(Action callback = default(Action))
		{
		}

		private IEnumerator Fade(float fadeTarget, float fadeTime)
		{
			return null;
		}

		private float randomizeFloat(float max, float minMultiplier)
		{
			return default(float);
		}

		public void StopSound()
		{
		}

		public Zone3dSound()
			: base()
		{
		}
	}
}
