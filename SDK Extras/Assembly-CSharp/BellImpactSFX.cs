using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

public class BellImpactSFX : MonoBehaviour
{
	public UnityEvent onRingBell;

	public AudioClip bellImpactClip;

	public AudioMixerGroup audioGroup;

	private float _nextImpactTime;

	private float _mass;

	private float _minVelSquared;

	public float velocityClipSplit;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void TriggerSFX(Collision collision)
	{
	}

	public void OnAttackSFX()
	{
	}

	public BellImpactSFX()
		: base()
	{
	}
}
