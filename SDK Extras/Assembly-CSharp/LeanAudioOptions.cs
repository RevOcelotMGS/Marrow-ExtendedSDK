using UnityEngine;

public class LeanAudioOptions
{
	public enum LeanAudioWaveStyle
	{
		Sine = 0,
		Square = 1,
		Sawtooth = 2,
		Noise = 3
	}

	public LeanAudioWaveStyle waveStyle;

	public Vector3[] vibrato;

	public Vector3[] modulation;

	public int frequencyRate;

	public float waveNoiseScale;

	public float waveNoiseInfluence;

	public bool useSetData;

	public LeanAudioStream stream;

	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}

	public LeanAudioOptions()
		: base()
	{
	}
}
