using System;

namespace SLZ.Marrow.Plugins
{
	[AttributeUsage(AttributeTargets.Method)]
	public class MarrowPluginRegisterMethodAttribute : Attribute
	{
		public MarrowPluginRegisterMethodAttribute()
			: base()
		{
		}
	}
}
