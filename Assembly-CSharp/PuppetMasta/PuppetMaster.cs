using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using RootMotion;
using UnityEngine;

namespace PuppetMasta
{
	[HelpURL("https://www.youtube.com/watch?v=LYusqeqHAUc")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Puppet Master")]
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		public enum Mode
		{
			Active = 0,
			Kinematic = 1,
			Disabled = 2
		}

		public delegate void UpdateDelegate();

		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		public enum State
		{
			Alive = 0,
			Dead = 1,
			Frozen = 2
		}

		[Serializable]
		public struct StateSettings
		{
			[Tooltip("How much does it take to weigh out muscle weight to deadMuscleWeight?")]
			public float killDuration;

			[Tooltip("The muscle weight mlp while the puppet is Dead.")]
			public float deadMuscleWeight;

			[Tooltip("The muscle damper add while the puppet is Dead.")]
			public float deadMuscleDamper;

			[Tooltip("The max square velocity of the ragdoll bones for freezing the puppet.")]
			public float maxFreezeSqrVelocity;

			[Tooltip("If true, will enable angular limits when killing the puppet.")]
			public bool enableAngularLimitsOnKill;

			[Tooltip("If true, will enable internal collisions when killing the puppet.")]
			public bool enableInternalCollisionsOnKill;

			public static StateSettings Default
			{
				get
				{
					return default(StateSettings);
				}
			}

			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
				this.enableInternalCollisionsOnKill = default(bool);
				this.enableAngularLimitsOnKill = default(bool);
				this.maxFreezeSqrVelocity = default(float);
				this.deadMuscleDamper = default(float);
				this.deadMuscleWeight = default(float);
				this.killDuration = default(float);
			}
		}

