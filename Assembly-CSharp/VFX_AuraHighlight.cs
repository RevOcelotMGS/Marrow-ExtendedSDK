using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class VFX_AuraHighlight : MonoBehaviour
{
	[Header("CONTROL")]
	public bool playOnStart;

	public float timeToHighlight;

	private float cur_TimeToHighlight;

	public bool use_Particles;

	public bool use_Haze;

	public bool use_Flare;

	public bool highlightOnHover;

	public bool pingpong;

	private bool canHighlight;

	private int cur_status;

	private int tar_status;

	[Header("FLARE")]
	public AnimationCurve curve_flare;

	public GameObject fx_flare;

	public float flare_ScaleMult;

	private Vector3 start_flare_scale;

	private Vector3 target_flare_scale;

	private Vector3 cur_flare_scale;

	private Material flare_Material;

	[ColorUsage(true, true)]
	private Color start_flare_color;

	[ColorUsage(true, true)]
	private Color target_flare_color;

	[ColorUsage(true, true)]
	private Color cur_flare_color;

	[ColorUsage(true, true)]
	public Color flare_color;

	[Header("Haze")]
	public AnimationCurve curve_haze;

	public GameObject fx_haze;

	public float haze_ScaleMult;

	private Vector3 start_haze_scale;

	private Vector3 target_haze_scale;

	private Vector3 cur_haze_scale;

	private Material haze_Material;

	[ColorUsage(true, true)]
	private Color start_haze_color;

	[ColorUsage(true, true)]
	private Color target_haze_color;

	[ColorUsage(true, true)]
	private Color cur_haze_color;

	[ColorUsage(true, true)]
	public Color haze_color;

	[Header("PARTICLES")]
	public ParticleSystem fx_particles;

	public float max_particles;

	public float min_particles;

	private float cur_particles;

	private float target_particles;

	[Header("AUDIO")]
	public AudioSource src_Audio;

	public AudioClip clip_idle;

	public AudioClip clip_spawn;

	public AudioClip clip_break;

	private void Start()
	{
	}

	public void OnSpawn()
	{
	}

	public void HIGHLIGHT(int condition = 0)
	{
	}

	private IEnumerator FXChange()
	{
		return null;
	}

	public VFX_AuraHighlight()
		: base()
	{
	}
}
