using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.SFX
{
	public class EnemySFX : MonoBehaviour
	{
		public AudioMixerGroup mixerGroup;

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

		public AudioClip dotLoop1;

		public AudioClip agroMovementLoop;

		public AudioClip meanderMovementLoop;

		public AudioClip roamMovementLoop;

		private AudioSource source;

		private AudioSource loopSource;

		private void Start()
		{
		}

		public void Agro()
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

		public void Attack1()
		{
		}

		public void DotLoop1Start(float intensity)
		{
		}

		public void DotLoop1Update(float intensity)
		{
		}

		public void DotLoop1End()
		{
		}

		public EnemySFX()
			: base()
		{
		}
	}
}
