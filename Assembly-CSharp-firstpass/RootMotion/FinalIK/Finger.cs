using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class Finger
	{
		[Serializable]
		public enum DOF
		{
			One = 0,
			Three = 1
		}

		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		private IKSolverLimb solver;

		private Quaternion bone3RelativeToTarget;

		private Vector3 bone3DefaultLocalPosition;

		private Quaternion bone3DefaultLocalRotation;

		private Vector3 bone1Axis;

		private Vector3 tipAxis;

		public bool initiated { get; private set; }

		public Vector3 IKPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion IKRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public bool IsValid(string errorMessage)
		{
			return default(bool);
		}

		public void Initiate(Transform hand, int index)
		{
		}

		public void FixTransforms()
		{
		}

		public void StoreDefaultLocalState()
		{
		}

		public void Update(float masterWeight)
		{
		}

		public Finger()
			: base()
		{
		}
	}
}