		[Tooltip("Humanoid Config allows you to easily share PuppetMaster properties, including individual muscle props between Humanoid puppets.")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		public Transform targetRoot;

		[Tooltip("Sets/sets the state of the puppet (Alive, Dead or Frozen). Frozen means the ragdoll will be deactivated once it comes to stop in dead state.")]
		[LargeHeader("Simulation")]
		public State state;

		[ContextMenuItem("Reset To Default", "ResetStateSettings")]
		[Tooltip("Settings for killing and freezing the puppet.")]
		public StateSettings stateSettings;

		[Tooltip("Active mode means all muscles are active and the character is physically simulated. Kinematic mode sets rigidbody.isKinematic to true for all the muscles and simply updates their position/rotation to match the target's. Disabled mode disables the ragdoll. Switching modes is done by simply changing this value, blending in/out will be handled automatically by the PuppetMaster.")]
		public Mode mode;

		[Tooltip("The time of blending when switching from Active to Kinematic/Disabled or from Kinematic/Disabled to Active. Switching from Kinematic to Disabled or vice versa will be done instantly.")]
		public float blendTime;

		[Tooltip("If true, will fix the target character's Transforms to their default local positions and rotations in each update cycle to avoid drifting from additive reading-writing. Use this only if the target contains unanimated bones.")]
		public bool fixTargetTransforms;

		[Tooltip("Rigidbody.solverIterationCount for the muscles of this Puppet.")]
		public int solverIterationCount;

		[Tooltip("If true, will draw the target's pose as green lines in the Scene view. This runs in the Editor only. If you wish to profile PuppetMaster, switch this off.")]
		public bool visualizeTargetAnimation;

		[Tooltip("If true, will draw the target's pose as green lines in the Scene view. This runs in the Editor only. If you wish to profile PuppetMaster, switch this off.")]
		public bool visualizeTargetPose;

		[Tooltip("The weight of mapping the animated character to the ragdoll pose.")]
		[LargeHeader("Master Weights")]
		[Range(0f, 1f)]
		public float mappingWeight;

		[Range(0f, 1f)]
		[Tooltip("The normalized strength of the muscles.")]
		public float muscleWeight;

		[Tooltip("The positionSpring of the ConfigurableJoints' Slerp Drive.")]
		[LargeHeader("Joint and Muscle Settings")]
		public float muscleSpring;

		[Tooltip("The positionDamper of the ConfigurableJoints' Slerp Drive.")]
		public float muscleDamper;

		[Tooltip("When the target has animated bones between the muscle bones, the joint anchors need to be updated in every update cycle because the muscles' targets move relative to each other in position space. This gives much more accurate results, but is computationally expensive so consider leaving it off.")]
		public bool updateJointAnchors;

		[Tooltip("Should the joints use angular limits? If the PuppetMaster fails to match the target's pose, it might be because the joint limits are too stiff and do not allow for such motion. Uncheck this to see if the limits are clamping the range of your puppet's animation. Since the joints are actuated, most PuppetMaster simulations will not actually require using joint limits at all.")]
		public bool angularLimits;

		[Tooltip("Should the muscles collide with each other? Consider leaving this off while the puppet is pinned for performance and better accuracy.  Since the joints are actuated, most PuppetMaster simulations will not actually require internal collisions at all.")]
		public bool internalCollisions;

		[LargeHeader("Individual Muscle Settings")]
		[Tooltip("The Muscles managed by this PuppetMaster.")]
		public Muscle[] muscles;

		public UpdateDelegate OnPostInitiate;

		public UpdateDelegate OnRead;

		public UpdateDelegate OnWrite;

		public UpdateDelegate OnPostLateUpdate;

		public UpdateDelegate OnFixTransforms;

		public UpdateDelegate OnHierarchyChanged;

		public MuscleDelegate OnMuscleRemoved;

		private Animator _targetAnimator;

		[HideInInspector]
		public List<SolverManager> solvers;

		private bool internalCollisionsEnabled;

		private bool angularLimitsEnabled;

		private bool _awakeFailed;

		private bool interpolated;

		private bool freezeFlag;

		private bool hasBeenDisabled;

		private bool hierarchyIsFlat;

		private bool _teleport;

		private float _freezeFlagTime;

		private Vector3 teleportPosition;

		private Quaternion teleportRotation;

		private bool teleportMoveToTarget;

		private bool rebuildFlag;

		private bool onPostRebuildFlag;

		private Muscle[] defaultMuscles;

		private Vector3 rebuildPelvisPos;

		private Quaternion rebuildPelvisRot;

		private float _time;

		private float _deltaTime;

		private Mode activeMode;

		private Mode lastMode;

		private float mappingBlend;

		public UpdateDelegate OnFreeze;

		public UpdateDelegate OnUnfreeze;

		public UpdateDelegate OnDeath;

		public UpdateDelegate OnResurrection;

		private State activeState;

		private State lastState;

		private bool angularLimitsEnabledOnKill;

		private bool internalCollisionsEnabledOnKill;

		private bool animationDisabledbyStates;

		private Transform[] targetChildren;

		private Vector3[] targetStoredPositions;

		private Quaternion[] targetStoredRotations;

		private Vector3[] targetSampledPositions;

		private Quaternion[] targetSampledRotations;

		private Quaternion[] _sampledRotations;

		private bool sampleTargetMappedState;

		private bool hasProp;

		public Animator targetAnimator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BehaviourBase[] behaviours { get; private set; }

		public bool isActive
		{
			get
			{
				return default(bool);
			}
		}

		public bool initiated { get; private set; }

		public bool isBlending
		{
			get
			{
				return default(bool);
			}
		}

		public bool isSwitchingMode { get; private set; }

		public bool isSwitchingState
		{
			get
			{
				return default(bool);
			}
		}

		public bool isKilling { get; private set; }

		public bool isAlive
		{
			get
			{
				return default(bool);
			}
		}

		public bool isFrozen
		{
			get
			{
				return default(bool);
			}
		}

		public bool isDead
		{
			get
			{
				return default(bool);
			}
		}

		private void ResetStateSettings()
		{
		}

		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		private void Initiate()
		{
		}

		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		private void OnDestroy()
		{
		}

		private bool IsInterpolated()
		{
			return default(bool);
		}

		private void OnRebuild()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void OnLateUpdate()
		{
		}

		public void MoveToTarget()
		{
		}

		private void Read()
		{
		}

		private void FixTargetTransforms()
		{
		}

		private void VisualizeTargetPose(Color color)
		{
		}

		public void VisualizeHierarchy(Transform t, Color color)
		{
		}

		public void VisualizeHierarchy(Transform t, Color color, float duration)
		{
		}

		private void SetInternalCollisions(bool collide)
		{
		}

		private void SetAngularLimits(bool limited)
		{
		}

		private void ProcessTeleport()
		{
		}

		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, Muscle.Props muscleProps = default(Muscle.Props), bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		public void Rebuild()
		{
		}

		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[ContextMenu("Flatten Muscle Hierarchy")]
		public void FlattenHierarchy()
		{
		}

		[ContextMenu("Tree Muscle Hierarchy")]
		public void TreeHierarchy()
		{
		}

		[ContextMenu("Fix Muscle Positions")]
		public void FixMusclePositions()
		{
		}

		private void AddIndexesRecursive(int index, int[] indexes)
		{
		}

		private bool HierarchyIsFlat()
		{
			return default(bool);
		}

		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		private void KillJoint(ConfigurableJoint joint)
		{
		}

		public void DisableImmediately()
		{
		}

		protected virtual void SwitchModes()
		{
		}

		private void DisabledToKinematic()
		{
		}

		private IEnumerator DisabledToActive()
		{
			return null;
		}

		private void KinematicToDisabled()
		{
		}

		private IEnumerator KinematicToActive()
		{
			return null;
		}

		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		private void UpdateInternalCollisions()
		{
		}

		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return default(bool);
		}

		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return default(int);
		}

		public int GetMuscleIndex(Transform target)
		{
			return default(int);
		}

		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return default(int);
		}

		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return default(int);
		}

		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		private void SetUpMuscles(Transform setUpTo)
		{
		}

		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		private void RemoveUnnecessaryBones()
		{
		}

		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return default(bool);
		}

		public void Kill()
		{
		}

		public void Kill(StateSettings stateSettings)
		{
		}

		public void Freeze()
		{
		}

		public void Freeze(StateSettings stateSettings)
		{
		}

		public void Resurrect()
		{
		}

		protected virtual void SwitchStates()
		{
		}

		private IEnumerator AliveToDead()
		{
			return null;
		}

		private void AliveToFrozen()
		{
		}

		private void OnFreezeFlag()
		{
		}

		private void DeadToAlive()
		{
		}

		private void SetAnimationEnabled(bool to)
		{
		}

		private void DeadToFrozen()
		{
		}

		private void FrozenToAlive()
		{
		}

		private void FrozenToDead()
		{
		}

		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		private bool CanFreeze()
		{
			return default(bool);
		}

		public Quaternion[] StoreTargetState([Out] Vector3[] positions)
		{
			return null;
		}

		public void SetTargetState(Vector3[] positions, Quaternion[] rotations)
		{
		}

		public void SampleTargetState()
		{
		}

		public void BlendToSampledState(float weight)
		{
		}

		public void SampleTargetRotations(bool sampleMuscles = false)
		{
		}

		public void BlendToSampledRotations(float weight, int muscleCount = -1)
		{
		}

		private void UpdateHierarchies()
		{
		}

		private bool HasProp()
		{
			return default(bool);
		}

		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		private void AssignParentAndChildIndexes()
		{
		}

		private void AddToParentsRecursive(ConfigurableJoint joint, int[] indexes)
		{
		}

		private void AddToChildrenRecursive(ConfigurableJoint joint, int[] indexes, bool[] childFlags)
		{
		}

		private void AssignKinshipDegrees()
		{
		}

		private void AssignKinshipsDownRecursive(int[] kinshipDegrees, int degree, int index)
		{
		}

		private void AssignKinshipsUpRecursive(int[] kinshipDegrees, int degree, int index)
		{
		}

		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return default(int);
		}

		public bool IsValid(bool log)
		{
			return default(bool);
		}

		private bool CheckMassVariation(float threshold, bool log)
		{
			return default(bool);
		}

		private bool CheckIfInitiated()
		{
			return default(bool);
		}

		public PuppetMaster()
			: base()
		{
		}

		public static event Action<PuppetMaster> OnDeathStatsEvent;
	}
}
