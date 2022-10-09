using System;
using UnityEngine;

[Serializable]
public class AllianceEntry
{
	public string key;

	public string speciesX;

	public string speciesY;

	public float agression;

	public Vector2 graphPos;

	public int index;

	public AllianceEntry()
		: base()
	{
	}
}
