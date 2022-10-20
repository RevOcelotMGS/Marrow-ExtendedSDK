using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Zones;
using UnityEngine;

public class AIHeadbanger : MonoBehaviour
{
	public ZoneSpawner[] danceSpawners;

	public float danceTick;

	private Coroutine _danCo;

	private bool _danceBeat;

	private bool _danceLeft;

	public void ToggleDance(bool on)
	{
	}

	public IEnumerator DanceCo()
	{
		return null;
	}

	public AIHeadbanger()
		: base()
	{
	}
}
