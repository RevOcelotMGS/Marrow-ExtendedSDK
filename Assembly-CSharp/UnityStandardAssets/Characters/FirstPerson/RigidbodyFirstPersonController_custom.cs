using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Rigidbody))]
	public class RigidbodyFirstPersonController_custom : MonoBehaviour
	{
		[Serializable]
		public class MovementSettings_custom
		{
			public float ForwardSpeed;

			public float BackwardSpeed;

			public float StrafeSpeed;

			public float RunMultiplier;

			public KeyCode RunKey;

			public float JumpForce;

			public AnimationCurve SlopeCurveModifier;

			[HideInInspector]
			public float CurrentTargetSpeed;

			private bool m_Running;

			public bool Running
			{
				get
				{
					return default(bool);
				}
			}

			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			public MovementSettings_custom()
				: base()
			{
			}
		}

		[Serializable]
		public class AdvancedSettings_custom
		{
			public float groundCheckDistance;

			public float stickToGroundHelperDistance;

			public float slowDownRate;

			public bool airControl;

			public AdvancedSettings_custom()
				: base()
			{
			}
		}

		public Camera cam;

		public MovementSettings_custom movementSettings;

		public MouseLook_custom mouseLook;

		public AdvancedSettings_custom advancedSettings;

		private Rigidbody m_RigidBody;

		private CapsuleCollider m_Capsule;

		private float m_YRotation;

		private Vector3 m_GroundContactNormal;

		private bool m_Jump;

		private bool m_PreviouslyGrounded;

		private bool m_Jumping;

		private bool m_IsGrounded;

		public Vector3 Velocity
		{
			get
			{
				return default(Vector3);
			}
		}

		public bool Grounded
		{
			get
			{
				return default(bool);
			}
		}

		public bool Jumping
		{
			get
			{
				return default(bool);
			}
		}

		public bool Running
		{
			get
			{
				return default(bool);
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private float SlopeMultiplier()
		{
			return default(float);
		}

		private void StickToGroundHelper()
		{
		}

		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		private void RotateView()
		{
		}

		private void GroundCheck()
		{
		}

		public RigidbodyFirstPersonController_custom()
			: base()
		{
		}
	}
}
