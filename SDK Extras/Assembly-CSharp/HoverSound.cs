using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HoverSound : MonoBehaviour
{
	public AudioSource SoundSource;

	private HoverEngine[] m_Engines;

	private MovementEngine[] m_MoveEngines;

	public float MovementEngineWeight;

	public float MinVolume;

	public float MaxVolume;

	public float MinPitch;

	public float MaxPitch;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public HoverSound()
		: base()
	{
	}
}
