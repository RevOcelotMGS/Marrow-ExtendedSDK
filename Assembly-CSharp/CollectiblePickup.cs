using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CollectiblePickup : MonoBehaviour
{
	public enum CollectibleType
	{
		P = 0,
		R = 1,
		O = 2,
		J = 3,
		E = 4,
		C = 5,
		T = 6,
		F = 7
	}

	public CollectibleType collectibleType;

	public GameObject[] pickupMeshes;

	private bool _isCollected;

	public Action<CollectiblePickup> pickupEvent;

	public AudioClip collectedClip;

	public bool GetCollectionState()
	{
		return default(bool);
	}

	private void OnEnable()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private IEnumerator CoCollectAnimation()
	{
		return null;
	}

	public CollectiblePickup()
		: base()
	{
	}
}
