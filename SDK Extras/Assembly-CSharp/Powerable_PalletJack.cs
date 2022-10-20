using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

public class Powerable_PalletJack : Powerable
{
	[SerializeField]
	private ConfigurableJoint _pivotjnt;

	[SerializeField]
	private ConfigurableJoint[] _wheelJnts;

	[SerializeField]
	private Grip _handleGrip;

	private float _jackHeight;

	private float _lastLever;

	[SerializeField]
	private AudioClip _soundUp;

	[SerializeField]
	private AudioClip _soundDown;

	[SerializeField]
	private AudioMixerGroup _mixerGroup;

	private AudioPlayer _playerUp;

	private AudioPlayer _playerDown;

	private void Awake()
	{
	}

	public void PumpJack(bool up)
	{
	}

	public void ButtonUp(bool down)
	{
	}

	public void ButtonDown(bool down)
	{
	}

	public Powerable_PalletJack()
		: base()
	{
	}
}
