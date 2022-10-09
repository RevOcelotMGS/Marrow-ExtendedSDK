using UnityEngine;

namespace RootMotion
{
	public class LargeHeader : PropertyAttribute
	{
		public string name;

		public string color;

		public LargeHeader(string name)
			: base()
		{
		}

		public LargeHeader(string name, string color)
			: base()
		{
		}
	}
}
