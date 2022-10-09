using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class NarrativeState : MonoBehaviour
{
	public enum HoldState
	{
		INACTIVE = 0,
		INTRO = 1,
		HOLD = 2,
		PROMPT = 3,
		EXIT = 4,
		INTERRUPTED = 5
	}

	public HoldState currHoldState;

	public HoldState prevHoldState;

	[Space(10f)]
	public bool playIntroOnStart;

	public bool ExitAfterIntro;

	[HideInInspector]
	public int _stateIndex;

	public NarrativeState nextState;

	[SerializeField]
	private float initTimerValue;

	[SerializeField]
	private float timerValue;

	[SerializeField]
	private int currPrompt;

	private Coroutine holdRoutine;

	[SerializeField]
	private bool intertupedTimerRoutine;

	[SerializeField]
	[Header("Playable Directors")]
	private PlayableDirector introDirector;

	[SerializeField]
	private PlayableDirector holdDirector;

	[SerializeField]
	private PlayableDirector[] promptDirectors;

	private List<TrackData> promptDirectorDataList;

	[Header("Events")]
	[SerializeField]
	private UnityEvent OnIntro;

	[SerializeField]
	private UnityEvent OnEnterHold;

	[SerializeField]
	private UnityEvent OnTimeOut;

	[SerializeField]
	private UnityEvent OnExit;

	public static Action<NarrativeState, PlayableDirector> OnStateChange;

	[Header("Debug State Directors")]
	[SerializeField]
	private PlayableDirector activeDirector;

	[SerializeField]
	private PlayableDirector prevDirector;

	public void Start()
	{
	}

	[ContextMenu("PlayIntro")]
	public void PlayIntro()
	{
	}

	public void HoldForInput()
	{
	}

	public void HoldWithTimeoutPrompt(float time = -1f)
	{
	}

	private void TimeoutState()
	{
	}

	public void InteruptState()
	{
	}

	public void ResumeState()
	{
	}

	[ContextMenu("ExitState")]
	public void ExitState()
	{
	}

	private IEnumerator CoHold()
	{
		return null;
	}

	private void StopHoldRoutine()
	{
	}

	public void UpdateState(HoldState state, PlayableDirector director)
	{
	}

	public void SetCheckPoint()
	{
	}

	public void SwapDirectorPlayable(PlayableDirector director, PlayableAsset asset)
	{
	}

	public void GetBindings(PlayableDirector director)
	{
	}

	public void SetBindings(PlayableDirector director)
	{
	}

	public static void Bind(PlayableDirector director, string trackName, UnityEngine.Object sourceObj)
	{
	}

	public NarrativeState()
		: base()
	{
	}
}
