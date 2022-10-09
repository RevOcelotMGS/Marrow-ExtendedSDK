using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		public class Partner
		{
			public FullBodyBipedIK ik;

			public Transform mouth;

			public Transform mouthTarget;

			public Transform touchTargetLeftHand;

			public Transform touchTargetRightHand;

			public float bodyWeightHorizontal;

			public float bodyWeightVertical;

			public float neckRotationWeight;

			public float headTiltAngle;

			public Vector3 headTiltAxis;

			private Quaternion neckRotation;

			private Transform neck
			{
				get
				{
					return null;
				}
			}

			public void Initiate()
			{
			}

			public void Update(float weight)
			{
			}

			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			public Partner()
				: base()
			{
			}
		}

		public Partner partner1;

		public Partner partner2;

		public float weight;

		public int iterations;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public KissingRig()
			: base()
		{
		}
	}
}
