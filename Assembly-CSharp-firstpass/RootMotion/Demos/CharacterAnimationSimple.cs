using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[SerializeField]
		private CharacterThirdPerson characterController;

		[SerializeField]
		private float pivotOffset;

		[SerializeField]
		private AnimationCurve moveSpeed;

		private Animator animator;

		protected override void Start()
		{
		}

		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		private void Update()
		{
		}

		public CharacterAnimationSimple()
			: base()
		{
		}
	}
}
