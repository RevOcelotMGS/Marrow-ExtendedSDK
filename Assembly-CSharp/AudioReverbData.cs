using System;
using UnityEngine;

[CreateAssetMenu(fileName = "AudioReverbData", menuName = "StressLevelZero/Audio Reverb Data", order = 2)]
public class AudioReverbData : ScriptableObject
{
	[Serializable]
	public struct ReverbData
	{
		public string paramName;

		public float paramValue;

		[HideInInspector]
		public float minRange;

		[HideInInspector]
		public float maxRange;

		public ReverbData(string name, float val, float min, float max)
		{
			this.maxRange = default(float);
			this.minRange = default(float);
			this.paramValue = default(float);
			this.paramName = default(string);
		}
	}

	public ReverbData[] reverbData;

	public AudioReverbData()
		: base()
	{
	}
}
