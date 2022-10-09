using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion
{
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		public enum UpdateMode
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2,
			FixedLateUpdate = 3
		}

		public Transform target;

		public Transform rotationSpace;

		public UpdateMode updateMode;

		public bool lockCursor;

		[Header("Position")]
		public bool smoothFollow;

		public Vector3 offset;

		public float followSpeed;

		[Header("Rotation")]
		public float rotationSensitivity;

		public float yMinLimit;

		public float yMaxLimit;

		public bool rotateAlways;

		public bool rotateOnLeftButton;

		public bool rotateOnRightButton;

		public bool rotateOnMiddleButton;

		[Header("Distance")]
		public float distance;

		public float minDistance;

		public float maxDistance;

		public float zoomSpeed;

		public float zoomSensitivity;

		[Header("Blocking")]
		public LayerMask blockingLayers;

		public float blockingRadius;

		public float blockingSmoothTime;

		[Range(0f, 1f)]
		public float blockedOffset;

		private Vector3 targetDistance;

		private Vector3 position;

		private Quaternion rotation;

		private Vector3 smoothPosition;

		private Camera cam;

		private bool fixedFrame;

		private float fixedDeltaTime;

		private Quaternion r;

		private Vector3 lastUp;

		private float blockedDistance;

		private float blockedDistanceV;

		public float x { get; private set; }

		public float y { get; private set; }

		public float distanceTarget { get; private set; }

		private float zoomAdd
		{
			get
			{
				return default(float);
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void UpdateInput()
		{
		}

		public void UpdateTransform()
		{
		}

		public void UpdateTransform(float deltaTime)
		{
		}

		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		public CameraController()
			: base()
		{
		}
	}
}
