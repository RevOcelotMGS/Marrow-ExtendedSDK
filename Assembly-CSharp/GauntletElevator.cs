using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Data.SaveData;
using SLZ.Marrow.VoidLogic;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class GauntletElevator : MonoBehaviour
{
	[Header("Elevator Floor Control Panel")]
	public TextMeshProUGUI cur_floorNumberDisplay;

	public TextMeshProUGUI cur_floorTitleDisplay;

	public TextMeshProUGUI[] floorNumberText;

	public Color color_normalFloor;

	public Color color_goToFloor;

	public string[] floorNumberString;

	public string[] floorNameString;

	private int currentFloor;

	private int desiredFloor;

	public AudioClip clip_positive;

	public AudioClip clip_negative;

	public AudioMixerGroup mixerGroup;

	public float timeToTravel;

	public bool openDoorsOnStart;

	public float opeenDoorsOnStartDelay;

	public bool isHubElevator;

	public bool bigAnomaly_A;

	public bool bigAnomaly_B;

	[Header("Level Crates for Floors")]
	public LevelCrateReference[] floorLevel;

	private LevelCrateReference _loadcrate;

	public LevelCrateReference loadScreenLevel;

	public bool[] canTravelToLevel;

	[Header("Door Control")]
	public SourceNode door_right;

	public SourceNode door_left;

	private IEnumerator doorDelayCoroutine;

	private static PlayerProgression Progression
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	public void UPDATEPANELDISPLAY()
	{
	}

	public void DesiredFloorCheck()
	{
	}

	public void CurrentFloorCheck()
	{
	}

	public void LOADTARGETLEVEL(int levelToLoad)
	{
	}

	private void DelayLevelLoad()
	{
	}

	public void SIMULATIONEXITBUTTON()
	{
	}

	public void OPENCLOSEDOORWITHDELAY(bool open, bool playDing, float delay = 0f)
	{
	}

	private IEnumerator DoorDelayCoroutine(bool open, bool playDing, float delay = 0f)
	{
		return null;
	}

	public void OPENCLOSEDOOR(bool open = true)
	{
	}

	public void PLAYDING(bool positive = true)
	{
	}

	private void AudioDing(AudioClip clipToPlay)
	{
	}

	private void ElevatorLevelSetup(int _currentLevel)
	{
	}

	public GauntletElevator()
		: base()
	{
	}
}
