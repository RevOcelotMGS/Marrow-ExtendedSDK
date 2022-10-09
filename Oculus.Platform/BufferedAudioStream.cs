using UnityEngine;

public class BufferedAudioStream
{
	private const bool VerboseLogging = false;

	private AudioSource audio;

	private float[] audioBuffer;

	private int writePos;

	private const float bufferLengthSeconds = 0.25f;

	private const int sampleRate = 48000;

	private const int bufferSize = 12000;

	private const float playbackDelayTimeSeconds = 0.05f;

	private float playbackDelayRemaining;

	private float remainingBufferTime;

	public BufferedAudioStream(AudioSource audio)
		: base()
	{
	}

	public void Update()
	{
	}

	private void Stop()
	{
	}

	public void AddData(float[] samples)
	{
	}
}
