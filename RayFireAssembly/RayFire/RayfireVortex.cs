using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RayFire
{
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-vortex-component/")]
	[AddComponentMenu("RayFire/Rayfire Vortex")]
	public class RayfireVortex : MonoBehaviour
	{
		[HideInInspector]
		public Transform transForm;

		[HideInInspector]
		public Collider[] colliders;

		[HideInInspector]
		public List<Rigidbody> rigidbodies;

		private Vector3 bot;

		private Vector3 top;

		private Vector3 normal;

		private Vector3 direction;

		private Vector3 rbPos;

		private Vector3 linePoint;

		private Vector3 vectorUp;

		private Vector3 centerOutVector;

		private Vector3 vectorCenter;

		private Vector3 perpend;

		private Vector3 vectorSwirl;

		private Vector3 forceVector;

		private float distancePerpend;

		private float distanceBottom;

		private float upRateNow;

		private float localRadius;

		private float upRateOwn;

		private float centerRateOwn;

		private float centerRateNow;

		private float upRateDif;

		private float centerRateDif;

		private float maxRadius;

		private float axisDistance;

		private Plane bottomPlane;

		private float torqueVal;

		public bool topHandle;

		public Vector3 topAnchor;

		public Vector3 bottomAnchor;

		public bool showGizmo;

		public float topRadius;

		public float bottomRadius;

		public float eye;

		public bool forceByMass;

		public float stiffness;

		public float swirlStrength;

		public bool enableTorque;

		public float torqueStrength;

		public float torqueVariation;

		public bool enableHeightBias;

		public float biasSpeed;

		public float biasSpread;

		public int seed;

		public int circles;

		public int mask;

		public string tagFilter;

		private void Awake()
		{
		}

		private void DefineComponents()
		{
		}

		private IEnumerator VortexForceCor()
		{
			return null;
		}

		private IEnumerator SetCollidersCor()
		{
			return null;
		}

		private void OnEnable()
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

		private Vector3 GetClosetLinePoint(Vector3 worldPos)
		{
			return default(Vector3);
		}

		private Vector3 GetParallelLinePoint(Vector3 worldPos)
		{
			return default(Vector3);
		}

		public static bool LinePlaneIntersection([Out] Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(bool);
		}

		private static Vector3 SetVectorLength(Vector3 vector, float size)
		{
			return default(Vector3);
		}

		private float HeightBias(float upRateOwnLoc, float centerRateOwnLoc)
		{
			return default(float);
		}

		public RayfireVortex()
			: base()
		{
		}
	}
}
