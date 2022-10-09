using UnityEngine;

namespace RootMotion.FinalIK
{
	public class LookAtController : MonoBehaviour
	{
		public LookAtIK ik;

		[Header("Target Smoothing")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		public Transform target;

		[Range(0f, 1f)]
		public float weight;

		public Vector3 offset;

		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Header("RootRotation")]
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		public float maxRootAngle;

		private Transform lastTarget;

		private float switchWeight;

		private float switchWeightV;

		private float weightV;

		private Vector3 lastPosition;

		private Vector3 dir;

		private bool lastSmoothTowardsTarget;

		private Vector3 pivot
		{
			get
			{
				return default(Vector3);
			}
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void ApplyMinDistance()
		{
		}

		private void RootRotation()
		{
		}

		public LookAtController()
			: base()
		{
		}
	}
}
