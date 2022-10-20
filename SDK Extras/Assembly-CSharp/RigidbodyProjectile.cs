using System;
using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Combat;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;

public class RigidbodyProjectile : MonoBehaviour, IAttackReceiver, IEventSystemHandler
{
	private static ComponentCache<RigidbodyProjectile> _cache;

	[SerializeField]
	private Rigidbody _rb;

	private float _initialTime;

	private Collider[] m_OverlappingColliders;

	public LayerMask attackLayerMask;

	public LayerMask blockLayerMask;

	public AttackType attackType;

	public AudioClip[] throwClips;

	public AudioClip[] hitClips;

	public AudioMixerGroup mixerGroup;

	public TriggerRefProxy throwerProxy;

	[SerializeField]
	private Spawnable blastSpawnable;

	public float BlastRadius;

	public float BlastDamage;

	private Vector3 Vec3EffectScale;

	public Collider col;

	public static Action OnProjectileShot;

	public static ComponentCache<RigidbodyProjectile> Cache
	{
		get
		{
			return null;
		}
	}

	public Rigidbody Rb
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	public void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void BlowUp(Attack attack)
	{
	}

	public void ReceiveAttack(Attack attack)
	{
	}

	private void OnCollisionEnter(Collision c)
	{
	}

	public RigidbodyProjectile()
		: base()
	{
	}
}
