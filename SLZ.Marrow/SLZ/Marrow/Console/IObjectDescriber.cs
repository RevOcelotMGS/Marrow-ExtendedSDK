using System;
using System.Runtime.InteropServices;

namespace SLZ.Marrow.Console
{
	public interface IObjectDescriber
	{
		bool CanDescribe(Type type);

		bool TryDescribe(object obj, TokenParseContext context, [Out] ObjectDescription description);
	}
}
