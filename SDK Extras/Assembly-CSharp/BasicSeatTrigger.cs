using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Rig;
using SLZ.Utilities;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Audio;

public class BasicSeatTrigger : MonoBehaviour
{
	public RigManager rM;

	public Seat seat;

	public Rigidbody rb;

	public ConfigurableJoint jnt;

	public Transform statTransform;

	public Transform endTransform;

	public float seatingLength;

	public float yoinkLength;

	public AnimationCurve lerpSpeedCurve;

	public AudioMixerGroup outputMixer;

	public AudioClip[] startSFX;

	public AudioClip[] endSFX;

	public LayerMask castLayers;

	public float initialGravityPulse;

	public float initialRandomTorque;

	public float velocityMultiplier;

	private bool isSeated;

	private bool endSound;

	private AudioPlayer ap1;

	private AudioPlayer ap2;

	private IEnumerator yoinkCoroutine;

	private List<Rigidbody> rigidbodies;

	public void EnterSeat()
	{
	}

	public void Yoink()
	{
	}

	private IEnumerator YoinkCoroutine()
	{
		return null;
	}

	private void GatherRBs()
	{
	}

	private void NullRBGravity()
	{
	}

	private void UpdateRBVelocity(float velocity)
	{
	}

	public BasicSeatTrigger()
		: base()
	{
	}
}
