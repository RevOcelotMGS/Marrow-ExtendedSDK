using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class CityBlock : MonoBehaviour
{
	[Header("PLAYER LOCATION")]
	public TextMeshProUGUI txt_playerPos;

	public TextMeshProUGUI txt_headingVector;

	public TextMeshProUGUI txt_timeToArrival;

	public TextMeshProUGUI txt_distance;

	public TextMeshProUGUI txt_blockLocation;

	public TextMeshProUGUI txt_location;

	public Vector3 blockLocation;

	public string location;

	public Transform beacon;

	public Transform entity;

	public string timeToArrival;

	[Header("META DIAGNOSTICS")]
	public TextMeshProUGUI txt_buildInfo;

	public TextMeshProUGUI txt_buildTitle;

	public string buildTitle;

	public string buildState;

	private string buildDate;

	[Header("PHYSICS DISPLAY")]
	public TextMeshProUGUI txt_timeStep;

	public TextMeshProUGUI txt_timeScale;

	public TextMeshProUGUI txt_gravity;

	public TextMeshProUGUI txt_particleCount;

	private void Awake()
	{
	}

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

	public void UPDATEDISPLAYONCE()
	{
	}

	public CityBlock()
		: base()
	{
	}
}
