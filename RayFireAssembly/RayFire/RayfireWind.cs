using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[AddComponentMenu("RayFire/Rayfire Wind")]
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-wind-component/")]
	public class RayfireWind : MonoBehaviour
	{
		public Vector3 gizmoSize;

		public bool showGizmo;

		public float globalScale;

		public float lengthScale;

		public float widthScale;

		public float speed;

		public bool showNoise;

		public float minimum;

		public float maximum;

		public float torque;

		public bool forceByMass;

		public float divergency;

		public float turbulence;

		public float previewDensity;

		public float previewSize;

		public int mask;

		public string tagFilter;

		private Transform transForm;

		private Collider[] colliders;

		private Vector3 halfExtents;

		private Vector3 center;

		private float offset;

		public List<Rigidbody> rigidbodies;

		private void Awake()
		{
		}

		private void DefineComponents()
		{
		}

		private IEnumerator WindForceCor()
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void Reset()
		{
		}

		private void SetColliders()
		{
		}

		private void SetColliderGizmo()
		{
		}

		private void SetRigidBodies()
		{
		}

		private void SetForce()
		{
		}

		private Vector3 GetVectorGlobal(Vector3 worldPos)
		{
			return default(Vector3);
		}

		public Vector3 GetVectorLocal(Vector3 localPos)
		{
			return default(Vector3);
		}

		public Vector3 GetVectorLocalPreview(Vector3 localPos)
		{
			return default(Vector3);
		}

		private float PerlinFixedGlobal(Vector3 worldPos)
		{
			return default(float);
		}

		public float PerlinFixedLocal(Vector3 localPos)
		{
			return default(float);
		}

		public float PerlinCustomGlobal(Vector3 worldPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
		{
			return default(float);
		}

		public float PerlinCustomLocal(Vector3 localPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
		{
			return default(float);
		}

		public float WindStrength(float val)
		{
			return default(float);
		}

		private void SetSpeed()
		{
		}

		public RayfireWind()
			: base()
		{
		}
	}
}
