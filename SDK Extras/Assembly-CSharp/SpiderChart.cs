using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Rig;
using SLZ.VRMK;
using TMPro;
using UnityEngine;

public class SpiderChart : MonoBehaviour
{
	public GameObject chart;

	public GameObject background;

	public TriggerLasers trigger;

	public float targetHeight;

	public float targetMass;

	public float targetAgility;

	public float targetSpeed;

	public float targetStrengthUpper;

	public float targetStrengthLower;

	public float targetVitality;

	public float targetIntelligence;

	public float agilityHighTune;

	public float speedHighTune;

	public float strengthUpperHighTune;

	public float strengthLowerHighTune;

	public float vitalityHighTune;

	public float intelligenceHighTune;

	private float height;

	private float mass;

	private float agility;

	private float speed;

	private float strengthUpper;

	private float strengthLower;

	private float vitality;

	private float intelligence;

	private float velHeight;

	private float velMass;

	private float velAgility;

	private float velSpeed;

	private float velStrengthUpper;

	private float velStrengthLower;

	private float velVitality;

	private float velIntelligence;

	public float smoothTime;

	public TextMeshProUGUI statText;

	public RigManager rm;

	public BodyVitals bv;

	private bool isInRange;

	private Material chartMat;

	private IEnumerator updateLoop;

	public SLZ.VRMK.Avatar previewAvatar;

	private void Start()
	{
	}

	public void STARTCHART()
	{
	}

	public void STOPCHART()
	{
	}

	private IEnumerator UpdateLoop()
	{
		return null;
	}

	public void UPDATESTATS(SLZ.VRMK.Avatar avatar, Transform previewTransform)
	{
	}

	public SpiderChart()
		: base()
	{
	}
}
