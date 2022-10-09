using System.Collections.Generic;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class TextureBlenderMaterialPropertyCacheHelper
	{
		private struct MaterialPropertyPair
		{
			public Material material;

			public string property;

			public MaterialPropertyPair(Material m, string prop)
			{
				this.property = default(string);
				this.material = default(Material);
			}

			public override bool Equals(object obj)
			{
				return default(bool);
			}

			public override int GetHashCode()
			{
				return default(int);
			}
		}

		private Dictionary<MaterialPropertyPair, object> nonTexturePropertyValuesForSourceMaterials;

		private bool AllNonTexturePropertyValuesAreEqual(string prop)
		{
			return default(bool);
		}

		public void CacheMaterialProperty(Material m, string property, object value)
		{
		}

		public object GetValueIfAllSourceAreTheSameOrDefault(string property, object defaultValue)
		{
			return null;
		}

		public TextureBlenderMaterialPropertyCacheHelper()
			: base()
		{
		}
	}
}
