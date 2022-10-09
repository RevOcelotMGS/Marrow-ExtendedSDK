using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Console
{
	public class TokenSuggestions<TSuggestionContext>
	{
		[TupleElementNames(new string[] { "context", "token" })]
		public List<ValueTuple<TSuggestionContext, string>> ExactMatches { get; }

		[TupleElementNames(new string[] { null, "token" })]
		public List<ValueTuple<TSuggestionContext, string>> PossibleMatches { get; }

		[TupleElementNames(new string[] { null, "token" })]
		public List<ValueTuple<TSuggestionContext, string>> Suggestions { get; }

		public TokenSuggestions()
			: base()
		{
		}
	}
}
