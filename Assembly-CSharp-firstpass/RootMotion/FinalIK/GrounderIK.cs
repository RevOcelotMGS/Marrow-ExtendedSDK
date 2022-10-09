using UnityEngine;

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class GrounderIK : Grounder
	{
		public IK[] legs;

		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		public float rootRotationWeight;

		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		private Transform[] feet;

		private Quaternion[] footRotations;

		private Vector3 animatedPelvisLocalPosition;

		private Vector3 solvedPelvisLocalPosition;

		private int solvedFeet;

		private bool solved;

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

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void Initiate()
		{
		}

		private void OnSolverUpdate()
		{
		}

		private void SetLegIK(int index)
		{
		}

		private void OnPostSolverUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		public GrounderIK()
			: base()
		{
		}
	}
}
