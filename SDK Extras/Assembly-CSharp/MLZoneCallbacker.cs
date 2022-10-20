using System;
using System.Runtime.CompilerServices;
using SLZ.Zones;
using UnityEngine;

public class MLZoneCallbacker : MonoBehaviour
{
	private MLZoneSpawner mlSpawner;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public MLZoneCallbacker()
		: base()
	{
	}

	public event Action OnNewTarget;
}
