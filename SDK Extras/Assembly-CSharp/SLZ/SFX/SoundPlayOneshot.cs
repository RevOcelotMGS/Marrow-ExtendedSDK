using UnityEngine;

namespace SLZ.SFX
{
	public class SoundPlayOneshot : MonoBehaviour
	{
		public AudioClip[] waveFiles;

		private AudioSource thisAudioSource;

		public float volMin;

		public float volMax;

		public float pitchMin;

		public float pitchMax;

		public bool playOnAwake;

		private void Awake()
		{
		}

		public void Play()
		{
		}

		public void Pause()
		{
		}

		public void UnPause()
		{
		}

		public SoundPlayOneshot()
			: base()
		{
		}
	}
}
