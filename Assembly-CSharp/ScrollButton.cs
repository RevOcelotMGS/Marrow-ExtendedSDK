using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ScrollButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	private enum ScrollButtonDirection
	{
		UP = 0,
		DOWN = 1
	}

	[SerializeField]
	private ScrollButtonDirection direction;

	[SerializeField]
	private bool incremental;

	[SerializeField]
	private float stepSize;

	[SerializeField]
	private float scrollFrequency;

	[SerializeField]
	private Scrollbar scrollbar;

	[SerializeField]
	private ScrollElementsContainer scrollElementsContainer;

	private float signedStepSize;

	private Button button;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void HandleScrollViewChanged()
	{
	}

	private void HandleScrollValueChanged(float value)
	{
	}

	private void SetButtonState(bool enabled)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void stopScrolls()
	{
	}

	private void IncrementalScrollContent()
	{
	}

	private void ScrollContent()
	{
	}

	private IEnumerator SmoothScrolling(float minValue, float maxValue, float totalTime)
	{
		return null;
	}

	private IEnumerator RefactoredSmoothScrolling(float CurValue, float TargetValue, float totalTime)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public ScrollButton()
		: base()
	{
	}
}
