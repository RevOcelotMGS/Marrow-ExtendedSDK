using System.Runtime.InteropServices;
using UnityEngine;

public class LeanAudio
{
	public static float MIN_FREQEUNCY_PERIOD;

	public static int PROCESSING_ITERATIONS_MAX;

	public static float[] generatedWaveDistances;

	public static int generatedWaveDistancesCount;

	private static float[] longList;

	public static LeanAudioOptions options()
	{
		return null;
	}

	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = default(LeanAudioOptions))
	{
		return null;
	}

	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = default(LeanAudioOptions))
	{
		return null;
	}

	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	private static void OnAudioSetPosition(int newPosition)
	{
	}

	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	public static void printOutAudioClip(AudioClip audioClip, AnimationCurve curve, float scaleX = 1f)
	{
	}

	public LeanAudio()
		: base()
	{
	}
}
