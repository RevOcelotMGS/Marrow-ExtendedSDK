using System;
using SLZ.Marrow.Data;
using UnityEngine;

[Serializable]
public class ArenaLootItem
{
	public enum LootType
	{
		LIGHTGUN = 0,
		MEDGUN = 1,
		MELEE = 2,
		HEAVYGUN = 3
	}

	[Range(0f, 100f)]
	public float percentage;

	public string title;

	public Spawnable spawnable;

	public LootType lootType;

	public ArenaLootItem()
		: base()
	{
	}
}
