using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Input;
using SLZ.Rig;
using UnityEngine;

public class ControllerTutorialArt : MonoBehaviour
{
	public XRControllerType controllerType;

	public bool isRightHand;

	public Transform offset_text;

	[Header("CONTROLLER ART")]
	public GameObject controller;

	public Renderer joystick;

	public Renderer button_primary;

	public Renderer button_secondary;

	public Renderer trigger;

	public Renderer grip;

	public Renderer system;

	public Renderer outline;

	public float timeToHighlight;

	private float cur_TimeToHighlight;

	private bool _endOff;

	[ColorUsage(true, true)]
	public Color max_controller_color;

	[ColorUsage(true, true)]
	public Color min_controller_color;

	[ColorUsage(true, true)]
	private Color target_controller_color;

	[ColorUsage(true, true)]
	private Color cur_controller_color;

	public bool isHoldingObjectLeft;

	public bool isHoldingObjectRight;

	public Transform headPos;

	private bool _isRunning;

	private Coroutine blinkHighlightCoroutine;

	private void Start()
	{
	}

	public void HIGHLIGHTACTION(TutorialRig.InputHighlight highlightedAction, int flashRate = 1)
	{
	}

	public void AXISACTION()
	{
	}

	public void FADECONTROLLER(RigManager manager, bool turnOn = true)
	{
	}

	private IEnumerator CoBlinkHighlight(Renderer renderer, float cycles = 4f)
	{
		return null;
	}

	private IEnumerator FXChange()
	{
		return null;
	}

	private IEnumerator ControllerFollow(RigManager manager)
	{
		return null;
	}

	private void HighlightOff(Renderer renderer)
	{
	}

	public ControllerTutorialArt()
		: base()
	{
	}
}
