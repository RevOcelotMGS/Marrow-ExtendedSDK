using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(AimIK))]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Range(0f, 1f)]
		public float headLookWeight;

		public Vector3 gunHoldOffset;

		public Vector3 leftHandOffset;

		public Recoil recoil;

		private AimIK aim;

		private FullBodyBipedIK ik;

		private Vector3 headLookAxis;

		private Vector3 leftHandPosRelToRightHand;

		private Quaternion leftHandRotRelToRightHand;

		private Vector3 aimTarget;

		private Quaternion rightHandRotation;

		protected override void Start()
		{
		}

		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		private void Read()
		{
		}

		private void AimIK()
		{
		}

		private void FBBIK()
		{
		}

		private void OnPreRead()
		{
		}

		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		private void OnDestroy()
		{
		}

		public AnimatorController3rdPersonIK()
			: base()
		{
		}
	}
}
