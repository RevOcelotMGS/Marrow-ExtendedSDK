using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Demos
{
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		public enum MoveMode
		{
			Directional = 0,
			Strafe = 1
		}

		public struct AnimState
		{
			public Vector3 moveDirection;

			public bool jump;

			public bool crouch;

			public bool onGround;

			public bool isStrafing;

			public float yVelocity;

			public bool doubleJump;
		}

		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		public UserControlThirdPerson userControl;

		public CameraController cam;

		[Header("Movement")]
		public MoveMode moveMode;

		public bool smoothPhysics;

		public float smoothAccelerationTime;

		public float linearAccelerationSpeed;

		public float platformFriction;

		public float groundStickyEffect;

		public float maxVerticalVelocityOnGround;

		public float velocityToGroundTangentWeight;

		[Header("Rotation")]
		public bool lookInCameraDirection;

		public float turnSpeed;

		public float stationaryTurnSpeedMlp;

		[Header("Jumping and Falling")]
		public float airSpeed;

		public float airControl;

		public float jumpPower;

		public float jumpRepeatDelayTime;

		public bool doubleJumpEnabled;

		public float doubleJumpPowerMlp;

		[SerializeField]
		[Header("Wall Running")]
		private LayerMask wallRunLayers;

		public float wallRunMaxLength;

		public float wallRunMinMoveMag;

		public float wallRunMinVelocityY;

		public float wallRunRotationSpeed;

		public float wallRunMaxRotationAngle;

		public float wallRunWeightSpeed;

		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		public AnimState animState;

		protected Vector3 moveDirection;

		private Animator animator;

		private Vector3 normal;

		private Vector3 platformVelocity;

		private Vector3 platformAngularVelocity;

		private RaycastHit hit;

		private float jumpLeg;

		private float jumpEndTime;

		private float forwardMlp;

		private float groundDistance;

		private float lastAirTime;

		private float stickyForce;

		private Vector3 wallNormal;

		private Vector3 moveDirectionVelocity;

		private float wallRunWeight;

		private float lastWallRunWeight;

		private Vector3 fixedDeltaPosition;

		private Quaternion fixedDeltaRotation;

		private bool fixedFrame;

		private float wallRunEndTime;

		private Vector3 gravity;

		private Vector3 verticalVelocity;

		private float velocityY;

		private bool doubleJumped;

		private bool jumpReleased;

		public bool onGround { get; private set; }

		protected override void Start()
		{
		}

		private void OnAnimatorMove()
		{
		}

		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		private void FixedUpdate()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		private void WallRun()
		{
		}

		private bool CanWallRun()
		{
			return default(bool);
		}

		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		protected virtual void Rotate()
		{
		}

		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		protected virtual bool Jump()
		{
			return default(bool);
		}

		private void GroundCheck()
		{
		}

		public CharacterThirdPerson()
			: base()
		{
		}
	}
}
