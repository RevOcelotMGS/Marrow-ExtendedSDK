using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Console
{
	public class TokenParseContext
	{
		public readonly HashSet<ConsoleCommandWrapper> EligibleCommands;

		public readonly Type[] ExpectedTypes;

		public readonly int SoftSuggestionLimit;

		public TokenParseContext(int softSuggestionLimit = 20, params Type[] expectedTypes)
			: base()
		{
		}
	}
}
