using System;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	[Serializable]
	public sealed class SerializableType : ISerializationCallbackReceiver
	{
		private Type _type;

		[SerializeField]
		private string _typeString;

		[SerializeField]
		private string _typeName;

		public Type Type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SerializableType(Type type)
			: base()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public static Type TypeFromString(string text)
		{
			return null;
		}

		public static implicit operator Type(SerializableType serializableType)
		{
			return null;
		}

		public static implicit operator SerializableType(Type type)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
}
