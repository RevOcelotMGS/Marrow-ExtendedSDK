using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Plugins
{
	internal class MarrowPluginWrapper
	{
		public MarrowPluginInfo Info { get; internal set; }

		public bool Loaded { get; internal set; }

		public bool Running { get; internal set; }

		public IMarrowPlugin MarrowPlugin { get; internal set; }

		public MarrowPluginWrapper()
			: base()
		{
		}
	}
}
