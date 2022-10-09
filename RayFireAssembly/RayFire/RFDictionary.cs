using System;
using System.Collections.Generic;

namespace RayFire
{
	[Serializable]
	public class RFDictionary
	{
		public List<int> keys;

		public List<int> values;

		public RFDictionary(Dictionary<int, int> dictionary)
			: base()
		{
		}
	}
}
