using System.Runtime.InteropServices;
using UnityEngine;
using UnitySA.Utility;

namespace UnitySA.Characters.FirstPerson
{
	[RequireComponent(typeof(CharacterController))]
	[RequireComponent(typeof(AudioSource))]
	public class FPCtrl : MonoBehaviour
	{
		[SerializeField]
		private bool m_IsWalking;

		[SerializeField]
		private float m_WalkSpeed;

		[SerializeField]
		private float m_RunSpeed;

		[Range(0f, 1f)]
		[SerializeField]
		private float m_RunstepLenghten;

		[SerializeField]
		private float m_JumpSpeed;

		[SerializeField]
		private float m_StickToGroundForce;

		[SerializeField]
		private float m_GravityMultiplier;

		[SerializeField]
		private MLook m_MouseLook;

		[SerializeField]
		private bool m_UseFovKick;

		[SerializeField]
		private FOVZoom m_FovKick;

		[SerializeField]
		private bool m_UseHeadBob;

		[SerializeField]
		private CurveCtrlBob m_HeadBob;

		[SerializeField]
		private LerpCtrlBob m_JumpBob;

		[SerializeField]
		private float m_StepInterval;

		private Camera m_Camera;

		private bool m_Jump;

		private float m_YRotation;

		private Vector2 m_Input;

		private Vector3 m_MoveDir;

		private CharacterController m_CharacterController;

		private CollisionFlags m_CollisionFlags;

		private bool m_PreviouslyGrounded;

		private Vector3 m_OriginalCameraPosition;

		private float m_StepCycle;

		private float m_NextStep;

		private bool m_Jumping;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void ProgressStepCycle(float speed)
		{
		}

		private void UpdateCameraPosition(float speed)
		{
		}

		private void GetInput([Out] float speed)
		{
		}

		private void RotateView()
		{
		}

		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		public FPCtrl()
			: base()
		{
		}
	}
}
