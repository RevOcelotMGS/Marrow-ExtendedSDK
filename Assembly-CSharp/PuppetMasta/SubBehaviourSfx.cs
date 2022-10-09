using System;
using System.Runtime.CompilerServices;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourSfx : SubBehaviourBase
	{
		public AudioMixerGroup mixerGroup;

		public AudioMixerGroup impactMixerGroup;

		public AudioClip[] agro;

		public AudioClip[] unAgro;

		public AudioClip[] painSmall;

		public AudioClip[] painBig;

		public AudioClip[] death;

		public AudioClip[] jumpCharge;

		public AudioClip[] jump;

		public AudioClip[] smallEffort;

		public AudioClip[] mediumEffort;

		public AudioClip[] largeEffort;

		public AudioClip[] attack1;

		public AudioClip[] attackLand1;

		public AudioClip[] attack2;

		public AudioClip[] impactHead;

		public AudioClip[] impactSpine;

		public AudioClip[] impactLimb;

		public AudioClip dotLoop1;

		public AudioClip agroMovementLoop;

		public AudioClip movementLoop;

		[SerializeField]
		private float pitchMultiplier;

		private AudioSource _mouthSource;

		public AudioSource impactSource;

		private AudioSource _loopSource;

		private float _impactCooldownTime;

		private float _lastImpactImpulse;

		private AudioPlayer _movementPlayer;

		private AudioPlayer _dotLoopPlayer;

		private AudioPlayer _loopPlayer;

		public void Initiate(BehaviourBase b)
		{
		}

		public void Respawn()
		{
		}

		public void BlockImpactsFor(float time)
		{
		}

		public void Impact(MuscleCollision m, float impulse)
		{
		}

		public void Agro()
		{
		}

		public void AttenuateAgroLoop(float volume, float pitch)
		{
		}

		public void AttenuateMovementLoop(float volume, float pitch)
		{
		}

		public void AttenuateDot1Loop(float volume, float pitch, float minDistance)
		{
		}

		public void UnAgro()
		{
		}

		public void JumpCharge()
		{
		}

		public void Jump(float jumpCharge)
		{
		}

		public void Pain(float magnitude)
		{
		}

		public void Death()
		{
		}

		public void SmallEffort()
		{
		}

		public void Attack1()
		{
		}

		public void Attack2()
		{
		}

		public void AttackLand1()
		{
		}

		public void StopLoopSource()
		{
		}

		public SubBehaviourSfx()
			: base()
		{
		}
	}
}
