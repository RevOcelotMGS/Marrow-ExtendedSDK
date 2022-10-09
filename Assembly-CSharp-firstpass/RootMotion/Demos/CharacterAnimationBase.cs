using UnityEngine;

namespace RootMotion.Demos
{
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		public bool smoothFollow;

		public float smoothFollowSpeed;

		protected bool animatePhysics;

		private Vector3 lastPosition;

		private Vector3 localPosition;

		private Quaternion localRotation;

		private Quaternion lastRotation;

		public virtual bool animationGrounded
		{
			get
			{
				return default(bool);
			}
		}

		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		protected virtual void Start()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		private void SmoothFollow()
		{
		}

		public CharacterAnimationBase()
			: base()
		{
		}
	}
}
