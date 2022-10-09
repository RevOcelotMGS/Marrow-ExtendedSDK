using UnityEngine;

namespace RootMotion
{
	public class InspectorComment : PropertyAttribute
	{
		public string name;

		public string color;

		public InspectorComment(string name)
			: base()
		{
		}

		public InspectorComment(string name, string color)
			: base()
		{
		}
	}
}
