using SLZ.Interaction;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class PhysSoftBody : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody _breastLfRb;

		[SerializeField]
		private Rigidbody _breastRtRb;

		[SerializeField]
		private Rigidbody _buttLfRb;

		[SerializeField]
		private Rigidbody _buttRtRb;

		[SerializeField]
		private Rigidbody _softHandLfRb;

		[SerializeField]
		private Rigidbody _softHandRtRb;

		public Rigidbody chestBridge;

		public Rigidbody spineBridge;

		public Rigidbody pelvisBridge;

		public Rigidbody handLfBridge;

		public Rigidbody handRtBridge;

		public Rigidbody hipLfBridge;

		public Rigidbody hipRtBridge;

		public BoxCollider cHandLf;

		public BoxCollider cHandRt;

		public MeshCollider cBreastLf;

		public MeshCollider cBreastRt;

		public MeshCollider cButt_Lf;

		public MeshCollider cButt_Rt;

		[SerializeField]
		private Servo _breastLfServo;

		[SerializeField]
		private Servo _breastRtServo;

		[SerializeField]
		private Servo _buttLfServo;

		[SerializeField]
		private Servo _buttRtServo;

		public Rigidbody rbBreastLf
		{
			get
			{
				return null;
			}
		}

		public Rigidbody rbBreastRt
		{
			get
			{
				return null;
			}
		}

		public Rigidbody rbButtLf
		{
			get
			{
				return null;
			}
		}

		public Rigidbody rbButtRt
		{
			get
			{
				return null;
			}
		}

		public Rigidbody rbSoftHandLf
		{
			get
			{
				return null;
			}
		}

		public Rigidbody rbSoftHandRt
		{
			get
			{
				return null;
			}
		}

		public void OnAwakeInitialize()
		{
		}

		public void CalibrateTorsoColliders(SLZ.VRMK.Avatar avatar, PhysicsRig physRig)
		{
		}

		public void CalibrateJoints(SLZ.VRMK.Avatar avatar)
		{
		}

		public void UpdateKinematicBridges(PhysicsRig inRig)
		{
		}

		public PhysSoftBody()
			: base()
		{
		}
	}
}
