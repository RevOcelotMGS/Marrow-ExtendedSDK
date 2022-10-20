using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Utilities
{
	[Serializable]
	public sealed class StringStringListDictionary : SerializableDictionary<string, List<string>>
	{
		public StringStringListDictionary()
			: base()
		{
		}
	}
}
