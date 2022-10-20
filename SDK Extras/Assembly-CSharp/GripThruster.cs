using System.Collections.Generic;
using SLZ.AI;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;

public class GripThruster : MonoBehaviour
{
	private static ComponentCache<GripThruster> _cache;

	public GravGunSFX sfx;

	public Grip triggerGrip;

	public Vector3 forward;

	private float _triggerStartTime;

	private float _cooldownStartTime;

	public float launchForce;

	public Rigidbody rb;

	public float cooldownTime;

	public AudioClip noCoolClip;

	public Color _color;

	public LayerMask enemyLayermask;

	public float explosionRadius;

	public float minExplosionForce;

	public float maxExplosionForce;

	public HashSet<AIBrain> brainHash;

	private bool isExploding;

	public static ComponentCache<GripThruster> Cache
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnAttachedUpdate(Hand hand)
	{
	}

	public void ApplyThrust()
	{
	}

	[ContextMenu("GetNearbyEnemies")]
	public void GetNearbyEnemies()
	{
	}

	[ContextMenu("Explode")]
	public void ExplodeFromHere()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public GripThruster()
		: base()
	{
	}
}
