using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace PuppetMasta
{
	public abstract class BehaviourBase : MonoBehaviour
	{
		public delegate void BehaviourDelegate();

		public delegate void HitDelegate(MuscleHit hit);

		public delegate void CollisionDelegate(MuscleCollision m);

		[Serializable]
		public struct PuppetEvent
		{
			[Tooltip("Another Puppet Behaviour to switch to on this event. This must be the exact Type of the the Behaviour, careful with spelling.")]
			public string switchToBehaviour;

			[Tooltip("Animations to cross-fade to on this event. This is separate from the UnityEvent below because UnityEvents can't handle calls with more than one parameter such as Animator.CrossFade.")]
			public AnimatorEvent[] animations;

			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			private const string empty = "";

			public bool switchBehaviour
			{
				get
				{
					return default(bool);
				}
			}

			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		public class AnimatorEvent
		{
			public string animationState;

			public float crossfadeTime;

			public int layer;

			public bool resetNormalizedTime;

			private bool _isInitialized;

			private int _hash;

			private const string empty = "";

			public void Initialize()
			{
			}

			public void Activate(Animator animator)
			{
			}

			public AnimatorEvent()
				: base()
			{
			}
		}

		[Serializable]
		public class TargetableAnimatorEvent
		{
			public enum TargetedLimb
			{
				LeftArm = 0,
				RightArm = 1,
				LeftLeg = 2,
				RightLeg = 3
			}

			public string animationState;

			public float crossfadeTime;

			public int layer;

			public float clipLength;

			public Vector3 localContactPoint;

			[Range(0f, 0.99f)]
			public float startIkNormalTime;

			[Range(0.01f, 0.99f)]
			public float contactPointNormalTime;

			public TargetedLimb targetedLimb;

			public float limbStrengthMultiplier;

			public float spineStrengthMultiplier;

			private bool _isInitialized;

			private int _hash;

			private float _timeStarted;

			private float _divByClipLength;

			private float _divByPreContact;

			private float _divByPostContact;

			private Vector3 _ikDelta;

			private const string empty = "";

			public void Initialize()
			{
			}

			public void Activate(Animator animator)
			{
			}

			public Vector3 ComputeTargetIkDelta(Vector3 targetLocal, Vector3 currentOffset, bool onFeet = true)
			{
				return default(Vector3);
			}

			public Vector3 ComputeCurrentIkDelta()
			{
				return default(Vector3);
			}

			public float GetNormalTime()
			{
				return default(float);
			}

			public TargetableAnimatorEvent()
				: base()
			{
			}
		}

		[HideInInspector]
		public PuppetMaster puppetMaster;

		public BehaviourDelegate OnPreActivate;

		public BehaviourDelegate OnPreInitiate;

		public BehaviourDelegate OnPreFixedUpdate;

		public BehaviourDelegate OnPreUpdate;

		public BehaviourDelegate OnPreLateUpdate;

		public BehaviourDelegate OnPreDeactivate;

		public BehaviourDelegate OnPreFixTransforms;

		public BehaviourDelegate OnPreRead;

		public BehaviourDelegate OnPreWrite;

		public HitDelegate OnPreMuscleHit;

		public CollisionDelegate OnPreMuscleCollision;

		public CollisionDelegate OnPreMuscleCollisionExit;

		public BehaviourDelegate OnHierarchyChanged;

		public BehaviourDelegate OnPostActivate;

		public BehaviourDelegate OnPostInitiate;

		public BehaviourDelegate OnPostFixedUpdate;

		public BehaviourDelegate OnPostUpdate;

		public BehaviourDelegate OnPostLateUpdate;

		public BehaviourDelegate OnPostDeactivate;

		public BehaviourDelegate OnPostDrawGizmos;

		public BehaviourDelegate OnPostFixTransforms;

		public BehaviourDelegate OnPostRead;

		public BehaviourDelegate OnPostWrite;

		public HitDelegate OnPostMuscleHit;

		public CollisionDelegate OnPostMuscleCollision;

		public CollisionDelegate OnPostMuscleCollisionExit;

		[HideInInspector]
		public bool deactivated;

		private bool initiated;

		public bool forceActive { get; protected set; }

		public virtual void OnReactivate(int phase = 0)
		{
		}

		public virtual void Resurrect()
		{
		}

		public virtual void Freeze()
		{
		}

		public virtual void Unfreeze()
		{
		}

		public virtual void KillStart()
		{
		}

		public virtual void KillEnd()
		{
		}

		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		protected virtual void OnActivate()
		{
		}

		protected virtual void OnDeactivate()
		{
		}

		protected virtual void OnInitiate()
		{
		}

		protected virtual void OnFixedUpdate()
		{
		}

		protected virtual void OnUpdate()
		{
		}

		protected virtual void OnLateUpdate()
		{
		}

		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		protected virtual void OnFixTransformsBehaviour()
		{
		}

		protected virtual void OnReadBehaviour()
		{
		}

		protected virtual void OnWriteBehaviour()
		{
		}

		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		public void Initiate()
		{
		}

		public void OnFixTransforms()
		{
		}

		public void OnRead()
		{
		}

		public void OnWrite()
		{
		}

		public void OnMuscleHit(MuscleHit hit)
		{
		}

		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		private void OnEnable()
		{
		}

		public void Activate()
		{
		}

		private void OnDisable()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		protected virtual void OnDrawGizmos()
		{
		}

		protected void RotateTargetToRootMuscle()
		{
		}

		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		protected void RemoveMusclesOfGroup(Muscle.Group group)
		{
		}

		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		protected bool MusclesContainsGroup(Muscle.Group group)
		{
			return default(bool);
		}

		public BehaviourBase()
			: base()
		{
		}
	}
}
