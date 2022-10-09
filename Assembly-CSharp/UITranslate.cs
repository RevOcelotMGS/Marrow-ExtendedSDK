using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UITranslate : MonoBehaviour
{
	public enum posBehavior
	{
		pingPong = 0,
		loop = 1,
		stop = 2
	}

	public AnimationCurve curve_translate;

	public Vector3 pos_start;

	public Vector3 pos_end;

	public bool playOnEnable;

	public bool endHere;

	public float timeToTranslate;

	public posBehavior m_behavior;

	private float cur_timeToTranslate;

	private Vector3 cur_position;

	private Vector3 tar_position;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void PLAYTRANSLATE()
	{
	}

	private IEnumerator TranslateTransform()
	{
		return null;
	}

	public UITranslate()
		: base()
	{
	}
}
