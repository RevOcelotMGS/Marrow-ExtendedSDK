using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		public enum Mode
		{
			FeetCentroid = 0,
			CenterOfPressure = 1
		}

		public Mode mode;

		public float velocityDamper;

		public float velocityLerpSpeed;

		public float velocityMax;

		public float centerOfPressureSpeed;

		public Vector3 offset;

		[HideInInspector]
		public bool[] groundContacts;

		[HideInInspector]
		public Vector3[] groundContactPoints;

		private LayerMask groundLayers;

		public Vector3 position { get; private set; }

		public Vector3 direction { get; private set; }

		public float angle { get; private set; }

		public Vector3 velocity { get; private set; }

		public Vector3 rbVelocity { get; private set; }

		public Vector3 centerOfPressure { get; private set; }

		public Quaternion rotation { get; private set; }

		public Quaternion inverseRotation { get; private set; }

		public bool isGrounded { get; private set; }

		public float lastGroundedTime { get; private set; }

		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		private void OnHierarchyChanged()
		{
		}

		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		private void OnPreActivate()
		{
		}

		private void OnPreLateUpdate()
		{
		}

		private void OnPreDeactivate()
		{
		}

		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default(Vector3);
		}

		private bool IsGrounded()
		{
			return default(bool);
		}

		private Vector3 GetCenterOfMass()
		{
			return default(Vector3);
		}

		private Vector3 GetCenterOfMassVelocity()
		{
			return default(Vector3);
		}

		private Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		private Vector3 GetMomentum()
		{
			return default(Vector3);
		}

		private Vector3 GetCenterOfPressure()
		{
			return default(Vector3);
		}

		private Vector3 GetFeetCentroid()
		{
			return default(Vector3);
		}

		public SubBehaviourCOM()
			: base()
		{
		}
	}
}
