using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class TextureBlenderFallback : TextureBlender
	{
		private bool m_doTintColor;

		private Color m_tintColor;

		private Color m_defaultColor;

		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		public Color OnBlendTexturePixel(string shaderPropertyName, Color pixelColor)
		{
			return default(Color);
		}

		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texProperty)
		{
			return default(Color);
		}

		public static bool _compareColor(Material a, Material b, Color defaultVal, string propertyName)
		{
			return default(bool);
		}

		public static bool _compareFloat(Material a, Material b, float defaultVal, string propertyName)
		{
			return default(bool);
		}

		public TextureBlenderFallback()
			: base()
		{
		}
	}
}
