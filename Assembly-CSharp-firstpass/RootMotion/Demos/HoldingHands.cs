using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class HoldingHands : MonoBehaviour
	{
		public FullBodyBipedIK rightHandChar;

		public FullBodyBipedIK leftHandChar;

		public Transform rightHandTarget;

		public Transform leftHandTarget;

		public float crossFade;

		public float speed;

		private Quaternion rightHandRotation;

		private Quaternion leftHandRotation;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public HoldingHands()
			: base()
		{
		}
	}
}
