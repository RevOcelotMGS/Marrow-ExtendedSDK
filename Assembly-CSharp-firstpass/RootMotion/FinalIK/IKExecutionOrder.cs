using UnityEngine;

namespace RootMotion.FinalIK
{
	public class IKExecutionOrder : MonoBehaviour
	{
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		private bool fixedFrame;

		private bool animatePhysics
		{
			get
			{
				return default(bool);
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixTransforms()
		{
		}

		public IKExecutionOrder()
			: base()
		{
		}
	}
}
