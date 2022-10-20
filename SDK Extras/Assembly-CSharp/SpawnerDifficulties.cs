using SLZ.Marrow.Data;
using SLZ.Zones;
using UnityEngine;

public class SpawnerDifficulties : MonoBehaviour
{
	[SerializeField]
	private ZoneSpawner zoneSpawner;

	[SerializeField]
	private ZoneAISettings zoneAISettings;

	[SerializeField]
	private int currentDifficulty;

	[Header("Easy Data")]
	public Spawnable easySpawnable;

	public bool easyHomeIsPost;

	public Transform easySpawnPoint;

	[Header("Medium Data")]
	public Spawnable mediumSpawnable;

	public bool mediumHomeIsPost;

	public Transform mediumSpawnPoint;

	[Header("Hard Data")]
	public Spawnable hardSpawnable;

	public bool hardHomeIsPost;

	public Transform hardSpawnPoint;

	[ContextMenu("GetZoneData")]
	public void GetZoneData()
	{
	}

	public void ApplyDifficulty(int diff)
	{
	}

	public SpawnerDifficulties()
		: base()
	{
	}
}
