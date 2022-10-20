using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.SFX
{
	public class TriggeredAudio : MonoBehaviour
	{
		public AudioClip[] audioClips;

		public float volume;

		public float min_distance;

		public float pitch;

		public AudioMixerGroup mixingGroup;

		public void PlayAudio()
		{
		}

		public TriggeredAudio()
			: base()
		{
		}
	}
}
