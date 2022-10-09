using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SLZ.Marrow.Console
{
	public class ConsoleCommandWrapperConverter : IObjectDescriber, ITokenConverter<ConsoleCommandWrapper>
	{
		public bool CanDescribe(Type type)
		{
			return default(bool);
		}

		public bool TryDescribe(object obj, TokenParseContext context, [Out] ObjectDescription description)
		{
			return default(bool);
		}

		public bool CanConvert(Type type)
		{
			return default(bool);
		}

		public IEnumerable<ConsoleCommandWrapper> Convert(string token, TokenParseContext context)
		{
			return null;
		}

		public TokenSuggestions<ConsoleCommandWrapper> SuggestConversions(string partialOrEmptyToken, TokenParseContext context)
		{
			return null;
		}

		public ConsoleCommandWrapperConverter()
			: base()
		{
		}
	}
}
