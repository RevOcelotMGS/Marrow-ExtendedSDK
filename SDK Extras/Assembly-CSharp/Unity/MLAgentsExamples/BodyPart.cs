using Assets.Marrow_ExtendedSDK.StubClasses;
using System;
using Unity.MLAgents;
using UnityEngine;
using UnityEngine.Serialization;

namespace Unity.MLAgentsExamples
{
	[Serializable]
	public class BodyPart
	{
		[Space(10f)]
		[Header("Body Part Info")]
		public ConfigurableJoint joint;

		public Rigidbody rb;

		[HideInInspector]
		public Vector3 startingPos;

		[HideInInspector]
		public Quaternion startingRot;

		[Header("Ground & Target Contact")]
		[Space(10f)]
		public GroundContact groundContact;

		public TargetContact targetContact;

		[FormerlySerializedAs("thisJDController")]
		[HideInInspector]
		public JointDriveController thisJdController;

		[Space(10f)]
		[Header("Current Joint Settings")]
		public Vector3 currentEularJointRotation;

		[HideInInspector]
		public float currentStrength;

		public float currentXNormalizedRot;

		public float currentYNormalizedRot;

		public float currentZNormalizedRot;

		[Header("Other Debug Info")]
		[Space(10f)]
		public Vector3 currentJointForce;

		public float currentJointForceSqrMag;

		public Vector3 currentJointTorque;

		public float currentJointTorqueSqrMag;

		public AnimationCurve jointForceCurve;

		public AnimationCurve jointTorqueCurve;

		public void Reset(BodyPart bp)
		{
		}

		public void SetJointTargetRotation(float x, float y, float z)
		{
		}

		public void SetJointStrength(float strength)
		{
		}

		public BodyPart()
			: base()
		{
		}
	}
}
