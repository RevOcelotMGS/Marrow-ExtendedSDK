using System;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Plugins
{
	internal class MarrowPluginInfo : IEquatable<MarrowPluginInfo>
	{
		public string Namespace { get; }

		public string Name { get; }

		public string Version { get; }

		public string QualifiedName
		{
			get
			{
				return null;
			}
		}

		public MarrowPluginInfo(string @namespace, string name, string version)
			: base()
		{
		}

		public override string ToString()
		{
			return null;
		}

		bool IEquatable<MarrowPluginInfo>.Equals(MarrowPluginInfo other)
		{
			return default(bool);
		}

		public override bool Equals(object other)
		{
			return default(bool);
		}

		public static bool operator ==(MarrowPluginInfo lhs, MarrowPluginInfo rhs)
		{
			return default(bool);
		}

		public static bool operator !=(MarrowPluginInfo lhs, MarrowPluginInfo rhs)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
