using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[LargeHeader("References")]
		public Animator animator;

		public BipedIK bipedIK;

		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		public Transform lookAtTargetAnimator;

		[Range(0f, 1f)]
		public float lookAtWeight;

		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		public Transform footTargetAnimator;

		[Range(0f, 1f)]
		public float footPositionWeight;

		[Range(0f, 1f)]
		public float footRotationWeight;

		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		public Transform handTargetAnimator;

		[Range(0f, 1f)]
		public float handPositionWeight;

		[Range(0f, 1f)]
		public float handRotationWeight;

		private void OnAnimatorIK(int layer)
		{
		}

		public BipedIKvsAnimatorIK()
			: base()
		{
		}
	}
}
