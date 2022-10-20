using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OutroNarrativeController : MonoBehaviour
{
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private AnimData[] pushData;

	[SerializeField]
	private int currPushVoice;

	[SerializeField]
	private float pushPromptDelay;

	[SerializeField]
	private AudioClip getInClip;

	[SerializeField]
	private AudioClip[] seatedClips;

	[SerializeField]
	private int currSeatedClip;

	[SerializeField]
	private float responseDelay;

	[SerializeField]
	private AudioClip[] driveClips;

	[SerializeField]
	private int currDriveClip;

	[SerializeField]
	private AudioClip[] completeClips;

	[SerializeField]
	private int currCompleteClip;

	private Coroutine pushVoiceRoutine;

	private Coroutine waitRoutine;

	[ContextMenu("StartTest")]
	public void StartPushLoop()
	{
	}

	private IEnumerator CoVoiceTest(AnimData data)
	{
		return null;
	}

	private void CompletePushLine()
	{
	}

	private IEnumerator CoWaitForLine()
	{
		return null;
	}

	[ContextMenu("OnEngineStart")]
	public void OnEngineStart()
	{
	}

	[ContextMenu("OnPlayerSeated")]
	public void OnPlayerSeated()
	{
	}

	private IEnumerator CoSeated(float clipLength)
	{
		return null;
	}

	[ContextMenu("OnBlankResponse")]
	public void OnBlankResponse()
	{
	}

	private IEnumerator CoDrive()
	{
		return null;
	}

	[ContextMenu("OnDriveComplete")]
	public void OnDriveComplete()
	{
	}

	private IEnumerator CoComplete()
	{
		return null;
	}

	public OutroNarrativeController()
		: base()
	{
	}
}
