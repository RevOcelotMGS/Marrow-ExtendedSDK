using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

public class Control_GlobalTime : MonoBehaviour
{
	public delegate void SlowTime(float step);

	[Tooltip("Maximum time divisions. 8 for original, normally set by Control_Character")]
	[Header("SETTINGS")]
	public float max_intensity;

	private bool override_Keyboard;

	public float lrp_calc_t;

	[Range(0.01f, 10f)]
	public float lrp_time;

	private float def_lrp_time;

	private float _curTimeScale;

	private bool _isPaused;

	public AudioClip decelTime;

	public AudioClip accelTime;

	public AudioMixerGroup mixerGroup;

	private float lrp_count;

	[HideInInspector]
	public float cur_intensity;

	[HideInInspector]
	public float tar_intensity;

	[HideInInspector]
	public float tmp_intensity;

	[HideInInspector]
	public float def_intensity;

	[HideInInspector]
	public float tru_max_intensity;

	[HideInInspector]
	public int cur_timeScaleStep;

	[HideInInspector]
	public int max_timeScaleStep;

	[HideInInspector]
	public bool ControllingTime;

	[HideInInspector]
	public bool override_TimeControl;

	private float desyncThreashold;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TOGGLE_TIMESCALE()
	{
	}

	public void DECREASE_TIMESCALE()
	{
	}

	public void INCREASE_TIMESCALE()
	{
	}

	public void STEP_TIMESCALE(int step)
	{
	}

	public void RESET_TIMESCALE()
	{
	}

	public void RISE_TIMESCALE()
	{
	}

	public void DROP_TIMESCALE()
	{
	}

	public void UpdateTimescale(float desync = 0f)
	{
	}

	public void SET_TIMESCALE(float intensity)
	{
	}

	public void PAUSE()
	{
	}

	public void UNPAUSE()
	{
	}

	public Control_GlobalTime()
		: base()
	{
	}

	public static event SlowTime OnSlowTime;
}
