using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Rig;
using UnityEngine;

public class Haptor : MonoBehaviour
{
	private enum HapStack
	{
		hap_Add = 0,
		hap_Override = 1,
		hap_Ignore = 2,
		hap_Duck = 3
	}

	[Header("Required")]
	public bool hapticsAllowed;

	public BaseController device_Controller;

	public Haptor otherHaptor;

	private bool usingRumbleHap;

	[HideInInspector]
	public float mod_globalPer;

	private float mod_viveWand;

	[Header("Defaults")]
	[Range(1f, 200f)]
	public float low_thr_freq;

	[Range(0.03f, 3f)]
	public float hap_duration;

	[Range(0f, 1000f)]
	public float hap_frequency;

	[Range(0f, 1f)]
	public float hap_amplitude;

	private float hap_delay;

	[Range(0.03f, 0.5f)]
	public float hap_calc_t;

	[Space(10f)]
	[Header("Subtle")]
	private float hap_subtle_t;

	private float hap_subtle_frequency;

	private float hap_subtle_amplitude;

	[Header("Click")]
	public float hap_click_down_t;

	public float hap_click_down_frequency;

	public float hap_click_down_amplitude;

	public float hap_click_up_t;

	public float hap_click_up_frequency;

	public float hap_click_up_amplitude;

	[Range(0f, 0.1f)]
	[Header("Tap")]
	public float hap_tap_duration;

	[Range(20f, 300f)]
	public float hap_tap_frequency;

	[Range(0f, 1f)]
	public float hap_tap_amplitude;

	[Header("Knock")]
	[Range(0f, 1f)]
	public float hap_knock_duration;

	[Range(0f, 200f)]
	public float hap_knock_frequency;

	[Range(0f, 1f)]
	public float hap_knock_amplitude;

	[Range(0.1f, 1f)]
	[Header("Hit")]
	public float hap_hit_mod;

	[Range(0f, 320f)]
	public float hap_hit_frequency;

	[Header("Sine")]
	[Header("Slide Friction")]
	[Space(10f)]
	[Header("Slide")]
	public int sin_gateCount;

	private int cur_sin_gateCount;

	private float cur_sin_length;

	private float cur_sin_amp;

	[Range(0f, 10f)]
	[Header("Soft Sine")]
	public float hap_softSin_length;

	[Range(120f, 1000f)]
	public float hap_softSin_freq;

	[Range(0f, 1f)]
	public float hap_max_softSin_amp;

	[Range(0f, 1f)]
	public float hap_min_softSin_amp;

	[Range(0f, 10f)]
	[Header("Hard Sine")]
	public float hap_hardSin_length;

	[Range(100f, 400f)]
	public float hap_hardSin_freq;

	[Range(0f, 1f)]
	public float hap_max_hardSin_amp;

	[Range(0f, 1f)]
	public float hap_min_hardSin_amp;

	private bool hapticking;

	private bool noDoubleHaptic;

	private void Start()
	{
	}

	public void DELAYEDCHECK()
	{
	}

	public void Haptic_Subtle()
	{
	}

	public void Haptic_Click(bool down = true)
	{
	}

	public void Haptic_Tap()
	{
	}

	public void Haptic_Knock()
	{
	}

	public void Haptic_Hit(float amp)
	{
	}

	public void Haptic_Tutorial(bool down = true)
	{
	}

	public void Haptic_Sliding()
	{
	}

	public void Haptic_SlideFriction()
	{
	}

	public void Haptic_SoftSin(int gateCount = 0, float length = 0f)
	{
	}

	public void Haptic_HardSin(int gateCount = 0, float length = 0f)
	{
	}

	public void Haptic_WepClang()
	{
	}

	public void Haptic_WepMagInsert()
	{
	}

	public void Haptic_WepChargeHandle()
	{
	}

	public void Haptic_WepFire(float kickForce)
	{
	}

	private IEnumerator co_HapHit(float amp = 0f)
	{
		return null;
	}

	private IEnumerator co_HapticSine(int gate = 0, float length = 0f, float frequency = 0f, float max_amplitude = 0f, float min_amplitude = 0f)
	{
		return null;
	}

	public void SENDHAPTIC(float delay, float duration, float frequency, float amplitude)
	{
	}

	private void VIVEBANDAID()
	{
	}

	public Haptor()
		: base()
	{
	}
}
