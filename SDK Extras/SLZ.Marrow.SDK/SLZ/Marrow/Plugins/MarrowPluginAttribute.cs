using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace SLZ.Marrow.Plugins
{
	[AttributeUsage(AttributeTargets.Class)]
	[RequireAttributeUsages]
	public class MarrowPluginAttribute : Attribute
	{
		public string Namespace { get; private set; }

		public string Name { get; private set; }

		public string Version { get; private set; }

		public MarrowPluginAttribute(string Namespace, string Name, string Version = "0.0.1-UNKNOWN")
			: base()
		{
		}
	}
}
