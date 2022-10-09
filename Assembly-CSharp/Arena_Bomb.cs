using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Arena_Bomb : MonoBehaviour
{
	private Coroutine countdownRoutine;

	[SerializeField]
	private float timeValue;

	[SerializeField]
	private AudioClip initClip;

	[SerializeField]
	private AudioClip explodeClip;

	[SerializeField]
	private TMP_Text timerText;

	[SerializeField]
	private UnityEvent explodeEvent;

	[SerializeField]
	private GameObject expandSphereObj;

	private Vector3 endScale;

	public void StartCountdown(float seconds = 20f)
	{
	}

	private IEnumerator CoCountdown()
	{
		return null;
	}

	private void UpdateTimeDisplay()
	{
	}

	[ContextMenu("DEFUSE")]
	public void DefuseCountdown()
	{
	}

	[ContextMenu("ExplodeBomb")]
	public void ExplodeBomb()
	{
	}

	private IEnumerator CoExpand()
	{
		return null;
	}

	public Arena_Bomb()
		: base()
	{
	}
}
