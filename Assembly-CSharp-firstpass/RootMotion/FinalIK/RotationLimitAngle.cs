using UnityEngine;

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitAngle : RotationLimit
	{
		[Range(0f, 180f)]
		public float limit;

		[Range(0f, 180f)]
		public float twistLimit;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		public RotationLimitAngle()
			: base()
		{
		}
	}
}
