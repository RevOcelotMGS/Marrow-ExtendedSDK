using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[RequireComponent(typeof(Animator))]
	public class RagdollUtility : MonoBehaviour
	{
		public class Rigidbone
		{
			public Rigidbody r;

			public Transform t;

			public Collider collider;

			public Joint joint;

			public Rigidbody c;

			public bool updateAnchor;

			public Vector3 deltaPosition;

			public Quaternion deltaRotation;

			public float deltaTime;

			public Vector3 lastPosition;

			public Quaternion lastRotation;

			public Rigidbone(Rigidbody r)
				: base()
			{
			}

			public void RecordVelocity()
			{
			}

			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		public class Child
		{
			public Transform t;

			public Vector3 localPosition;

			public Quaternion localRotation;

			public Child(Transform transform)
				: base()
			{
			}

			public void FixTransform(float weight)
			{
			}

			public void StoreLocalState()
			{
			}
		}

		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		private Animator animator;

		private Rigidbone[] rigidbones;

		private Child[] children;

		private bool enableRagdollFlag;

		private AnimatorUpdateMode animatorUpdateMode;

		private IK[] allIKComponents;

		private bool[] fixTransforms;

		private float ragdollWeight;

		private float ragdollWeightV;

		private bool fixedFrame;

		private bool[] disabledIKComponents;

		private bool isRagdoll
		{
			get
			{
				return default(bool);
			}
		}

		private bool ikUsed
		{
			get
			{
				return default(bool);
			}
		}

		public void EnableRagdoll()
		{
		}

		public void DisableRagdoll()
		{
		}

		public void Start()
		{
		}

		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void AfterLastIK()
		{
		}

		private void AfterAnimation()
		{
		}

		private void OnFinalPose()
		{
		}

		private void RagdollEnabler()
		{
		}

		private void RecordVelocities()
		{
		}

		private void StoreLocalState()
		{
		}

		private void FixTransforms(float weight)
		{
		}

		private void OnDestroy()
		{
		}

		public RagdollUtility()
			: base()
		{
		}
	}
}
