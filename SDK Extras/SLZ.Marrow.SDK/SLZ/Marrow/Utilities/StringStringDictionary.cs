using System;

namespace SLZ.Marrow.Utilities
{
	[Serializable]
	public sealed class StringStringDictionary : SerializableDictionary<string, string>
	{
		public StringStringDictionary()
			: base()
		{
		}
	}
}
