using System;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

namespace PuppetMasta
{
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page10.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourPuppet")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		public enum State
		{
			Puppet = 0,
			Unpinned = 1,
			GetUp = 2
		}

		[Serializable]
		public enum NormalMode
		{
			Active = 0,
			Unmapped = 1,
			Kinematic = 2
		}

		[Serializable]
		public class MasterProps
		{
			public NormalMode normalMode;

			public float mappingBlendSpeed;

			public bool activateOnStaticCollisions;

			public float activateOnImpulse;

			public MasterProps()
				: base()
			{
			}
		}

		[Serializable]
		public struct MuscleProps
		{
			[Tooltip("How much will collisions with muscles of this group unpin parent muscles?")]
			[Range(0f, 1f)]
			public float unpinParents;

			[Tooltip("How much will collisions with muscles of this group unpin child muscles?")]
			[Range(0f, 1f)]
			public float unpinChildren;

			[Tooltip("How much will collisions with muscles of this group unpin muscles of the same group?")]
			[Range(0f, 1f)]
			public float unpinGroup;

			[Range(0f, 1f)]
			[Tooltip("If 1, muscles of this group will always be mapped to the ragdoll.")]
			public float minMappingWeight;

			[Tooltip("If 0, muscles of this group will not be mapped to the ragdoll pose even if they are unpinned.")]
			[Range(0f, 1f)]
			public float maxMappingWeight;

			[Tooltip("If true, muscles of this group will have their colliders disabled while in puppet state (not unbalanced nor getting up).")]
			public bool disableColliders;

			[Tooltip("How fast will muscles of this group regain their pin weight (multiplier)?")]
			public float regainPinSpeed;

			[Tooltip("Smaller value means more unpinning from collisions (multiplier).")]
			public float collisionResistance;

			[Tooltip("If the distance from the muscle to it's target is larger than this value, the character will be knocked out.")]
			public float knockOutDistance;

			[Tooltip("The PhysicsMaterial applied to the muscles while the character is in Puppet or GetUp state. Using a lower friction material reduces the risk of muscles getting stuck and pulled out of their joints.")]
			public PhysicMaterial puppetMaterial;

			[Tooltip("The PhysicsMaterial applied to the muscles while the character is in Unpinned state.")]
			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		public struct MusclePropsGroup
		{
			[HideInInspector]
			public string name;

			[Tooltip("Muscle groups to which those properties apply.")]
			public Muscle.Group[] groups;

			[Tooltip("The muscle properties for those muscle groups.")]
			public MuscleProps props;
		}

		[Serializable]
		public struct CollisionResistanceMultiplier
		{
			public LayerMask layers;

			[Tooltip("Multiplier for the 'Collision Resistance' for these layers.")]
			public float multiplier;

			[Tooltip("Overrides 'Collision Threshold' for these layers.")]
			public float collisionThreshold;
		}

		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[LargeHeader("Collision And Recovery")]
		public MasterProps masterProps;

		[Tooltip("Will ground the target to those layers when getting up.")]
		public LayerMask groundLayers;

		[Tooltip("Will unpin the muscles that collide with those layers.")]
		public LayerMask collisionLayers;

		[Tooltip("The collision impulse sqrMagnitude threshold under which collisions will be ignored.")]
		public float collisionThreshold;

		public Weight collisionResistance;

		[Tooltip("Multiplies collision resistance for the specified layers.")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Range(1f, 30f)]
		[Tooltip("An optimisation. Will only process up to this number of collisions per physics step.")]
		public int maxCollisions;

		[Range(0.001f, 10f)]
		[Tooltip("How fast will the muscles of this group regain their pin weight?")]
		public float regainPinSpeed;

		[Tooltip("'Boosting' is a term used for making muscles temporarily immune to collisions and/or deal more damage to the muscles of other characters. That is done by increasing Muscle.State.immunity and Muscle.State.impulseMlp. For example when you set muscle.state.immunity to 1, boostFalloff will determine how fast this value will fall back to normal (0). Use BehaviourPuppet.BoostImmunity() and BehaviourPuppet.BoostImpulseMlp() for boosting from your own scripts. It is helpful for making the puppet stronger and deliever more punch while playing a melee hitting/kicking animation.")]
		public float boostFalloff;

		[Tooltip("The default muscle properties. If there are no 'Group Overrides', this will be used for all muscles.")]
		[LargeHeader("Muscle Group Properties")]
		public MuscleProps defaults;

		[Tooltip("Overriding default muscle properties for some muscle groups (for example making the feet stiffer or the hands looser).")]
		public MusclePropsGroup[] groupOverrides;

		[Range(0.001f, 10f)]
		[Tooltip("If the distance from the muscle to it's target is larger than this value, the character will be knocked out.")]
		[LargeHeader("Losing Balance")]
		public float knockOutDistance;

		[Range(0f, 1f)]
		[Tooltip("Smaller value makes the muscles weaker when the puppet is knocked out.")]
		public float unpinnedMuscleWeightMlp;

		[Tooltip("Most character controllers apply supernatural accelerations to characters when changing running direction or jumping. It will require major pinning forces to be applied on the ragdoll to keep up with that acceleration. When a puppet collides with something at that point and is unpinned, those forces might shoot the puppet off to space. This variable limits the velocity of the ragdoll's Rigidbodies when the puppet is unpinned.")]
		public float maxRigidbodyVelocity;

		[Range(0f, 1f)]
		[Tooltip("If a muscle has drifted farther than 'Knock Out Distance', will only unpin the puppet if it's pin weight is less than this value. Lowering this value will make puppets less likely to lose balance on minor collisions.")]
		public float pinWeightThreshold;

