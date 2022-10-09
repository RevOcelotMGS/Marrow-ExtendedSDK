using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithCalApplicationSuggestionList : Message<CalApplicationSuggestionList>
	{
		public MessageWithCalApplicationSuggestionList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override CalApplicationSuggestionList GetCalApplicationSuggestionList()
		{
			return null;
		}

		protected override CalApplicationSuggestionList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
