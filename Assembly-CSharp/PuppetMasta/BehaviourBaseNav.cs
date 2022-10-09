using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ;
using SLZ.AI;
using SLZ.Combat;
using SLZ.Interaction;
using SLZ.MIA;
using SLZ.Marrow.Utilities;
using SLZ.Zones;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace PuppetMasta
{
	public abstract class BehaviourBaseNav : BehaviourBase
	{
		public enum MentalState
		{
			Rest = 0,
			Roam = 1,
			Investigate = 2,
			Agroed = 3,
			Engaged = 4,
			MindControlled = 5
		}

		public enum LocoState
		{
			Standing = 0,
			Walking = 1,
			Fallen = 2,
			GetUp = 3,
			Jumping = 4,
			InAir = 5,
			Grappling = 6
		}

		private static ComponentCache<BehaviourBaseNav> _cache;

		public BaseEnemyConfig baseConfig;

		[SerializeField]
		protected BaseEnemyConfig defaultConfig;

		[Header("Resting State")]
		[Range(0f, 16f)]
		public float restingRange;

		public bool freezeWhileResting;

		public bool homeIsPost;

		[Header("Roam State")]
		[Range(1f, 16f)]
		public float activeRange;

		public float roamSpeed;

		public Vector2 roamRange;

		public float roamAngSpeed;

		[Range(0f, 1f)]
		public float roamFrequency;

		public bool roamWanders;

		[Header("Investigate State")]
		[Range(4f, 16f)]
		public float investigateRange;

		[EnumFlags]
		[Header("Agro State General")]
		public TriggerRefProxy.NpcType agroOnNpcType;

		public float breakAgroTargetDistance;

		public float breakAgroHomeDistance;

		public float agroedSpeed;

		public float agroedAngSpeed;

		public LayerMask meleeAttackMask;

		public bool enableThrowAttack;

		public bool throwAttackUsesGravity;

		public bool forceAgentPath;

		public float fwdDotThresh;

		public float throwMaxRange;

		public float throwMinRange;

		public float throwCooldown;

		public float throwVelocity;

		public float gunRange;

		public float gunCooldown;

		[Range(0f, 10f)]
		public float accuracy;

		public float reloadTime;

		[Range(1f, 60f)]
		public int clipSize;

		[Range(1f, 20f)]
		public int burstSize;

		public float desiredGunDistance;

		[ColorUsage(true, true)]
		public Color baseColor;

		[ColorUsage(true, true)]
		public Color agroColor;

		public Renderer[] emissionRenderers;

		public bool isSoundAggroWhenInSecondaryZone;

		public MentalState mentalState;

		public LocoState locoState;

		public float aiTickFreq;

		[SerializeField]
		protected Transform eyeTran;

		public SubBehaviourSensors sensors;

		public SubBehaviourSfx sfx;

		public SubBehaviourHealth health;

		public ZoneTracker zoneTracker;

		protected NavMeshAgent _navAgent;

		private bool _homeBound;

		public Vector3 homePosition;

		public InteractableHostManager hostManager;

		protected MentalState _initialState;

		protected MentalState _preAggroState;

		protected bool investIsPosition;

		protected Vector3 _investigateTarget;

		protected Vector3 _targetDirWorld;

		protected Vector3 _targetDirNormalWorld;

		protected float _investigationCooldown;

		protected float _blockCollisionsUntil;

		protected float _lastAiTickTime;

		protected float _lastJumpTime;

		protected float _cooldownLocoSwitch;

		protected float _currentRotVel;

		protected float _currentRotDelta;

		protected float _animatedRotVel;

		protected Vector3 _animatedRoot;

		protected Quaternion _localAnimatedRoot;

		protected bool meleeAttackActive;

		protected bool _forceAiTick;

		protected int emissColor;

		protected int triggerCount;

		protected MaterialPropertyBlock materialPropertyBlock;

		protected VisualDamageController visualDamage;

		protected HashSet<Rigidbody> selfRbs;

		private Vector3 navTarget;

		private Vector3 flatNavTarget;

		public UnityEvent OnDeath;

		public UnityEvent OnDeathStart;

		private float _time;

		private float _fixedTime;

		private bool displayNavpath;

		private MIASimulationEventBroker _simulationEventBroker;

		public static ComponentCache<BehaviourBaseNav> Cache
		{
			get
			{
				return null;
			}
		}

		public float targetDistance { get; protected set; }

		protected MIASimulationEventBroker SimulationEventBroker
		{
			get
			{
				return null;
			}
		}

		public void BlockCollisions(float time)
		{
		}

		private void OnDestroy()
		{
		}

		public void ChangeEmissiveColor(Color color)
		{
		}

		public void SetRoam(Vector2 roamXz, float speed = 0.8f, bool wanders = false, float frequency = 0.2f)
		{
		}

		public void Investigate(Vector3 target, bool isPosition = false, float investForSeconds = 6f)
		{
		}

		public void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		public void SetTeam(int t)
		{
		}

		public void SetEngaged(TriggerRefProxy engagedTarget)
		{
		}

		public void AddThreat(TriggerRefProxy trp, float threat)
		{
		}

		public void SetPath(Vector3 target)
		{
		}

		protected void ProcessTargetRelativePathing(float idealDistance, float nearBuffer, float farBuffer, float orbitMeters = 0f)
		{
		}

		public void SetBaseConfig(BaseEnemyConfig baseEnemyConfig)
		{
		}

		public void SetHomePosition(Vector3 worldPosition, bool goToHome = true, bool homePost = false)
		{
		}

		public void SetHomeIsPost(bool isPost)
		{
		}

		public void ClearPath()
		{
		}

		protected void SetNavAgentToPhysics(float deltaTime = 0f)
		{
		}

		protected void SetNavAgent(float speed, float angSpeed, float accel = 2f, float stopDistance = 1f)
		{
		}

		private void OnTriggerEnter(Collider c)
		{
		}

		private void OnTriggerExit(Collider c)
		{
		}

		protected bool CheckTarget()
		{
			return default(bool);
		}

		public virtual void DealMeleeDamage(MuscleCollision m, float impulse)
		{
		}

		protected float ProcessImpulse(Collision c, Rigidbody thisRb)
		{
			return default(float);
		}

		private static float PredictiveAimWildGuessAtImpactTime()
		{
			return default(float);
		}

		public static bool PredictiveAim(Vector3 muzzlePosition, float projectileSpeed, Vector3 targetPosition, Vector3 targetVelocity, float gravity, [Out] Vector3 projectileVelocity)
		{
			return default(bool);
		}

		protected abstract void SwitchMentalState(MentalState mState);

		protected abstract void SwitchLocoState(LocoState lState, float coolDown = 0f, bool forceSwitch = false);

		protected virtual void AiUpdate()
		{
		}

		protected virtual void AiTick()
		{
		}

		protected virtual void ResetAnimator()
		{
		}

		protected virtual void ReturnToPreAgro()
		{
		}

		protected virtual void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		protected virtual void OnHandDetached(InteractableHost host, Hand hand)
		{
		}

		public new void OnDrawGizmos()
		{
		}

		public BehaviourBaseNav()
			: base()
		{
		}
	}
}
