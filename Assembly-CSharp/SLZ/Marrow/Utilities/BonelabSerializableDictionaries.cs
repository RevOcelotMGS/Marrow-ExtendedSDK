using System;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public class BonelabSerializableDictionaries : MonoBehaviour
	{
		[Serializable]
		public class StringAvatarDictionary : SerializableDictionary<string, SLZ.VRMK.Avatar>
		{
			public StringAvatarDictionary()
				: base()
			{
			}
		}

		public BonelabSerializableDictionaries()
			: base()
		{
		}
	}
}
