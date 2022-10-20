using System.Runtime.InteropServices;
using SLZ.Interaction;
using SLZ.Rig;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.VRMK
{
	public class PhysHand : MonoBehaviour
	{
		public enum HandPhysState
		{
			Empty = 0,
			RbOneHand = 1,
			RbTwoHand = 2,
			StaticOneHand = 3,
			StaticTwoHand = 4
		}

		[SerializeField]
		private Rigidbody _handRb;

		[SerializeField]
		private Rigidbody _upperArmRb;

		[SerializeField]
		private Rigidbody _lowerArmRb;

		[SerializeField]
		private Servo _handChestServo;

		[SerializeField]
		private Servo _shoulderServo;

		[SerializeField]
		private Servo _elbowServo;

		[SerializeField]
		private Servo _wristServo;

		public PhysicsRig physBody;

		public Hand hand;

		public PhysHand otherHand;

		public float dampening;

		public float newtonDamp;

		public float additionalMass;

		public float forceMultiplier;

		[Header("Shoulder Muscles")]
		public float xPosForce;

		public float xNegForce;

		public float yPosForce;

		public float yNegForce;

		public float zPosForce;

		public float zNegForce;

		[Header("Wrist Muscles")]
		public float maxTorque;

		public float angDampening;

		public float gripMult;

		private float _jerkedMult;

		private float angJerkMult;

		private float _xPos;

		private float _xNeg;

		private float _yPos;

		private float _yNeg;

		private float _zPos;

		private float _zNeg;

		private Quaternion _muscleSpace;

		private Vector3 _muscleAngVel;

		public AnimationCurve TorqueMultiplier;

		public CapsuleCollider inventoryPlug;

		[FormerlySerializedAs("forearmCol")]
		public CapsuleCollider wristCol;

		public CapsuleCollider colliderUpper;

		public CapsuleCollider colliderLower;

		public MeshCollider cLower;

		public BoxCollider handCol;

		public BoxCollider fingersCol;

		public CylinderGrip gShoulder;

		public CylinderGrip gElbow;

		private Vector3 _lastTargetLocalPos;

		private Quaternion _lastTargetRotation;

		private float _stuck;

		private Vector3 _lastForce;

		private Vector3 _lastVel;

		private Vector3 _lastTorque;

		private Vector3 _lastAngVel;

		private bool _colliding;

		private Vector3 _collisionImpulse;

		public Vector3 currentCollision;

		private float _handSupported;

		private float _armMantle;

		private float _curlLerp;

		private bool _isHighFriction;

		private bool _fingerEnableFlag;

		private PhysicMaterial _highFriction;

		public PhysicMaterial lowFriction;

		public LayerMask fingerColCheckMask;

		public bool drawMaxForceDebug;

		public bool drawAccuracyDebug;

		public bool forceViaJoint;

		public bool torqueViaJoint;

		public HandPhysState handPhysState;

		private const float _staticCheatMult = 0.3f;

		public Rigidbody rbHand
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

		public float handSupported
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float armMantle
		{
			get
			{
				return default(float);
			}
		}

		public Vector3 wristWorld
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 lastForce
		{
			get
			{
				return default(Vector3);
			}
		}

		private void Awake()
		{
		}

		public void IgnorePhysHand(PhysHand physHand, bool ignore = true)
		{
		}

		public void IgnoreHandRbColliders(Collider col, bool ignore = true)
		{
		}

		public void IgnoreWholeArmColliders(Collider col, bool ignore = true)
		{
		}

		public void CalibrateArmColliders(Avatar avatar, bool isRight = false)
		{
		}

		public void CalibrateArmJoints(Avatar avatar, bool isRight = false)
		{
		}

		public void CalibrateLimbGrips(Avatar avatar, bool isRight = false)
		{
		}

		public void UpdateArmTargets(Transform chest, Transform shoulder, Transform elbow, Transform hand, Vector3 wristCa, float maxLength, float deltaTime)
		{
		}

		public void SetArmMass(float mass, bool isRight, Vector2 handSize)
		{
		}

		public void CalibrateJoints(float avatarArmMult, float gripMult)
		{
		}

		public void UpdateColliders(float curl, Vector2 handSize, bool isRight = false)
		{
		}

		public void DisableFingerCollider()
		{
		}

		public void EnableFingerCollider()
		{
		}

		private void CheckFingerEnable()
		{
		}

		public Vector3 GetArmMomentum([Out] float totalMass)
		{
			return default(Vector3);
		}

		public void UpdateArmDrives(Vector3 targetLocalPos, Quaternion targetRotation, ConfigurableJoint joint, float gripInput, bool secondToSolveAndStatic)
		{
		}

		private void ApplyForce(Vector3 targetLocalPos, ConfigurableJoint joint, bool secondToSolveAndStatic)
		{
		}

		private void PrepShoulderMuscle(Vector3 handVelocity, Vector3 newtonsDamped)
		{
		}

		private Vector3 MuscleClamp(Vector3 desiredForce)
		{
			return default(Vector3);
		}

		private Vector3 MuscleMax(Vector3 direction)
		{
			return default(Vector3);
		}

		private void SetFriction(float grip)
		{
		}

		private float RelaxTorqueMult(float grip)
		{
			return default(float);
		}

		private void ApplyTorque(Quaternion targetRotation, float maxTor, ConfigurableJoint joint)
		{
		}

		private void ApplyTorque2(Quaternion targetRotation, float maxTor, ConfigurableJoint joint)
		{
		}

		public bool RefreshHandStates(ConfigurableJoint thisJ, ConfigurableJoint otherJ, [Out] bool otherHandStatic)
		{
			return default(bool);
		}

		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}

		private bool IsNanV3(Vector3 v)
		{
			return default(bool);
		}

		private Vector3 AbsV3(Vector3 v)
		{
			return default(Vector3);
		}

		public void SetHand(Vector3 worldPosition, Quaternion worldRotation, bool zeroVelocity = true)
		{
		}

		public void ClearJerk(float newJerk = 0f)
		{
		}

		public void CollisionRelay(Collision c)
		{
		}

		public void ReadSensors(ConfigurableJoint joint, float divByNewtons)
		{
		}

		private float ArmMantle()
		{
			return default(float);
		}

		public bool CheckStuck(float divByNewtons)
		{
			return default(bool);
		}

		public bool ResetHand()
		{
			return default(bool);
		}

		public bool ResetHand(Transform elbow, Vector3 elbowFwd)
		{
			return default(bool);
		}

		public PhysHand()
			: base()
		{
		}
	}
}
