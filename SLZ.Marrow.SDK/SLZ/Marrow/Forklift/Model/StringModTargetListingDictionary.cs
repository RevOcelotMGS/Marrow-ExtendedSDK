using System;
using SLZ.Marrow.Utilities;

namespace SLZ.Marrow.Forklift.Model
{
	[Serializable]
	public class StringModTargetListingDictionary : SerializableDictionary<string, ModTarget>
	{
		public StringModTargetListingDictionary()
			: base()
		{
		}
	}
}
