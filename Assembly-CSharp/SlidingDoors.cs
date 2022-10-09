using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using UnityEngine;
using UnityEngine.Events;

public class SlidingDoors : MonoBehaviour
{
	[SerializeField]
	private Arena_GameController arenaGameController;

	public bool isLocked;

	public bool isOpen;

	public GameObject leftDoor;

	public GameObject rightDoor;

	public AudioClip openClip;

	public AudioClip closeClip;

	public AudioClip lockedClip;

	public Coroutine slideRoutine;

	private Vector3 openLeft;

	private Vector3 openRight;

	private Vector3 closeLeft;

	private Vector3 closeRight;

	public List<AIBrain> npcBrainList;

	public float eventDelayTime;

	public UnityEvent CloseEvent;

	public UnityEvent OpenEvent;

	private Coroutine waitRoutine;

	public Powerable_Joint doorJoint;

	private void Awake()
	{
	}

	public void TogglePlayerDoorLock(bool isLocking)
	{
	}

	public void CloseAndLockPlayerDoor()
	{
	}

	public void TogglePlayerDoor(bool open)
	{
	}

	public void LockPlayerDoor()
	{
	}

	public void UnlockPlayerDoor()
	{
	}

	public void CloseDoor()
	{
	}

	[ContextMenu("FastOpen")]
	public void FastOpen()
	{
	}

	[ContextMenu("ForceOpenPlayerDoor")]
	public void ForceOpenPlayerDoor()
	{
	}

	[ContextMenu("PlayerEnter")]
	public void PlayerEnter()
	{
	}

	[ContextMenu("PlayerExit")]
	public void PlayerExit()
	{
	}

	private IEnumerator CoWaitAndToggleEvent()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public void NPCEnter(AIBrain currBrain)
	{
	}

	public void NPCExit(AIBrain currBrain)
	{
	}

	[ContextMenu("ToggleDoor")]
	public void ToggleDoor()
	{
	}

	private IEnumerator CoSlide(Vector3 startPosLeft, Vector3 endPosLeft, Vector3 startPosRight, Vector3 endPosRight)
	{
		return null;
	}

	public SlidingDoors()
		: base()
	{
	}
}
