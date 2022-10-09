using SLZ.Data.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

[RequireComponent(typeof(SpawnableCratePlacer))]
public class OnlyPlaceIfUnlocked : MonoBehaviour
{
	public SpawnableCratePlacer cratePlacer;

	private static PlayerUnlocks u
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

	public OnlyPlaceIfUnlocked()
		: base()
	{
	}
}
