using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GarageDoorControl : MonoBehaviour
{
	public enum Direction
	{
		Down = -1,
		Stationary = 0,
		Up = 1
	}

	public bool Powered;

	[Range(2f, 1000f)]
	[Tooltip("How long it takes to get from [0,1]. Should never be 0 and 2 is the safe minimum threshold")]
	public float DoorDuration;

	private bool m_currentlyMoving;

	private Direction m_dir;

	private Direction m_lastDir;

	public Transform SlatParent;

	public Transform[] SlatArr;

	private Vector3[] m_SlatArrPos;

	public Transform ColliderTrans;

	private Coroutine m_CoDoorUp;

	private Coroutine m_CoDoorDown;

	public float m_upPerc;

	public float m_downPerc;

	private int m_slatUpPrev;

	private int m_slatDownPrev;

	private bool m_doorAllUp;

	private bool m_doorAllDown;

	private float m_slatUpBegIndx;

	private float m_slatDownBegIndx;

	private float m_slatUpCurrIndx;

	private float m_slatDownCurrIndx;

	private float debug_upTimeStart;

	private float debug_downTimeStart;

	private float debug_downTimeEnd;

	public Vector3 currPos;

	public Vector3 startPos;

	public float currDistTraveled;

	public float startTime;

	public float debug_upTimeEnd;

	public float timeTraveled;

	public float currSpeed;

	[HideInInspector]
	public float UpTime;

	[HideInInspector]
	public float DownTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ObjUnderStopGarage(bool isUnder)
	{
	}

	public void UseGarageDoor(Direction activateDir)
	{
	}

	private IEnumerator CoDoorMoveUp()
	{
		return null;
	}

	private IEnumerator CoDoorMoveDown()
	{
		return null;
	}

	private float M_Remap(float value, float from1, float to1, float from2, float to2)
	{
		return default(float);
	}

	private void M_TurnOffSlat(int index, int prevRounded)
	{
	}

	private void M_TurnOnSlat(int index, int prevRounded)
	{
	}

	public GarageDoorControl()
		: base()
	{
	}
}
