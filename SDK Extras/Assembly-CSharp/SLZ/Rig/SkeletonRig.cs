using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class SkeletonRig : Rig
	{
		[Header("AnimationRig")]
		public Transform eyeLf;

		public Transform eyeRt;

		public Transform clavLf;

		public Transform clavRt;

		public Transform toeLf;

		public Transform toeRt;

		[SerializeField]
		private AnimationCurve _thoracicTwistCurve;

		[SerializeField]
		private LiteLoco _liteLoco;

		[SerializeField]
		private SLZ_Body _body;

		[SerializeField]
		private HandPoseAnimator _leftAnimatorHand;

		[SerializeField]
		private HandPoseAnimator _rightAnimatorHand;

		private SimpleTransform _pelvisLocalAnimOff;

		public SLZ_Body body
		{
			get
			{
				return null;
			}
		}

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

		public SimpleTransform pelvisLocalAnimOff
		{
			get
			{
				return default(SimpleTransform);
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

		public override void Teleport(Vector3 displace, bool zeroVelocity = false)
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public SkeletonRig()
			: base()
		{
		}
	}
}