		[Tooltip("If false, will not unbalance the puppet by muscles that have their pin weight set to 0 in PuppetMaster muscle settings.")]
		public bool unpinnedMuscleKnockout;

		[Tooltip("If true, all muscles of the 'Prop' group will be detached from the puppet when it loses balance.")]
		public bool dropProps;

		[Tooltip("If true, GetUp state will be triggerred automatically after 'Get Up Delay' and when the velocity of the hip muscle is less than 'Max Get Up Velocity'.")]
		[LargeHeader("Getting Up")]
		public bool canGetUp;

		[Tooltip("Minimum delay for getting up after loosing balance. After that time has passed, will wait for the velocity of the hip muscle to come down below 'Max Get Up Velocity' and then switch to the GetUp state.")]
		public float getUpDelay;

		[Tooltip("The duration of blending the animation target from the ragdoll pose to the getting up animation once the GetUp state has been triggered.")]
		public float blendToAnimationTime;

		[Tooltip("Will not get up before the velocity of the hip muscle has come down to this value.")]
		public float maxGetUpVelocity;

		[Tooltip("The duration of the 'GetUp' state after which it switches to the 'Puppetä state.")]
		public float minGetUpDuration;

		[Tooltip("Collision resistance multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpCollisionResistanceMlp;

		[Tooltip("Regain pin weight speed multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpRegainPinSpeedMlp;

		[Tooltip("Knock out distance multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpKnockOutDistanceMlp;

		[Tooltip("Offset of the target character (in character rotation space) from the hip bone when initiating getting up animation from a prone pose. Tweak this value if your character slides a bit when starting to get up.")]
		public Vector3 getUpOffsetProne;

		[Tooltip("Offset of the target character (in character rotation space) from the hip bone when initiating getting up animation from a supine pose. Tweak this value if your character slides a bit when starting to get up.")]
		public Vector3 getUpOffsetSupine;

		[Tooltip("Called when the character starts getting up from a prone pose (facing down).")]
		[LargeHeader("Events")]
		public PuppetEvent onGetUpProne;

		[Tooltip("Called when the character starts getting up from a supine pose (facing up).")]
		public PuppetEvent onGetUpSupine;

		[Tooltip("Called when the character is knocked out (loses balance). Doesn't matter from which state.")]
		public PuppetEvent onLoseBalance;

		[Tooltip("Called when the character is knocked out (loses balance) only from the normal Puppet state.")]
		public PuppetEvent onLoseBalanceFromPuppet;

		[Tooltip("Called when the character is knocked out (loses balance) only from the GetUp state.")]
		public PuppetEvent onLoseBalanceFromGetUp;

		[Tooltip("Called when the character has fully recovered and switched to the Puppet state.")]
		public PuppetEvent onRegainBalance;

		public CollisionDelegate OnCollision;

		public CollisionImpulseDelegate OnCollisionImpulse;

		[HideInInspector]
		public bool canMoveTarget;

		private float unpinnedTimer;

		private float getUpTimer;

		private Vector3 hipsForward;

		private Vector3 hipsUp;

		private float getupAnimationBlendWeight;

		private float getupAnimationBlendWeightV;

		private bool getUpTargetFixed;

		private NormalMode lastNormalMode;

		private int collisions;

		private bool eventsEnabled;

		private float lastKnockOutDistance;

		private float knockOutDistanceSqr;

		private bool getupDisabled;

		private bool hasCollidedSinceGetUp;

		private bool hasBoosted;

		private MuscleCollisionBroadcaster broadcaster;

		private Vector3 getUpPosition;

		private bool dropPropFlag;

		public State state { get; private set; }

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		protected override void OnInitiate()
		{
		}

		protected override void OnActivate()
		{
		}

		public override void KillStart()
		{
		}

		public override void KillEnd()
		{
		}

		public override void Resurrect()
		{
		}

		protected override void OnDeactivate()
		{
		}

		protected override void OnFixedUpdate()
		{
		}

		protected override void OnLateUpdate()
		{
		}

		private bool SetKinematic()
		{
			return default(bool);
		}

		protected override void OnReadBehaviour()
		{
		}

		private void BlendMuscleMapping(int muscleIndex, bool to)
		{
		}

		public override void OnMuscleAdded(Muscle m)
		{
		}

		public override void OnMuscleRemoved(Muscle m)
		{
		}

		protected void MoveTarget(Vector3 position)
		{
		}

		protected void RotateTarget(Quaternion rotation)
		{
		}

		protected override void GroundTarget(LayerMask layers)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		public void Boost(float immunity, float impulseMlp)
		{
		}

		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		public void BoostImmunity(float immunity)
		{
		}

		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		public void Unpin()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		private float GetImpulse(MuscleCollision m, float layerThreshold)
		{
			return default(float);
		}

		private void UnPin(int muscleIndex, float unpin)
		{
		}

		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		private bool Activate(Collision collision, float impulse)
		{
			return default(bool);
		}

		public bool IsProne()
		{
			return default(bool);
		}

		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return default(float);
		}

		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return default(float);
		}

		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return default(bool);
		}

		private MuscleProps GetProps(Muscle.Group group)
		{
			return default(MuscleProps);
		}

		public void SetState(State newState)
		{
		}

		public void SetColliders(bool unpinned)
		{
		}

		private void SetColliders(Muscle m, bool unpinned)
		{
		}

		public BehaviourPuppet()
			: base()
		{
		}
	}
}
