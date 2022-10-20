using System;
using SLZ.Marrow.Data;
using UnityEngine;

[Serializable]
public class SpawnableGroup
{
	public Spawnable spawnable;

	public GameObject[] spawnPoints;

	public float minVel;

	public SpawnableGroup()
		: base()
	{
	}
}
