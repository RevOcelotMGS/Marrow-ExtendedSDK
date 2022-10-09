using Assets.Marrow_ExtendedSDK.StubClasses;
using System;
using Unity.MLAgents;
using UnityEngine;
using UnityEngine.Serialization;

namespace PuppetMasta
{
	[Serializable]
	public class ArtBodyPart
	{
		[Header("Body Part Info")]
		[Space(10f)]
		public ConfigurableJoint joint;

		public Rigidbody rb;

		[HideInInspector]
		public Vector3 startingPos;

		[HideInInspector]
		public Quaternion startingRot;

		[Space(10f)]
		[Header("Ground & Target Contact")]
		public GroundContact groundContact;

		public TargetContact targetContact;

		[FormerlySerializedAs("thisJDController")]
		[HideInInspector]
		public BehaviourDriveController thisJdController;

		[Header("Current Joint Settings")]
		[Space(10f)]
		public Vector3 currentEularJointRotation;

		[HideInInspector]
		public float currentStrength;

		public float currentXNormalizedRot;

		public float currentYNormalizedRot;

		public float currentZNormalizedRot;

		public void Reset(ArtBodyPart bp)
		{
		}

		public void SetArtTargetRotation(Transform transform, float x, float y, float z, float lowX, float highX, float lowY, float highY, float lowZ, float highZ)
		{
		}

		public ArtBodyPart()
			: base()
		{
		}
	}
}
