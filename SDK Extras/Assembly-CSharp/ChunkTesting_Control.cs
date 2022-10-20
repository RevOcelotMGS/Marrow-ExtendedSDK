using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.SceneStreaming;
using SLZ.Rig;
using UnityEngine;

public class ChunkTesting_Control : MonoBehaviour
{
	public enum Chunks
	{
		CHUNK1 = 0,
		CHUNK2 = 1,
		CHUNK3 = 2,
		CHUNK4 = 3,
		CHUNK5 = 4
	}

	public RigManager rm;

	public Transform chunk1Location;

	public Transform chunk2Location;

	public Transform chunk3Location;

	public Transform chunk4Location;

	public Transform chunk5Location;

	public Chunks startChunk;

	public Chunk airLockForwardChunk;

	public Chunk airLockBackwardChunk;

	public Transform forwardDoor;

	public Transform backwardDoor;

	private Coroutine forwardDoorCoroutine;

	private Coroutine backwardDoorCoroutine;

	private Coroutine airlockCoroutine;

	private bool _isForwardChunkLoaded;

	private bool _isBackwardChunkLoaded;

	private bool _isAirlockChunkLoaded;

	private void Awake()
	{
	}

	private void Teleport()
	{
	}

	public void OnForwardChunkLoaded()
	{
	}

	public void OnBackwardChunkLoaded()
	{
	}

	public void OnAirlockChunkLoaded()
	{
	}

	public void OnForwardChunkUnloaded()
	{
	}

	public void OnBackwardChunkUnloaded()
	{
	}

	public void OnAirlockChunkUnloaded()
	{
	}

	private void OpenAirlockDoors()
	{
	}

	public void AirlockButton()
	{
	}

	private IEnumerator CoAirlock()
	{
		return null;
	}

	private IEnumerator CoOpenDoor(Transform transform)
	{
		return null;
	}

	private IEnumerator CoCloseDoor(Transform transform)
	{
		return null;
	}

	public ChunkTesting_Control()
		: base()
	{
	}
}
