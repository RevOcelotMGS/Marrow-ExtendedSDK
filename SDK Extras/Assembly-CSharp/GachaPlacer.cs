using SLZ.Data.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

[RequireComponent(typeof(SpawnableCratePlacer))]
public class GachaPlacer : MonoBehaviour
{
	[SerializeField]
	private GenericCrateReference unlockCrate;

	public SpawnableCratePlacer cratePlacer;

	public bool onlyPlaceIfBeatGame;

	private static PlayerUnlocks u
	{
		get
		{
			return null;
		}
	}

	private static PlayerProgression p
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private bool ShouldPlace()
	{
		return default(bool);
	}

	public void SetGachaContents(SpawnableCratePlacer scp, GameObject go)
	{
	}

	public GachaPlacer()
		: base()
	{
	}
}
