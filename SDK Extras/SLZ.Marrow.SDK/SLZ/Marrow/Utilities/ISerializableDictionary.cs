namespace SLZ.Marrow.Utilities
{
	public interface ISerializableDictionary
	{
		SerializableType KeyType { get; }

		SerializableType ValueType { get; }
	}
}
