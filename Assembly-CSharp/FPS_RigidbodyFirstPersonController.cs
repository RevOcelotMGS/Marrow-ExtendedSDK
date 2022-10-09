using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class FPS_RigidbodyFirstPersonController : MonoBehaviour
{
	[Serializable]
	public class MovementSettings
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

		public MovementSettings()
			: base()
		{
		}
	}

	[Serializable]
	public class AdvancedSettings
	{
		public float groundCheckDistance;

		public float stickToGroundHelperDistance;

		public float slowDownRate;

		public bool airControl;

		[Tooltip("set it to 0.1 or more if you get stuck in wall")]
		public float shellOffset;

		public AdvancedSettings()
			: base()
		{
		}
	}

	public Camera cam;

	public MovementSettings movementSettings;

	public AdvancedSettings advancedSettings;

	private Rigidbody m_RigidBody;

	private CapsuleCollider m_Capsule;

	private float m_YRotation;

	private Vector3 m_GroundContactNormal;

	private bool m_Jump;

	private bool m_PreviouslyGrounded;

	private bool m_Jumping;

	private bool m_IsGrounded;

	private FPS_MouseLook mouseLook;

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

	public FPS_RigidbodyFirstPersonController()
		: base()
	{
	}
}
