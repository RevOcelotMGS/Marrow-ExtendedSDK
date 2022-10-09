using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	public class ShaderTextureProperty
	{
		public string name;

		public bool isNormalMap;

		[HideInInspector]
		public bool isNormalDontKnow;

		public ShaderTextureProperty(string n, bool norm)
			: base()
		{
		}

		public ShaderTextureProperty(string n, bool norm, bool isNormalDontKnow)
			: base()
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public static string[] GetNames(List<ShaderTextureProperty> props)
		{
			return null;
		}
	}
}
