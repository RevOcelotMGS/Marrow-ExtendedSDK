using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class TwoHandedProp : MonoBehaviour
	{
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		private FullBodyBipedIK ik;

		private Vector3 targetPosRelativeToRight;

		private Quaternion targetRotRelativeToRight;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void AfterFBBIK()
		{
		}

		private void OnDestroy()
		{
		}

		public TwoHandedProp()
			: base()
		{
		}
	}
}
