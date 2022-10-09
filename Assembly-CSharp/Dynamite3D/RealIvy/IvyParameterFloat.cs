using System;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public class IvyParameterFloat : IvyParameter
	{
		public IvyParameterFloat(float value)
			: base()
		{
		}

		public override void UpdateValue(float value)
		{
		}

		public static implicit operator float(IvyParameterFloat floatParameter)
		{
			return default(float);
		}

		public static implicit operator IvyParameterFloat(float floatValue)
		{
			return null;
		}
	}
}
