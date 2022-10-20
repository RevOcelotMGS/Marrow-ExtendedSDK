using System;
using SLZ.Marrow.Warehouse;
using UnityEngine;

public class SpawnableDoorStateSetter : MonoBehaviour
{
	[Serializable]
	public class SpawnableDoorGroup
	{
		public GameObject door;

		public SpawnableCratePlacer[] items;

		public string saveVar;

		public bool overrideOpen;

		public SpawnableDoorGroup()
			: base()
		{
		}
	}

	public float doorHighOffset;

	public float doorLowOffset;

	public SpawnableDoorGroup[] doors;

	public void Start()
	{
	}

	public void OVERRIDEALLOPEN()
	{
	}

	public void OPENDOOR(int i)
	{
	}

	public SpawnableDoorStateSetter()
		: base()
	{
	}
}
