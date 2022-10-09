using UnityEngine;

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class GrounderQuadruped : Grounder
	{
		public struct Foot
		{
			public IKSolver solver;

			public Transform transform;

			public Quaternion rotation;

			public Grounding.Leg leg;

			public Foot(IKSolver solver, Transform transform)
			{
				this.leg = default(Grounding.Leg);
				this.rotation = default(Quaternion);
				this.transform = default(Transform);
				this.solver = default(IKSolver);
			}
		}

		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		[Range(-90f, 0f)]
		public float minRootRotation;

		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		[Range(0f, 90f)]
		public float maxRootRotation;

		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Range(0f, 1f)]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		public float maintainHeadRotationWeight;

		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		public IK[] legs;

		public IK[] forelegs;

		[HideInInspector]
		public Vector3 gravity;

		private Foot[] feet;

		private Vector3 animatedPelvisLocalPosition;

		private Quaternion animatedPelvisLocalRotation;

		private Quaternion animatedHeadLocalRotation;

		private Vector3 solvedPelvisLocalPosition;

		private Quaternion solvedPelvisLocalRotation;

		private Quaternion solvedHeadLocalRotation;

		private int solvedFeet;

		private bool solved;

		private float angle;

		private Transform forefeetRoot;

		private Quaternion headRotation;

		private float lastWeight;

		private Rigidbody characterRootRigidbody;

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		public override void ResetPosition()
		{
		}

		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void Initiate()
		{
		}

		private Transform[] InitiateFeet(IK[] ikComponents, Foot[] f, int indexOffset)
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		private void RootRotation()
		{
		}

		private void OnSolverUpdate()
		{
		}

		private void UpdateForefeetRoot()
		{
		}

		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		private void OnPostSolverUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		private void DestroyLegs(IK[] ikComponents)
		{
		}

		public GrounderQuadruped()
			: base()
		{
		}
	}
}
