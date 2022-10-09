using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		public enum RotationMode
		{
			Smooth = 0,
			Linear = 1
		}

		[Tooltip("The component that updates the camera.")]
		[SerializeField]
		private CameraController cameraController;

		[Tooltip("Acceleration of movement.")]
		[SerializeField]
		private float accelerationTime;

		[Tooltip("Turning speed.")]
		[SerializeField]
		private float turnTime;

		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		[SerializeField]
		private bool walkByDefault;

		[Tooltip("Smooth or linear rotation.")]
		[SerializeField]
		private RotationMode rotationMode;

		[SerializeField]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		private float moveSpeed;

		private Animator animator;

		private float speed;

		private float angleVel;

		private float speedVel;

		private Vector3 linearTargetDirection;

		private CharacterController characterController;

		public bool isGrounded { get; private set; }

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void Rotate()
		{
		}

		private void Move()
		{
		}

		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		public SimpleLocomotion()
			: base()
		{
		}
	}
}
