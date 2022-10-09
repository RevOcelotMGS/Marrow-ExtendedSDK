using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Vehicle
{
	public class LiftBoard : MonoBehaviour
	{
		[Header("References")]
		public Grip throttleGrip;

		public Seat driverSeat;

		public ConfigurableJoint cfJoint;

		private Rigidbody rb;

		[Header("Settings")]
		public bool flightMode;

		public float minHoverDist;

		public float hoverForceMulti;

		public float maxHoverForce;

		public float hoverGoalDampening;

		public float turnForce;

		public float throttleForce;

		public LayerMask raycastMask;

		public float debugLineLength;

		public float hoverRadius;

		[Tooltip("Value that the floating forces are multiplied by while vehicle is moving down in water. Higher = more stable floating")]
		public float Compressing;

		[Tooltip("Prevent extra force from compression becoming too high if the object is teleported deep underwater")]
		public float MaxCompressingForce;

		public float FloatForce;

		public float maxHeightForce;

		public float BackThrustStrength;

		[Header("Thrusters")]
		public Transform[] hoverThrusters;

		public Rigidbody[] playerRBs;

		private float weight;

		private float hoverRaycastDist;

		private float lastHoverRaycastDist;

		private float targetHoverDist;

		private float hoverDistVel;

		private Quaternion initialRotation;

		private GameObject helperTransform;

		private float rayHitHeight;

		private float hoverContactPoint;

		private float HoverHeight;

		private float HoverHeightLastFrame;

		private Vector3 hoverForce;

		public float totalHeight;

		public float depth;

		private void Awake()
		{
		}

		private float CalculateGrossWeight()
		{
			return default(float);
		}

		private void FixedUpdate()
		{
		}

		private Vector3 CalcCOM()
		{
			return default(Vector3);
		}

		public LiftBoard()
			: base()
		{
		}
	}
}
