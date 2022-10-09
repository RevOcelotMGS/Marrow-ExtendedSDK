using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Rigidbody))]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		[SerializeField]
		protected float gravityMultiplier;

		[SerializeField]
		protected float airborneThreshold;

		[SerializeField]
		private float slopeStartAngle;

		[SerializeField]
		private float slopeEndAngle;

		[SerializeField]
		private float spherecastRadius;

		[SerializeField]
		private LayerMask groundLayers;

		private PhysicMaterial zeroFrictionMaterial;

		private PhysicMaterial highFrictionMaterial;

		protected Rigidbody r;

		protected const float half = 0.5f;

		protected float originalHeight;

		protected Vector3 originalCenter;

		protected CapsuleCollider capsule;

		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		protected virtual void Start()
		{
		}

		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		protected void ScaleCapsule(float mlp)
		{
		}

		protected void HighFriction()
		{
		}

		protected void ZeroFriction()
		{
		}

		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		public CharacterBase()
			: base()
		{
		}
	}
}
