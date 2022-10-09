using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.Audio;

public class Arena_Launcher : MonoBehaviour
{
	public Spawnable hoiPoiSpawnable;

	public Spawnable rigidbodyProjectileSpawnable;

	public Spawnable confettiSpawnable;

	[SerializeField]
	private Transform parentRotater;

	[SerializeField]
	private float fireForce;

	[SerializeField]
	private AudioMixerGroup audioGroup;

	[SerializeField]
	private AudioClip launchClip;

	[SerializeField]
	private Transform confettiTarg;

	[SerializeField]
	private Arena_GameController gameController;

	[SerializeField]
	private GameObject turretObj;

	[SerializeField]
	private GameObject turrTarg;

	[SerializeField]
	private float projectileForce;

	private void Awake()
	{
	}

	[ContextMenu("LaunchConfetti")]
	public void LaunchConfetti()
	{
	}

	private IEnumerator CoLaunchConfetti()
	{
		return null;
	}

	public void LaunchCapsuleEnemy(Arena_GameController arenaGameController, EnemyProfile profile)
	{
	}

	[ContextMenu("ShootThatBitch")]
	public void ShootItUp()
	{
	}

	public void FixedUpdate()
	{
	}

	public void LaunchProjectile(Vector3 playerPos)
	{
	}

	public void ShootThePlayer(Vector3 playerPos)
	{
	}

	public Arena_Launcher()
		: base()
	{
	}
}
