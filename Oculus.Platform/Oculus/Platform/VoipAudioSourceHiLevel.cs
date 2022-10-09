using UnityEngine;

namespace Oculus.Platform
{
	public class VoipAudioSourceHiLevel : MonoBehaviour
	{
		public class FilterReadDelegate : MonoBehaviour
		{
			public VoipAudioSourceHiLevel parent;

			private float[] scratchBuffer;

			private void Awake()
			{
			}

			private void OnAudioFilterRead(float[] data, int channels)
			{
			}

			public FilterReadDelegate()
				: base()
			{
			}
		}

		private int initialPlaybackDelayMS;

		public AudioSource audioSource;

		public float peakAmplitude;

		protected IVoipPCMSource pcmSource;

		private static int audioSystemPlaybackFrequency;

		private static bool verboseLogging;

		public ulong senderID
		{
			set
			{
			}
		}

		protected void Stop()
		{
		}

		private VoipSampleRate SampleRateToEnum(int rate)
		{
			return default(VoipSampleRate);
		}

		protected void Awake()
		{
		}

		private void Start()
		{
		}

		protected virtual void CreatePCMSource()
		{
		}

		protected static int MSToElements(int ms)
		{
			return default(int);
		}

		private void Update()
		{
		}

		public VoipAudioSourceHiLevel()
			: base()
		{
		}
	}
}
