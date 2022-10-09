using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		private AimPoser.Pose aimPose;

		private AimPoser.Pose lastPose;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void Pose()
		{
		}

		private void LimitAimTarget()
		{
		}

		private void DirectCrossFade(string state, float target)
		{
		}

		public SimpleAimingSystem()
			: base()
		{
		}
	}
}
