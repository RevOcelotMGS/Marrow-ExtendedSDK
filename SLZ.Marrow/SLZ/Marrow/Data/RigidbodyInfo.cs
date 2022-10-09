using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	[Serializable]
	public class RigidbodyInfo
	{
		[SerializeField]
		private float _mass;

		[SerializeField]
		private float _drag;

		[SerializeField]
		private float _angularDrag;

		[SerializeField]
		private bool _useGravity;

		[SerializeField]
		private bool _isKinematic;

		[SerializeField]
		private RigidbodyInterpolation _interpolate;

		[SerializeField]
		[EnumFlags]
		private CollisionDetectionMode _collisionDetection;

		[SerializeField]
		private RigidbodyConstraints _constraints;

		[SerializeField]
		private Vector3 _centerOfMass;

		[SerializeField]
		private float _maxAngularVelocity;

		[SerializeField]
		private Vector3 _inertiaTensor;

		[SerializeField]
		private Vector3 _initalVelocity;

		[SerializeField]
		private Vector3 _initialAngularVelocity;

		public void Snapshot(Rigidbody rb)
		{
		}

		public void Apply(Rigidbody rb)
		{
		}

		public void Destroy(Rigidbody rb)
		{
		}

		public Rigidbody Create(GameObject go)
		{
			return null;
		}

		public RigidbodyInfo()
			: base()
		{
		}
	}
}
