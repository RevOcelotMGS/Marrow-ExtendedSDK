using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public class InspectorDisplayNameAttribute : PropertyAttribute
	{
		public string NewName { get; private set; }

		public InspectorDisplayNameAttribute(string name)
			: base()
		{
		}
	}
}
