using UnityEngine;

namespace RootMotion.Demos
{
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		public Animator animator;

		public MotionAbsorb motionAbsorb;

		public Transform cube;

		public float cubeRandomPosition;

		public AnimationCurve motionAbsorbWeight;

		private Vector3 cubeDefaultPosition;

		private AnimatorStateInfo info;

		private Rigidbody cubeRigidbody;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void SwingStart()
		{
		}

		public MotionAbsorbCharacter()
			: base()
		{
		}
	}
}
