using System;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class Weight
	{
		[Serializable]
		public enum Mode
		{
			Float = 0,
			Curve = 1
		}

		public Mode mode;

		public float floatValue;

		public AnimationCurve curve;

		public string tooltip;

		public Weight(float floatValue)
			: base()
		{
		}

		public Weight(float floatValue, string tooltip)
			: base()
		{
		}

		public float GetValue(float param)
		{
			return default(float);
		}
	}
}
