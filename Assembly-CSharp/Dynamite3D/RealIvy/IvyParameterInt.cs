using System;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public class IvyParameterInt : IvyParameter
	{
		public IvyParameterInt(int value)
			: base()
		{
		}

		public override void UpdateValue(float value)
		{
		}

		public static implicit operator int(IvyParameterInt intParameter)
		{
			return default(int);
		}

		public static implicit operator IvyParameterInt(int intValue)
		{
			return null;
		}
	}
}
