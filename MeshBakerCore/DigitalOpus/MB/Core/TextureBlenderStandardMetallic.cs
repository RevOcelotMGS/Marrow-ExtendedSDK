using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class TextureBlenderStandardMetallic : TextureBlender
	{
		private enum Prop
		{
			doColor = 0,
			doMetallic = 1,
			doEmission = 2,
			doBump = 3,
			doNone = 4
		}

		private static Color NeutralNormalMap;

		private TextureBlenderMaterialPropertyCacheHelper sourceMaterialPropertyCache;

		private Color m_tintColor;

		private float m_glossiness;

		private float m_glossMapScale;

		private float m_metallic;

		private bool m_hasMetallicGlossMap;

		private float m_bumpScale;

		private bool m_shaderDoesEmission;

		private Color m_emissionColor;

		private Prop propertyToDo;

		private Color m_generatingTintedAtlasColor;

		private float m_generatingTintedAtlasMetallic;

		private float m_generatingTintedAtlasGlossiness;

		private float m_generatingTintedAtlasGlossMapScale;

		private float m_generatingTintedAtlasBumpScale;

		private Color m_generatingTintedAtlasEmission;

		private Color m_notGeneratingAtlasDefaultColor;

		private float m_notGeneratingAtlasDefaultMetallic;

		private float m_notGeneratingAtlasDefaultGlossiness;

		private Color m_notGeneratingAtlasDefaultEmisionColor;

		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
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

		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default(Color);
		}

		public TextureBlenderStandardMetallic()
			: base()
		{
		}
	}
}
