using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.SFX
{
	public class SlowMoSFX : MonoBehaviour
	{
		public AudioClip decelTime;

		public AudioClip accelTime;

		public AudioMixerGroup outputMixer;

		private AudioSource source;

		private void Start()
		{
		}

		public void TimeSpaceWarp(float oldTime)
		{
		}

		public SlowMoSFX()
			: base()
		{
		}
	}
}
