using UnityEngine;

namespace SLZ.Utilities
{
	public class RigidbodyData
	{
		private float _mass;

		private float _drag;

		private float _angularDrag;

		private bool _useGravity;

		private bool _isKinematic;

		private RigidbodyInterpolation _interpolate;

		private CollisionDetectionMode _collisionDetection;

		private RigidbodyConstraints _constraints;

		private Vector3 _centerOfMass;

		private float _maxAngularVelocity;

		private Vector3 _inertiaTensor;

		public void Snapshot(Rigidbody rb)
		{
		}

		public void Apply(Rigidbody rb)
		{
		}

		public Rigidbody Create(GameObject go)
		{
			return null;
		}

		public RigidbodyData()
			: base()
		{
		}
	}
}
