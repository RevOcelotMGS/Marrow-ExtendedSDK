using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using SLZ.Utilities;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Audio;

public class JimmyDoorController : MonoBehaviour
{
	public Seat seat;

	public Rigidbody rb;

	public Transform leashPoint;

	public GauntletElevator elevator;

	public GameControl_BigAnomalyA gameControl;

	public float seatingLength;

	public float yoinkLength;

	public Spawnable vfxFadeOutSpawnable;

	public LevelCrateReference loadScreenLevel;

	public AnimationCurve lerpDistanceCurve;

	public AnimationCurve lerpHeightCurve;

	public GameObject targetRot;

	public ParticleSystem windBlast;

	public AudioMixerGroup outputMixer;

	public AudioClip[] doorSFX;

	public AudioClip portalSFX;

	private AudioPlayer ap1;

	private AudioPlayer ap2;

	private RigManager rM;

	private IEnumerator sequence;

	private int moduleIndex;

	private Renderer fxRenderer;

	private float sequenceStartTime;

	private LevelCrate level;

	private float animTime;

	private int triggerLayer;

	private bool unseat;

	private bool isSeated;

	private bool portalSound;

	private bool isInTrigger;

	private bool isYoinkReady;

	private Vector3 debugGizmo1;

	private Vector3 debugGizmo2;

	private Vector3 debugGizmo3;

	private Vector3 debugGizmo4;

	private Vector3 debugGizmo5;

	private Vector3 debugGizmo6;

	private void Start()
	{
	}

	public void TRIGGERENTER()
	{
	}

	public void TRIGGEREXIT()
	{
	}

	public void STARTYOINK()
	{
	}

	private IEnumerator DoorSequence()
	{
		return null;
	}

	public void LeashPlayer()
	{
	}

	public Vector3 FindNearestPointOnLine(Vector3 origin, Vector3 vector, Vector3 point)
	{
		return default(Vector3);
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public JimmyDoorController()
		: base()
	{
	}
}
