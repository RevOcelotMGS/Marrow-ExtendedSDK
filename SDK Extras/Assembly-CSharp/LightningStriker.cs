using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LightningStriker : MonoBehaviour
{
	[SerializeField]
	private GameObject targetObj;

	[SerializeField]
	[Header("FX")]
	private GameObject lightningBoltObj;

	[SerializeField]
	private MeshRenderer lightningRend;

	[SerializeField]
	private GameObject lightingHitParticles;

	[SerializeField]
	private GameObject lightingPathParticles;

	[Header("Audio")]
	[SerializeField]
	private AudioClip shockClip;

	[SerializeField]
	private AudioClip hitClip;

	[ContextMenu("TestStrike")]
	public void TestStrike()
	{
	}

	public void TargetLightning(Vector3 target)
	{
	}

	private IEnumerator CoLightningFX(Vector3 target)
	{
		return null;
	}

	public LightningStriker()
		: base()
	{
	}
}
