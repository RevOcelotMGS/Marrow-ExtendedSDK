using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class MineDiveTarget : MonoBehaviour
{
	[SerializeField]
	private ConfigurableJoint joint;

	[SerializeField]
	private Quaternion goalRot;

	private JointDrive jointDrive;

	[SerializeField]
	private float delayTime;

	[SerializeField]
	private bool isLocked;

	[SerializeField]
	private float jointSpringForce;

	public bool isPractice;

	public int isWorth;

	public UnityEvent OnGoDown;

	public UnityEvent OnGoUp;

	public static Action<MineDiveTarget> hitAction;

	public void AttackTarget()
	{
	}

	private IEnumerator CoWaitForTarget()
	{
		return null;
	}

	private void UnlockJoint()
	{
	}

	[ContextMenu("GetJoint")]
	public void GetJoint()
	{
	}

	public MineDiveTarget()
		: base()
	{
	}
}
