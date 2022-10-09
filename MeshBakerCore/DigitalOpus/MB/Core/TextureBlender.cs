using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public interface TextureBlender
	{
		bool DoesShaderNameMatch(string shaderName);

		void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName);

		Color OnBlendTexturePixel(string shaderPropertyName, Color pixelColor);

		bool NonTexturePropertiesAreEqual(Material a, Material b);

		void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial);

		Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName);
	}
}
