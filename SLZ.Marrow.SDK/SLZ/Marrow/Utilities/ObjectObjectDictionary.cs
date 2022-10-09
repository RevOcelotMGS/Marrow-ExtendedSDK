using System;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	[Serializable]
	public sealed class ObjectObjectDictionary : SerializableDictionary<UnityEngine.Object, UnityEngine.Object>
	{
		public ObjectObjectDictionary()
			: base()
		{
		}
	}
}
