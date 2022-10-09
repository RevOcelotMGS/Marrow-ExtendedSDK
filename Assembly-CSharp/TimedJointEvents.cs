using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class TimedJointEvents : MonoBehaviour
{
	public ConfigurableJoint joint;

	public ConfigurableJoint secJoint;

	[SerializeField]
	private AudioClip[] initClips;

	[SerializeField]
	private float audioDelay;

	[SerializeField]
	private bool initialIsTriggered;

	[SerializeField]
	private float initThreshold;

	public UnityEvent initEvent;

	[SerializeField]
	private AudioClip[] secondaryClips;

	[SerializeField]
	private bool secondaryIsTriggered;

	[SerializeField]
	private float secondaryThreshold;

	public UnityEvent secondaryEvent;

	[SerializeField]
	private AudioClip[] finalClips;

	[SerializeField]
	private bool finalIsTriggered;

	[SerializeField]
	private float finalThreshold;

	public UnityEvent finalEvent;

	[SerializeField]
	private float elapsedTime;

	private Coroutine timerRoutine;

	public void StartTimer()
	{
	}

	public void ResetStates()
	{
	}

	public void StopTimer()
	{
	}

	private IEnumerator CoTimerRoutine()
	{
		return null;
	}

	public void TriggerInitialEvent()
	{
	}

	public void TriggerSecondaryEvent()
	{
	}

	public void TriggerFinalEvent()
	{
	}

	public void LimitJoint()
	{
	}

	[ContextMenu("TestLimitUpdate")]
	public void TestLimitUpdate()
	{
	}

	public void UpdateLimits(float limitVal)
	{
	}

	public void UnlockJoint()
	{
	}

	public void DestroyJoint()
	{
	}

	public void FireOffAudio(AudioClip[] clips)
	{
	}

	private IEnumerator CoSecondaryAudio(AudioClip[] clips, float delay)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public TimedJointEvents()
		: base()
	{
	}
}
