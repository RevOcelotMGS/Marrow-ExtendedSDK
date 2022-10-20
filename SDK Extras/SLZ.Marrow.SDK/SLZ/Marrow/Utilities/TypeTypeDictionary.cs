using System;

namespace SLZ.Marrow.Utilities
{
	[Serializable]
	public sealed class TypeTypeDictionary : SerializableDictionary<SerializableType, SerializableType>
	{
		public TypeTypeDictionary()
			: base()
		{
		}
	}
}
