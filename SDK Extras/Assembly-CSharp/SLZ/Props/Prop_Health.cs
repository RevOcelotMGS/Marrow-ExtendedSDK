using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Combat;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Props
{
	public class Prop_Health : SpawnEvents
	{
		private static ComponentCache<Prop_Health> _cache;

		public bool RESETABLE;

		public bool Pooled;

		public Action onDestroyDelegate;

		[Tooltip("Can be damaged by physical impacts")]
		[Space(2f)]
		[Header("IMPACT")]
		public bool damageFromImpact;

		[Tooltip("Modifier multiplier to collision")]
		public float mod_Impact;

		[Tooltip("Threshold of impact magnitude required to damage")]
		public float thr_Impact;

		[Tooltip("Can this use a mask to ignore damage")]
		public bool useMask;

		[Tooltip("Layer to Minimal Hit")]
		public LayerMask msk_Impact;

		[Tooltip("Amount of Minimal Mod")]
		public float mod_Minimal;

		[Tooltip("Can be damaged by attacks")]
		[Space(10f)]
		[Header("ATTACKED")]
		public bool damageFromAttack;

		[Tooltip("Modifier multiplier to attack damage")]
		public float mod_Attack;

		[Tooltip("Can this use an attackType to adjust damage")]
		public bool useType;

		[Tooltip("Attack type high damage")]
		public AttackType mod_Type;

		[Tooltip("Modifier multiplier to attack type")]
		public float mod_TypeDamage;

		[Header("CRITICAL HIT")]
		[Space(10f)]
		[Tooltip("Colliders for critical hits")]
		public Collider[] col_crit;

		[Tooltip("Critical hit modifier percent")]
		public float mod_crit;

		[Tooltip("FX for crit hit")]
		public GameObject fx_crit;

		[Tooltip("Prop's maximum health")]
		[Header("HEALTH")]
		[Space(10f)]
		public float max_Health;

		[Tooltip("Prop's current health")]
		[SerializeField]
		private float cur_Health;

		[Tooltip("Required hits to break, 1 = default")]
		public int req_hit_count;

		[HideInInspector]
		public int hits;

		[HideInInspector]
		public bool bloodied;

		[Tooltip("0-1 as percent for when bloodied effects 0 = no effect")]
		[Range(0f, 1f)]
		public float per_Bloodied;

		[Tooltip("True = use materials instead of objects for damage look")]
		public bool useMaterialChange;

		[Header("HEALTH REGEN")]
		[Tooltip("Health to regen per frequency")]
		[Space(10f)]
		public float amt_Regen;

		[Tooltip("Time until regen starts after hit")]
		public float wait_Regen_t;

		[Tooltip("Frequency of regen in seconds")]
		public WaitForSeconds freq_Regen_t;

		[Tooltip("Currently regening")]
		public bool regenerating;

		[Tooltip("FX for regenerating")]
		public GameObject fx_regen;

		[Space(5f)]
		[Header("REACTION")]
		[Tooltip("Threshold of damage to cause a reaction")]
		public float thr_React;

		private bool reacting;

		[Tooltip("Maximum bits to spawn")]
		[Space(10f)]
		[Header("SUBSPAWN")]
		public int max_Bits;

		[Tooltip("Minimum bits to spawn")]
		public int min_Bits;

		[Tooltip("Spawn hero props?")]
		public bool spawnHeroProps;

		[Tooltip("0 = immediate, 0<t = seconds, 0>t = don't use time")]
		public float t_Despawn;

		[Tooltip("Occlusion time to despawn")]
		public float t_Occlusion;

		private float t_stored_Occlusion;

		[Tooltip("Can occlusion kill objects?")]
		public bool useOcclusion;

		private bool rebool;

		[Space(5f)]
		[Header("DEATH")]
		public bool use_Explosion;

		public bool drop_Bloodied;

		public float bloodied_t;

		public float force_Explosion;

		public float force_Rotation;

		public GameObject fx_Explosion;

		public GameObject fx_Bloodied;

		public GameObject fx_Death;

		[SerializeField]
		private float BreakEffectSize;

		[Space(5f)]
		[Header("REWARD")]
		public bool rnd_Item;

		public float rnd_Chance;

		public GameObject[] obj_Reward;

		public GameObject fx_Reward;

		[Header("REFERENCES")]
		[Space(10f)]
		[Tooltip("Default Prop 100% health")]
		public GameObject prop_Whole;

		[Tooltip("Primary Chunk Tracker")]
		public GameObject chunk_Tracker;

		[Tooltip("Damaged Prop art states")]
		public GameObject[] prop_Damaged;

		[Tooltip("Damaged Material states")]
		public Material[] mat_Damaged;

		[HideInInspector]
		private Material mat_Default;

		[Tooltip("Shattered prop bits")]
		public GameObject[] prop_Bits;

		[Tooltip("Spawnable hero props")]
		public GameObject[] prop_Hero;

		[Tooltip("Audioclips for bloodied hits")]
		public AudioClip[] clip_bloodied;

		private ImpactSFX impactSFX;

		private SimpleTimeDestroy impactSRC_Destroy;

		[SerializeField]
		private UnityEvent BreakEvent;

		[HideInInspector]
		private Vector3 vel;

		[HideInInspector]
		private Vector3 ang_vel;

		private bool _isDirty;

		private Vector3 CenterOffset;

		private Vector3 BoundScale;

		[Header("DEPENDENCIES")]
		[Space(10f)]
		public Spawnable blasterDustSpawnable;

		public Spawnable breakEffectSpawnable;

		public static ComponentCache<Prop_Health> Cache
		{
			get
			{
				return null;
			}
		}

		protected void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnSpawn(GameObject go)
		{
		}

		private void GetMaxBounds()
		{
		}

		private void STORESTART()
		{
		}

		private void SAFETYSTART()
		{
		}

		public void OnReceivedCollision(Collision impact, float relVelocitySqr, bool isStay = false)
		{
		}

		public void OnReceivedAttack(Attack attack)
		{
		}

		public void ReceiveHeal(float health)
		{
		}

		public void TAKEDAMAGE(float damage, bool crit = false, AttackType attackType = AttackType.None)
		{
		}

		public void TIMEDKILL()
		{
		}

		public void SETPROP()
		{
		}

		public void DESTROYED()
		{
		}

		public void StartRegen()
		{
		}

		private IEnumerator Regenerate()
		{
			return null;
		}

		private void EffectsCritHit()
		{
		}

		private void EffectsRegen(bool regeneration = true)
		{
		}

		private void EffectsBloodied()
		{
		}

		public void EffectsDeath()
		{
		}

		public void Reaction(float damage)
		{
		}

		public void SPAWNBITS()
		{
		}

		public void ResetPropBits(Transform[] bitRefs)
		{
		}

		public void ResetPropHero(Transform[] heroRefs)
		{
		}

		public void OnBecameInvisible()
		{
		}

		public void OnBecameVisible()
		{
		}

		public IEnumerator COUNTOCC()
		{
			return null;
		}

		public Prop_Health()
			: base()
		{
		}
	}
}
