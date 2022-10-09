using System;

namespace MK.Glow
{
	[Serializable]
	public struct MinMaxRange
	{
		public float minValue;

		public float maxValue;

		public MinMaxRange(float minValue, float maxValue)
		{
			this.maxValue = default(float);
			this.minValue = default(float);
		}
	}
}
