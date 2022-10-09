using System.Collections.Generic;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourDriveController : MonoBehaviour
	{
		[Header("Joint Drive Settings")]
		[Space(10f)]
		private float m_FacingDot;

		[HideInInspector]
		public Dictionary<Transform, ArtBodyPart> bodyPartsDict;

		[HideInInspector]
		public List<ArtBodyPart> bodyPartsList;

		private const float k_MaxAngularVelocity = 50f;

		public float maxJointForceLimit;

		public void SetupBodyPart(Transform t)
		{
		}

		public void SetupBodyPart(Transform t, ConfigurableJoint ref_joint)
		{
		}

		public BehaviourDriveController()
			: base()
		{
		}
	}
}
