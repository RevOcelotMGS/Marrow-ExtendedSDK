using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-activator-component/")]
	[AddComponentMenu("RayFire/Rayfire Activator")]
	public class RayfireActivator : MonoBehaviour
	{
		public enum ActivationType
		{
			OnTriggerEnter = 0,
			OnTriggerExit = 1,
			OnCollision = 2
		}

		public enum AnimationType
		{
			ByGlobalPositionList = 0,
			ByStaticLine = 1,
			ByDynamicLine = 2,
			ByLocalPositionList = 5
		}

		public enum GizmoType
		{
			Box = 1,
			Sphere = 0,
			Collider = 2,
			ParticleSystem = 5
		}

		public GizmoType gizmoType;

		public float sphereRadius;

		public Vector3 boxSize;

		public bool checkRigid;

		public bool checkRigidRoot;

		public ActivationType type;

		public float delay;

		public bool demolishCluster;

		public bool apply;

		public Vector3 velocity;

		public Vector3 spin;

		public ForceMode mode;

		public bool showAnimation;

		public float duration;

		public float scaleAnimation;

		public AnimationType positionAnimation;

		public LineRenderer line;

		public List<Vector3> positionList;

		public bool showGizmo;

		public Collider activatorCollider;

		public ParticleSystem ps;

		public List<ParticleCollisionEvent> collisionEvents;

		private bool animating;

		private float pathRatio;

		private float lineLength;

		private List<float> checkpoints;

		private float delta;

		private float deltaRatioStep;

		private float distDeltaStep;

		private float distRatio;

		private float timePassed;

		private int activeSegment;

		private Vector3 positionStart;

		private Vector3 scaleStart;

		public bool ByPositions
		{
			get
			{
				return default(bool);
			}
		}

		public bool ByLine
		{
			get
			{
				return default(bool);
			}
		}

		private void Awake()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnParticleCollision(GameObject other)
		{
		}

		private void OnTriggerEnter(Collider coll)
		{
		}

		private void OnTriggerExit(Collider coll)
		{
		}

		private void SetCollider()
		{
		}

		private void SetParticleSystem()
		{
		}

		private void ActivationCheck(Collider coll)
		{
		}

		private void RigidListActivationCheck(Collider coll)
		{
		}

		private IEnumerator DelayedActivationCor(RayfireRigid rigid)
		{
			return null;
		}

		private IEnumerator DelayedClusterCor(RayfireRigid rigid, Collider coll)
		{
			return null;
		}

		private void Activate(RayfireRigid rigid)
		{
		}

		private void RigidRootActivationCheck(Collider coll)
		{
		}

		private IEnumerator DelayedActivationCor(RayfireRigidRoot rigidRoot, Collider coll)
		{
			return null;
		}

		private void ActivateCollider(RayfireRigidRoot rigidRoot, Collider coll)
		{
		}

		private void AddForce(Rigidbody rb)
		{
		}

		public void TriggerAnimation()
		{
		}

		private void SetAnimation()
		{
		}

		private void SetWorldPointsByLine()
		{
		}

		private void SetWorldPointsByLocal()
		{
		}

		private void SetCheckPoints()
		{
		}

		private IEnumerator AnimationCor()
		{
			return null;
		}

		private int GetSegment(float ration)
		{
			return default(int);
		}

		private void ResetData()
		{
		}

		public void StopAnimation()
		{
		}

		public void ResetAnimation()
		{
		}

		public void AddPosition(Vector3 newPos)
		{
		}

		public void SetGizmoType(GizmoType gizmo)
		{
		}

		public RayfireActivator()
			: base()
		{
		}
	}
}
