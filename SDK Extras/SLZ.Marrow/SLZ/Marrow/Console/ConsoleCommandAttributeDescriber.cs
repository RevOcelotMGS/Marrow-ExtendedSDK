using System;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace SLZ.Marrow.Console
{
	[UsedImplicitly]
	internal class ConsoleCommandAttributeDescriber : IObjectDescriber
	{
		public bool CanDescribe(Type type)
		{
			return default(bool);
		}

		public bool TryDescribe(object obj, TokenParseContext context, [Out] ObjectDescription description)
		{
			return default(bool);
		}

		public ConsoleCommandAttributeDescriber()
			: base()
		{
		}
	}
}
