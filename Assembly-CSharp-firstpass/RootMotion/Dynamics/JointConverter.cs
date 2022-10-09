using UnityEngine;

namespace RootMotion.Dynamics
{
	public static class JointConverter
	{
		public static void ToConfigurable(GameObject root)
		{
		}

		public static void HingeToConfigurable(HingeJoint src)
		{
		}

		public static void FixedToConfigurable(FixedJoint src)
		{
		}

		public static void SpringToConfigurable(SpringJoint src)
		{
		}

		public static void CharacterToConfigurable(CharacterJoint src)
		{
		}

		private static void ConvertJoint(ConfigurableJoint conf, Joint src)
		{
		}

		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimitSpring);
		}

		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			return default(SoftJointLimit);
		}

		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			return default(SoftJointLimitSpring);
		}
	}
}
