using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Console
{
	public interface ITokenConverter<out T>
	{
		bool CanConvert(Type type);

		IEnumerable<T> Convert(string token, TokenParseContext context);
	}
}
