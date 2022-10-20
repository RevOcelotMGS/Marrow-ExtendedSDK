using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Combat;
using SLZ.Props;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.EventSystems;

public class Balloon : MonoBehaviour, IAttackReceiver, IEventSystemHandler
{
	public enum BalloonColor
	{
		Red = 0,
		OrangeRed = 1,
		Orange = 2,
		YellowOrange = 3,
		Yellow = 4,
		GreenYellow = 5,
		Green = 6,
		BlueGreen = 7,
		Blue = 8,
		VioletBlue = 9,
		Violet = 10,
		RedViolet = 11,
		LightGray = 12,
		DarkGray = 13,
		Random = 14
	}

	public SLZ.Props.Balloon.BalloonColor startColor;

	public GameObject popPrefab;

	public float maxVelocity;

	public float lifetime;

	public bool burstOnLifetimeEnd;

	public GameObject lifetimeEndParticlePrefab;

	public SoundPlayOneshot lifetimeEndSound;

	private float destructTime;

	private float releaseTime;

	public SoundPlayOneshot collisionSound;

	private float lastSoundTime;

	private float soundDelay;

	[SerializeField]
	private Rigidbody balloonRigidbody;

	private bool bParticlesSpawned;

	private static float s_flLastDeathSound;

	private bool isWarmup;

	private IEnumerator Start()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private IEnumerator CoRandomPop()
	{
		return null;
	}

	private void Update()
	{
	}

	private void SpawnParticles(GameObject particlePrefab, SoundPlayOneshot sound)
	{
	}

	private void ApplyDamage()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public void SetColor(SLZ.Props.Balloon.BalloonColor color)
	{
	}

	public static BalloonColor GetRandomColor()
	{
		return default(BalloonColor);
	}

	public static Color BalloonColorToRGB(SLZ.Props.Balloon.BalloonColor balloonColorVar)
	{
		return default(Color);
	}

	public void ReceiveAttack(Attack attack)
	{
	}

	public Balloon()
		: base()
	{
	}
}
