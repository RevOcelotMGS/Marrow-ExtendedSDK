using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class taxiFare : MonoBehaviour
{
	public TextMeshProUGUI txt_fare;

	public TextMeshProUGUI txt_rideNumber;

	public TextMeshProUGUI txt_timeUntilArrive;

	public TextMeshProUGUI txt_travelDirection;

	public TextMeshProUGUI txt_destinationName;

	[Space(20f)]
	public string destinationName;

	public string cur_fareCost;

	private string _rideNumber;

	public float secondsUntilArrive;

	private float cur_secondsUntilArrive;

	public bool countFare;

	public Transform thisVehicle;

	public Transform destinationBeacon;

	private Vector3 destinationPos;

	private IEnumerator Start()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public IEnumerator Calculate()
	{
		return null;
	}

	public void UPDATEDISPLAY()
	{
	}

	public taxiFare()
		: base()
	{
	}
}
