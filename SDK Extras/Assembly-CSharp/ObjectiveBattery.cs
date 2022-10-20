using System;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using TMPro;
using UnityEngine;

public class ObjectiveBattery : MonoBehaviour
{
	private static ComponentCache<ObjectiveBattery> _cache;

	public float charge;

	public TMP_Text chargeText;

	public Grip grip;

	private float energyPerc;

	[SerializeField]
	private GameObject energyBarObj;

	private Vector3 startBar;

	[SerializeField]
	private Vector3 endBar;

	public static Action OnBattteryGrabbed;

	public static ComponentCache<ObjectiveBattery> Cache
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

	private void Awake()
	{
	}

	public void UpdateCharge(float energy)
	{
	}

	public void DecrementCharge(float energy)
	{
	}

	private void OnGrab(Hand hand)
	{
	}

	public ObjectiveBattery()
		: base()
	{
	}
}
