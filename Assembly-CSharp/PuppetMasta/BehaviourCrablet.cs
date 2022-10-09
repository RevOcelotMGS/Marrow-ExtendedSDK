using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Combat;
using SLZ.Interaction;
using SLZ.VRMK;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PuppetMasta
{
	public class BehaviourCrablet : BehaviourBaseNav
	{
		protected enum JumpType
		{
			Dash = 0,
			Attack = 1,
			FaceMount = 2,
			OffmeshLink = 3
		}

		[Header("Crab Settings")]
		public SubBehaviourIk ik;

		private LiteLoco _liteLoco;

		private int _mSecAnim;

		private int _flinchAnim;

		private int _angryAnim;

		private int _awakeAnim;

		private int _heldAnim;

		private int _jumpAttackAnim;

		private int _faceHugAnim;

		private int _standingAnim;

		private int _jumpChargeAnim;

		private int _jumpAnim;

		private int _faceHugNormalAnim;

		private int _faceMountAnim;

		private int _dismountAnim;

		private float linkJumpForce;

		private Vector3 linkTarget;

		public bool crumbleDeath;

		private bool _hasAttacked;

		private bool _jumpAttacking;

		private Collider[] _colliders;

		private int _interactableLayer;

		private int _triggerLayer;

		private ConfigurableJoint _faceJoint;

		private readonly Vector3 _testRotationOffset;

		private readonly Vector3 _testRotationOffsetNpc;

		private readonly Vector3 _testPositionOffset;

		private readonly Vector3 _crabMouthLocalOffset;

		protected JumpType jumpType;

		public float jumpCooldown;

		private float jumpCharge;

		public bool enableJumpAttack;

		public float facemountRngMult;

		public MeshRenderer visor;

		public SlotPosition slotPosition;

		private bool _chargeJump;

		private bool _headMounted;

		private float _mountDamageTickTime;

		private float _cooldownMelee;

		private TriggerRefProxy _grappleTarget;

		protected override void OnInitiate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		public void LinkJump(Transform jumpTarg, float jumpForce = 7f)
		{
		}

		public override void KillStart()
		{
		}

		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		public override void KillEnd()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnReadBehaviour()
		{
		}

		protected override void OnWriteBehaviour()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		protected override void ResetAnimator()
		{
		}

		protected void Jump(JumpType jType)
		{
		}

		protected void PreJumpAttack()
		{
		}

		protected void JumpAttacking()
		{
		}

		private bool CheckMount()
		{
			return default(bool);
		}

		private void UpdateMount(float distance)
		{
		}

		private void MountAttack(float damage)
		{
		}

		protected override void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		private bool AttachToFace(Rigidbody face, TriggerRefProxy trp, bool preAttach = false, bool isPlayer = true)
		{
			return default(bool);
		}

		private bool TransitionJointToEngaged()
		{
			return default(bool);
		}

		public void DetachFromFace()
		{
		}

		private void PlayerDeathDetachAdd()
		{
		}

		private void PlayerDeathDetachRemove()
		{
		}

		protected override void AiUpdate()
		{
		}

		protected override void AiTick()
		{
		}

		protected override void SwitchMentalState(MentalState mState)
		{
		}

		protected override void ReturnToPreAgro()
		{
		}

		protected override void SwitchLocoState(LocoState lState, float coolDown = 0f, bool forceSwitch = false)
		{
		}

		public BehaviourCrablet()
			: base()
		{
		}
	}
}
