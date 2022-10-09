using UnityEngine;

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitSpline : RotationLimit
	{
		[Range(0f, 180f)]
		public float twistLimit;

		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

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

		public void SetSpline(Keyframe[] keyframes)
		{
		}

		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		public RotationLimitSpline()
			: base()
		{
		}
	}
}
