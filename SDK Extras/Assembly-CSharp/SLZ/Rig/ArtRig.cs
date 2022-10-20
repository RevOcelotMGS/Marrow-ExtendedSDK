using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class ArtRig : Rig
	{
		[Header("ArtRig")]
		public bool testTween2;

		public Transform l3Vert;

		public Transform l1Vert;

		public Transform t7Vert;

		public Transform eyeLf;

		public Transform eyeRt;

		public Transform clavLf;

		public Transform scapLf;

		public Transform wristLf;

		public Transform carpalLf;

		public Transform clavRt;

		public Transform scapRt;

		public Transform wristRt;

		public Transform carpalRt;

		public Transform toeLf;

		public Transform toeRt;

		public Transform breastLf;

		public Transform breastRt;

		public Transform buttLf;

		public Transform buttRt;

		[Header("Art Offsets")]
		public Transform artHips;

		public Transform artSpine;

		public Transform artChest;

		public Transform artUpperChest;

		public Transform artNeck;

		public Transform artHead;

		public Transform artEyeLf;

		public Transform artEyeRt;

		public Transform artJaw;

		public Transform artShoulderLf;

		public Transform artScapLf;

		public Transform artUpperArmLf;

		public Transform artLowerArmLf;

		public Transform artWristLf;

		public Transform artHandLf;

		public Transform artCarpalLf;

		public Transform artShoulderRt;

		public Transform artScapRt;

		public Transform artUpperArmRt;

		public Transform artLowerArmRt;

		public Transform artWristRt;

		public Transform artHandRt;

		public Transform artCarpalRt;

		public Transform artUpperLegLf;

		public Transform artLowerLegLf;

		public Transform artFootLf;

		public Transform artToeLf;

		public Transform artUpperLegRt;

		public Transform artLowerLegRt;

		public Transform artFootRt;

		public Transform artToeRt;

		public Transform artThumbLf1;

		public Transform artThumbLf2;

		public Transform artThumbLf3;

		public Transform artThumbRt1;

		public Transform artThumbRt2;

		public Transform artThumbRt3;

		public Transform artFingerLf11;

		public Transform artFingerLf12;

		public Transform artFingerLf13;

		public Transform artFingerLf21;

		public Transform artFingerLf22;

		public Transform artFingerLf23;

		public Transform artFingerLf31;

		public Transform artFingerLf32;

		public Transform artFingerLf33;

		public Transform artFingerLf41;

		public Transform artFingerLf42;

		public Transform artFingerLf43;

		public Transform artFingerRt11;

		public Transform artFingerRt12;

		public Transform artFingerRt13;

		public Transform artFingerRt21;

		public Transform artFingerRt22;

		public Transform artFingerRt23;

		public Transform artFingerRt31;

		public Transform artFingerRt32;

		public Transform artFingerRt33;

		public Transform artFingerRt41;

		public Transform artFingerRt42;

		public Transform artFingerRt43;

		public Transform artBreastLf;

		public Transform artBreastRt;

		public Transform artButtLf;

		public Transform artButtRt;

		[SerializeField]
		private HandPoseAnimator _leftAnimatorHand;

		[SerializeField]
		private HandPoseAnimator _rightAnimatorHand;

		public HandPoseAnimator LeftAnimatorHand
		{
			get
			{
				return null;
			}
		}

		public HandPoseAnimator RightAnimatorHand
		{
			get
			{
				return null;
			}
		}

		public override void Reset()
		{
		}

		public override void OnAwake()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnLateUpdate()
		{
		}

		public override void Teleport(Vector3 displace, bool zeroVelocity = false)
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public void ApplyRotationOffsetsToRig(SLZ.VRMK.Avatar avatar)
		{
		}

		private void TweenSpine(SLZ.VRMK.Avatar avatar)
		{
		}

		private void SetArms(Rig inRig, SLZ.VRMK.Avatar avatar)
		{
		}

		private void SolveCarpal(SimpleTransform wrist, SimpleTransform hand, Transform carpal, float segmentLength)
		{
		}

		public ArtRig()
			: base()
		{
		}
	}
}
