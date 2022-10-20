using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Bonelab
{
	public class GameControl_BigAnomalyA : BonelabInternalGameControl
	{
		[Header("Animation Stuff")]
		[SerializeField]
		private GameObject bodyLogObj;

		[SerializeField]
		private GameObject lightingRoot;

		[SerializeField]
		private GameObject targetObj;

		[SerializeField]
		[Header("FX")]
		private GameObject lightningBoltObj;

		[SerializeField]
		private MeshRenderer lightningRend;

		[SerializeField]
		private GameObject lightingHitParticles;

		[SerializeField]
		private GameObject lightingHitParticles2;

		[SerializeField]
		private GameObject lightingPathParticles;

		[Header("Audio")]
		public AudioMixerGroup outputMixer;

		[SerializeField]
		private AudioClip shockClip;

		[SerializeField]
		private AudioClip hitClip;

		public void AquireBodyLog()
		{
		}

		[ContextMenu("TestStrike")]
		public void TestStrike()
		{
		}

		public void TargetLightning(Vector3 target)
		{
		}

		private IEnumerator CoLightingPos()
		{
			return null;
		}

		private IEnumerator CoLightningFX(Vector3 target)
		{
			return null;
		}

		public GameControl_BigAnomalyA()
			: base()
		{
		}
	}
}
