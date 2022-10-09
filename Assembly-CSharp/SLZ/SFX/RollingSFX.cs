using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.SFX
{
	public class RollingSFX : MonoBehaviour
	{
		public Rigidbody[] wheels;

		public AudioMixerGroup outputMixer;

		public GameObject sourceObj;

		public float maxAngularV;

		public float realtimeUpdateFrequency;

		public float wheelRadius;

		public float minSpeed;

		public float maxSpeed;

		private AudioPlayer _ap;

		private bool _hasAp;

		public AudioClip spinningNotColliding;

		public AudioClip rollingWithCollision;

		private bool wheelColliding;

		private WaitForSecondsRealtime _wfsRealtime;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnCollisionEnter()
		{
		}

		private void OnCollisionExit()
		{
		}

		private IEnumerator UpdateSound()
		{
			return null;
		}

		public RollingSFX()
			: base()
		{
		}
	}
}
