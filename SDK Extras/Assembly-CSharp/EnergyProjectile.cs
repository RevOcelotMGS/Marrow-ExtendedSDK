using System.Runtime.CompilerServices;
using SLZ.Combat;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;

public class EnergyProjectile : MonoBehaviour, IAttackReceiver, IEventSystemHandler
{
	private static ComponentCache<EnergyProjectile> _cache;

	[SerializeField]
	private Rigidbody _rb;

	private float _initialTime;

	private Collider[] m_OverlappingColliders;

	public LayerMask attackLayerMask;

	public LayerMask blockLayerMask;

	public AttackType attackType;

	public AudioClip[] fireClips;

	public AudioClip[] hitClips;

	public AudioMixerGroup mixerGroup;

	[SerializeField]
	private Spawnable blastSpawnable;

	public float BlastRadius;

	public float BlastDamage;

	private Vector3 Vec3EffectScale;

	public Collider col;

	[HideInInspector]
	public Vector3 cashedVector;

	public static ComponentCache<EnergyProjectile> Cache
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

	private void LateUpdate()
	{
	}

	private void OnCollisionEnter(Collision c)
	{
	}

	public EnergyProjectile()
		: base()
	{
	}
}
