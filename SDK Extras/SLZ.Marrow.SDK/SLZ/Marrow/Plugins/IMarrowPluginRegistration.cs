using System;

namespace SLZ.Marrow.Plugins
{
	public interface IMarrowPluginRegistration
	{
		Type PluginType { get; }

		MarrowPluginAttribute MarrowPluginAttribute { get; }

		void AddDependency(string qualifiedName);
	}
}
