using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SwingJointInverter : MonoBehaviour
{
	public ConfigurableJoint configJoint;

	private JointDrive tempMotor;

	[SerializeField]
	private Rigidbody rb;

	public SwingJointManager sjm;

	public float base_slerp_spring;

	public float angle;

	public float limit_min;

	public float limit_max;

	public float vel;

	public float force_mod;

	public float damper_max;

	public float buffer_degrees;

	public float init_deg;

	public float delay_time;

	public bool hold;

	public void ToZero()
	{
	}

	public void SetRot()
	{
	}

	private void OnEnable()
	{
	}

	public IEnumerator StartSequence()
	{
		return null;
	}

	private void SetBaseSpring()
	{
	}

	private float EucNorm(float val)
	{
		return default(float);
	}

	private float MinMaxPolar(float val)
	{
		return default(float);
	}

	private void CheckTargetSwitch()
	{
	}

	private void FixedUpdate()
	{
	}

	public SwingJointInverter()
		: base()
	{
	}
}
