using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class AmmoDispenser : MonoBehaviour
{
	public TextMeshPro[] txt_ammoDisplay;

	public bool[] count_infinite;

	public int[] count_ammo;

	public PrefabSpawner[] spawn_ammo;

	public PrefabSpawner[] spawn_fx;

	public bool makeItRain;

	public TextMeshPro txt_makeItRain;

	public AudioClip[] clip_spawn;

	public AudioClip[] clip_deny;

	public AudioMixerGroup mixerGroup;

	public void Start()
	{
	}

	public void SPAWN_AMMO(int type)
	{
	}

	public IEnumerator RAINAMMO(int type)
	{
		return null;
	}

	public void TOGGLERAIN()
	{
	}

	public void TEXTDISPLAY()
	{
	}

	public void AUDIOALERT(bool positive = false, int type = 0)
	{
	}

	public AmmoDispenser()
		: base()
	{
	}
}
