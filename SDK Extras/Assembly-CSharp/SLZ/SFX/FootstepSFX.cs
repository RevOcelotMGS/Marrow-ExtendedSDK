using SLZ.Data;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.SFX
{
	public class FootstepSFX : MonoBehaviour
	{
		public AudioMixerGroup outputMixer;

		public float volumeMult;

		public AudioClip[] walkConcrete;

		public AudioClip[] runConcrete;

		public AudioVarianceData walkOverride;

		public AudioVarianceData runOverride;

		private AudioSource source;

		private void Awake()
		{
		}

		public void PlayStep(float velocitySqr)
		{
		}

		public FootstepSFX()
			: base()
		{
		}
	}
}
