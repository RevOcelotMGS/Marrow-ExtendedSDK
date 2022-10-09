using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LevelObject : MonoBehaviour
{
	[Space(5f)]
	[Header("SETTINGS - REQUIRED")]
	public string string_LevelToload;

	public string string_LongName;

	public Transform hypercube;

	public Vector3 scl_hypercube_IN;

	public Vector3 scl_hypercube_OUT;

	private Vector3 scl_hypercube_CUR;

	private Vector3 scl_hypercube_TAR;

	private Vector3 defaultCubeScale;

	public float scl_length;

	public float scl_speed;

	public float scl_t;

	public ParticleSystem fx_particleHighlight;

	private float elapsedTime;

	public AudioSource src_Audio;

	public AudioClip clip_Select;

	public AudioClip clip_DeSelect;

	private Coroutine lerpHideCubeCoroutine;

	private Coroutine lerpHyperCubeCoroutine;

	public void Start()
	{
	}

	public void ExpandContract(bool expand = false)
	{
	}

	public void HideCube(bool hide = false, float duration = 1f)
	{
	}

	private IEnumerator LerpHideCube(bool hide = false, float duration = 1f)
	{
		return null;
	}

	private IEnumerator LerpHyperCube(bool expand = false)
	{
		return null;
	}

	public LevelObject()
		: base()
	{
	}
}
