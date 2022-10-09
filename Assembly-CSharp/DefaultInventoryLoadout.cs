using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Player;
using UnityEngine;

public class DefaultInventoryLoadout : MonoBehaviour
{
	[Serializable]
	public struct SlotSpawnPair
	{
		public string slotName;

		public Spawnable spawnable;

		public SlotSpawnPair(string slotName, Spawnable spawnable)
		{
			this.spawnable = default(Spawnable);
			this.slotName = default(string);
		}
	}

	public Inventory inventory;

	public SlotSpawnPair[] spawnInSlotData;

	private void Awake()
	{
	}

	public void Reset()
	{
	}

	private void OnGameReady()
	{
	}

	private UniTaskVoid SpawnInSlotsAsync()
	{
		return default(UniTaskVoid);
	}

	public DefaultInventoryLoadout()
		: base()
	{
	}
}
