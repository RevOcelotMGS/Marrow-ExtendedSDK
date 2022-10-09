using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Plugins
{
	internal class MarrowPluginRegistrationImpl : IMarrowPluginRegistration
	{
		public Type PluginType { get; internal set; }

		public MarrowPluginAttribute MarrowPluginAttribute { get; internal set; }

		public HashSet<string> Dependencies { get; internal set; }

		public void AddDependency(string qualifiedName)
		{
		}

		public MarrowPluginRegistrationImpl()
			: base()
		{
		}
	}
}
