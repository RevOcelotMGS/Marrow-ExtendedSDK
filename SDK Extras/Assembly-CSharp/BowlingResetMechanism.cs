using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Warehouse;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

public class BowlingResetMechanism : MonoBehaviour
{
	public GameObject[] pins;

	private ConfigurableJoint[] joints;

	private ConfigurableJoint[] closeJoints;

	public Vector3 jointDriveSettings;

	public float cycleTime;

	public float maxResetTime;

	public float scoreTimmer;

	public float posEpsilon;

	public float rotEpsilon;

	private IEnumerator pinCycle;

	private JointDrive minDrive;

	private JointDrive maxDrive;

	public Collider[] pinColliders;

	public PhysicMaterial normalFriction;

	public PhysicMaterial noFriction;

	public AudioMixerGroup outputMixer;

	public AudioClip pullSFX;

	public AudioClip dropSFX;

	private AudioPlayer ap;

	public SpawnableCrateReference[] whiteListCrates;

	private Dictionary<string, int> whiteListObjects;

	private Dictionary<int, AssetPoolee> objectsInTrigger;

	private List<AssetPoolee> objectsToSweep;

	private Vector3[] pinOriginalPos;

	private bool isScoring;

	private bool isPlayerInTrigger;

	private bool isBallInTrigger;

	public void Start()
	{
	}

	public void PINAWOKEN()
	{
	}

	private IEnumerator ScoreAndResetCoroutine()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private int CheckScore()
	{
		return default(int);
	}

	private bool PinDownCheck(GameObject pin)
	{
		return default(bool);
	}

	private void CheckPinReset()
	{
	}

	public void RESETPINS()
	{
	}

	private IEnumerator PinResetCycle()
	{
		return null;
	}

	public BowlingResetMechanism()
		: base()
	{
	}
}
