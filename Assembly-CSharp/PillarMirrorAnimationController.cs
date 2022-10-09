using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Utilities;
using SLZ.Zones;
using UnityEngine;
using UnityEngine.Audio;

public class PillarMirrorAnimationController : MonoBehaviour
{
	public GameObject centerFragment;

	public GameObject mirrorColider;

	public List<GameObject> mirrorFragments;

	public GameObject audioSource;

	public float maxMirrorTicTime;

	public float randomRotationOffset;

	public Mirror mirror;

	public Spawnable avatarBlaster;

	public Spawnable hitBlaster;

	public ParticleSystemForceField forceField;

	public GameObject reflectionRoot;

	public AudioMixerGroup outputMixer;

	public AudioClip[] cryptidScream;

	public AudioClip[] mirrorBreak;

	private AudioPlayer ap;

	public BarracudaModelManagerMono bmm;

	public ZoneSpawner[] burstBoids;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[ContextMenu("MirrorBlip")]
	public void MirrorBlip()
	{
	}

	private IEnumerator TurnOffMirror()
	{
		return null;
	}

	private void PlayParticleSystem(SkinnedMeshRenderer meshRen, bool useForceField = true)
	{
	}

	[ContextMenu("Pulse100PrcOn")]
	public void Pulse100PrcOn()
	{
	}

	private float GetVolumeSurface(Vector3 size)
	{
		return default(float);
	}

	public IEnumerator MirroPulse(float percent, bool permanent = false)
	{
		return null;
	}

	public void PlayHitEffect()
	{
	}

	public void BurstBoids()
	{
	}

	private void PlaySFX(AudioClip[] audioClips, float volume, float minDistance, Vector3 position)
	{
	}

	public PillarMirrorAnimationController()
		: base()
	{
	}
}
