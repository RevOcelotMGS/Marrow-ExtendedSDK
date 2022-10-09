using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(Animator))]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		public float rotateSpeed;

		public float blendSpeed;

		public float maxAngle;

		public float moveSpeed;

		public float rootMotionWeight;

		protected Animator animator;

		protected Vector3 moveBlend;

		protected Vector3 moveInput;

		protected Vector3 velocity;

		protected virtual void Start()
		{
		}

		private void OnAnimatorMove()
		{
		}

		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		public AnimatorController3rdPerson()
			: base()
		{
		}
	}
}
