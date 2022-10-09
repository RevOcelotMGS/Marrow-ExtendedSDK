using UnityEngine;

[CreateAssetMenu(fileName = "Station", menuName = "StressLevelZero/Radio/Station")]
public class RadioStation : ScriptableObject
{
	public string stationName;

	public RadioSong[] trackList;

	public bool randomized;

	public RadioStation()
		: base()
	{
	}
}
