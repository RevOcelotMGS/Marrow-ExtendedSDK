using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Utilities;
using UnityEngine;

namespace SLZ.SFX
{
	public class GravGunSFX : MonoBehaviour
	{
		public AudioClip[] gravFire;

		public AudioClip grab;

		public AudioClip release;

		public AudioClip[] gravLocked;

		public AudioClip[] gravDrop;

		public AudioClip holdLoop;

		private float _targetVolume;

		private AudioPlayer _ap;

		private WaitForSecondsRealtime _wait;

		private Coroutine updateGravHoldCoroutine;

		public float publicPitchModifier;

		private float pitchModifier;

		private bool isGravPull;

		private void OnEnable()
		{
		}

		public void Grab()
		{
		}

		public void GravLocked()
		{
		}

		public void GravFire()
		{
		}

		public void GravDrop()
		{
		}

		public void GravPull()
		{
		}

		public void GravRelax()
		{
		}

		public void Release()
		{
		}

		public void SetPitchModifier(float pitch)
		{
		}

		public void StopSound()
		{
		}

		private void OnDisable()
		{
		}

		private IEnumerator UpdateGravHold()
		{
			return null;
		}

		public GravGunSFX()
			: base()
		{
		}
	}
}
