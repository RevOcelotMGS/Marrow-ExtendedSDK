using SLZ.Interaction;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class PhysTorso : MonoBehaviour
	{
		[SerializeField]
		private float _spineForceMult;

		public float spineInternalMult;

		private bool _spineForceWasZero;

		[SerializeField]
		private float _linearDamperMult;

		[SerializeField]
		private float _slerpDamperMult;

		[SerializeField]
		private Rigidbody _headRb;

		[SerializeField]
		private Rigidbody _chestRb;

		[SerializeField]
		private Rigidbody _spineRb;

		[SerializeField]
		private Rigidbody _pelvisRb;

		[SerializeField]
		private Servo _headChestServo;

		[SerializeField]
		private Servo _headPelServo;

		[SerializeField]
		private Servo _chestPelServo;

		[SerializeField]
		private Servo _chestSpineServo;

		[SerializeField]
		private Servo _spinePelServo;

		public MeshCollider cPelvis;

		public MeshCollider cSpine;

		public MeshCollider cChest;

		public MeshCollider cHead;

		public CapsuleCollider neckCol;

		public Grip gPelvis;

		public Grip gSpine;

		public Grip gChest;

		public Grip gHead;

		public Rigidbody rbHead
		{
			get
			{
				return null;
			}
		}

		public Rigidbody rbChest
		{
			get
			{
				return null;
			}
		}

		public Rigidbody rbSpine
		{
			get
			{
				return null;
			}
		}

		public Rigidbody rbPelvis
		{
			get
			{
				return null;
			}
		}

		public void OnAwakeInitialize()
		{
		}

		public void CalibrateTorsoColliders(SLZ.VRMK.Avatar avatar)
		{
		}

		public void CalibrateJoints(SLZ.VRMK.Avatar avatar)
		{
		}

		public void CalibrateTorsoGrips(SLZ.VRMK.Avatar avatar)
		{
		}

		public void UpdateSpineJoints(Rig inRig, float deltaTime)
		{
		}

		public void UpdateSpineTargets(Rig inRig, float deltaTime)
		{
		}

		public void UpdateSpineDrives(float slerpForceMult, float slerpSpringMult, float slerpDampMult, float linearForceMult, float linearSpringMult, float linearDampMult)
		{
		}

		public void UpdateTorsoColliders(Rig inRig)
		{
		}

		public void SetTorsoMass(float torsoMass)
		{
		}

		public void IgnoreWholeTorsoColliders(Collider collider, bool ignore = true)
		{
		}

		public void IgnoreWholeTorsoColliders(Collider[] collider, bool ignore = true)
		{
		}

		public PhysTorso()
			: base()
		{
		}
	}
}
