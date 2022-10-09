using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		public CharacterThirdPerson characterController;

		[SerializeField]
		private float turnSensitivity;

		[SerializeField]
		private float turnSpeed;

		[SerializeField]
		private float runCycleLegOffset;

		[Range(0.1f, 3f)]
		[SerializeField]
		private float animSpeedMultiplier;

		protected Animator animator;

		private Vector3 lastForward;

		private const string groundedDirectional = "Grounded Directional";

		private const string groundedStrafe = "Grounded Strafe";

		private float deltaAngle;

		public override bool animationGrounded
		{
			get
			{
				return default(bool);
			}
		}

		protected override void Start()
		{
		}

		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		protected virtual void Update()
		{
		}

		private void OnAnimatorMove()
		{
		}

		public CharacterAnimationThirdPerson()
			: base()
		{
		}
	}
}
