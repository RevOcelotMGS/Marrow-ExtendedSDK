using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.VFX
{
	[RequireComponent(typeof(ParticleSystem))]
	public class ParticleTimeWarp : MonoBehaviour
	{
		[SerializeField]
		private float TrailMotionBlurFrames;

		[SerializeField]
		private float MaxParticleLifetime;

		[SerializeField]
		private ParticleSystem PS;

		[SerializeField]
		private ParticleSystem.TrailModule trails;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void updateTrail()
		{
		}

		private IEnumerator updateTrails()
		{
			return null;
		}

		public ParticleTimeWarp()
			: base()
		{
		}
	}
}
