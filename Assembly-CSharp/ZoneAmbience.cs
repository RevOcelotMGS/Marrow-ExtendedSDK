using SLZ.SFX;
using SLZ.Zones;
using UnityEngine;
using UnityEngine.Audio;

public class ZoneAmbience : ZoneItem
{
	[Header("Ambience")]
	public AudioClip clipMain;

	[Range(0f, 1f)]
	public float volume;

	[Range(0f, 10f)]
	public float fadeInTime;

	[Range(0f, 10f)]
	public float fadeOutTime;

	[Header("Reverb")]
	public AudioReverbData reverbObj;

	public AudioMixer mixer;

	private string mixerPath;

	[ContextMenu("BakeCurrentToDataObj")]
	public void GetAllValues()
	{
	}

	public float GetParamVal(string name, float value)
	{
		return default(float);
	}

	[ContextMenu("SetAllData")]
	public void SetAllValues()
	{
	}

	public override void OnPrimaryZoneEntered(GameObject playerObject)
	{
	}

	private void Play(MusicAmbience2dSFX headSfx)
	{
	}

	public ZoneAmbience()
		: base()
	{
	}
}
