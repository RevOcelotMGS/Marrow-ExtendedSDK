using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Arena_DataManager : MonoBehaviour
{
	public bool visDebug;

	public Arena_Stats arenaStats;

	private static string ArenaSavePath
	{
		get
		{
			return null;
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private IEnumerator CoWaitLoadOrCreate()
	{
		return null;
	}

	public void SaveArenaPlayer()
	{
	}

	public void LoadOrCreateArenaPlayerFile()
	{
	}

	public void DeleteArenaPlayerFile()
	{
	}

	public Arena_DataManager()
		: base()
	{
	}
}
