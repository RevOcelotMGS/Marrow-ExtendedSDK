using UnityEngine;

namespace RootMotion.FinalIK
{
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		public bool useLimits;

		public float min;

		public float max;

		[HideInInspector]
		public float zeroAxisDisplayOffset;

		private Quaternion lastRotation;

		private float lastAngle;

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

		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		public RotationLimitHinge()
			: base()
		{
		}
	}
}
