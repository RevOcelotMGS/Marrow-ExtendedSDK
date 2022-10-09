using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class PendulumExample : MonoBehaviour
	{
		[Tooltip("The master weight of this script.")]
		[Range(0f, 1f)]
		public float weight;

		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[HideInInspector]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		public Vector3 rootTargetPosition;

		[HideInInspector]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		public Quaternion rootTargetRotation;

		[SerializeField]
		private Transform target;

		[SerializeField]
		private Transform leftHandTarget;

		[SerializeField]
		private Transform rightHandTarget;

		[SerializeField]
		private Transform leftFootTarget;

		[SerializeField]
		private Transform rightFootTarget;

		[SerializeField]
		private Transform pelvisTarget;

		[SerializeField]
		private Transform bodyTarget;

		[SerializeField]
		private Transform headTarget;

		[SerializeField]
		private Vector3 pelvisDownAxis;

		private FullBodyBipedIK ik;

		private Quaternion rootRelativeToPelvis;

		private Vector3 pelvisToRoot;

		private float lastWeight;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public PendulumExample()
			: base()
		{
		}
	}
}
