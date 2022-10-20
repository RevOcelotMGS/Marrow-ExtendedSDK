using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	[Serializable]
	public class SerializableDictionary<K, V> : Dictionary<K, V>, ISerializationCallbackReceiver, ISerializableDictionary
	{
		[SerializeField]
		private List<K> _keys;

		[SerializeField]
		private List<V> _values;

		[SerializeField]
		private SerializableType _keyType;

		[SerializeField]
		private SerializableType _valueType;

		public SerializableType KeyType
		{
			get
			{
				return null;
			}
		}

		public SerializableType ValueType
		{
			get
			{
				return null;
			}
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public void AddSafe(K key, V value)
		{
		}

		public SerializableDictionary()
			: base()
		{
		}
	}
}
