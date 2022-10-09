using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.VFX;
using UnityEngine;

public class AvatarPedestal : MonoBehaviour
{
	public GenericCrateReference selectedCrate;

	public GachaCapsule gacha;

	public GameObject dome;

	public GameObject lightGlow;

	public Blip domeBlip;

	private bool called;

	public void Awake()
	{
	}

	public void UNLOCKAVATAR()
	{
	}

	public IEnumerator DestroyDome()
	{
		return null;
	}

	public AvatarPedestal()
		: base()
	{
	}
}
