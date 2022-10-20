using SLZ.Interaction;
using UnityEngine;

namespace SLZ.VRMK
{
	public class PhysLimb : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody _endRb;

		[SerializeField]
		private Rigidbody _upperRb;

		[SerializeField]
		private Rigidbody _lowerRb;

		[SerializeField]
		private Servo _endBaseServo;

		[SerializeField]
		private Servo _upperServo;

		[SerializeField]
		private Servo _lowerServo;

		[SerializeField]
		private Servo _endServo;

		public MeshCollider cUpper;

		public MeshCollider cLower;

		public BoxCollider endCol;

		public float forceMultiplier;

		public Rigidbody rbEnd
		{
			get
			{
				return null;
			}
		}

		public Rigidbody rbUpper
		{
			get
			{
				return null;
			}
		}

		public Rigidbody rbLower
		{
			get
			{
				return null;
			}
		}

		public Servo endBaseServo
		{
			get
			{
				return null;
			}
		}

		public Servo upperServo
		{
			get
			{
				return null;
			}
		}

		public Servo lowerServo
		{
			get
			{
				return null;
			}
		}

		public Servo endServo
		{
			get
			{
				return null;
			}
		}

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		public void IgnorePhysLimb(PhysLimb physLimb, bool ignore = true)
		{
		}

		public void IgnoreWholeLimbColliders(Collider col, bool ignore = true)
		{
		}

		public void IgnoreWholeLimbColliders(Collider[] col, bool ignore = true)
		{
		}

		public void CalibrateLimbColliders(Avatar avatar, bool isLeg = false, bool isRight = false)
		{
		}

		public void CalibrateLimbJoints(Avatar avatar, bool isLeg = false, bool isRight = false)
		{
		}

		public void UpdateLimbTargets(Quaternion localShoulder, Quaternion localElbow, Quaternion localHand, Quaternion localEndInChestRot, Vector3 localEndInChestPos, Vector3 wristCa, Vector3 wristAnchor, Vector3 shoulderCa, float maxLength, float deltaTime)
		{
		}

		public void UpdateArmDrives(Vector3 targetLocalPos, Quaternion targetRotation, ConfigurableJoint joint, float gripInput, bool secondToSolveAndStatic)
		{
		}

		public void SetLimbMass(float mass, bool isLeg = false)
		{
		}

		public void SetKinematic()
		{
		}

		public void SetPhysical()
		{
		}

		public PhysLimb()
			: base()
		{
		}
	}
}
