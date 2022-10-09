using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class UI_Rhythm : MonoBehaviour
{
	public bool runUI;

	public ClockBPM masterClock;

	public TextMeshPro txt_BPM;

	public TextMeshPro txt_timeSignature;

	public TextMeshPro txt_totSteps;

	public TextMeshPro txt_2step;

	public TextMeshPro txt_4step;

	public TextMeshPro txt_8step;

	public TextMeshPro txt_scoreMult;

	public TextMeshPro txt_transitionState;

	public SpriteRenderer img_downBeat;

	public SpriteRenderer img_step;

	public void Update()
	{
	}

	public void DISPLAY_UI()
	{
	}

	public void STEP()
	{
	}

	public void DOWNBEAT()
	{
	}

	private IEnumerator FLASH_DOWNBEAT()
	{
		return null;
	}

	private IEnumerator FLASH_STEP()
	{
		return null;
	}

	public UI_Rhythm()
		: base()
	{
	}
}
