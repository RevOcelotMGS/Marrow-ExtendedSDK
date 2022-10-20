using System;

namespace SLZ.Marrow.Plugins.Tests
{
	[AttributeUsage(AttributeTargets.Class)]
	public class MarrowTestMarrowPluginAttribute : MarrowPluginAttribute
	{
		public MarrowTestMarrowPluginAttribute(string Namespace, string Name, string Version = "0.0.1-UNKNOWN")
			: base(Namespace, Name, Version)
		{
		}
	}
}
