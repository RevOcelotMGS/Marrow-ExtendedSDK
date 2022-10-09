using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class AimSwing : MonoBehaviour
	{
		public AimIK ik;

		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		private void LateUpdate()
		{
		}

		public AimSwing()
			: base()
		{
		}
	}
}
