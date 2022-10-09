using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class MB3_TextureCombinerNonTextureProperties
	{
		public interface MaterialProperty
		{
			string PropertyName { get; set; }

			MaterialPropertyValueAveraged GetAverageCalculator();

			object GetDefaultValue();
		}

		public class MaterialPropertyFloat : MaterialProperty
		{
			private MaterialPropertyValueAveragedFloat _averageCalc;

			private float _defaultValue;

			public string PropertyName { get; set; }

			public MaterialPropertyFloat(string name, float defValue)
				: base()
			{
			}

			public MaterialPropertyValueAveraged GetAverageCalculator()
			{
				return null;
			}

			public object GetDefaultValue()
			{
				return null;
			}
		}

		public class MaterialPropertyColor : MaterialProperty
		{
			private MaterialPropertyValueAveragedColor _averageCalc;

			private Color _defaultValue;

			public string PropertyName { get; set; }

			public MaterialPropertyColor(string name, Color defaultVal)
				: base()
			{
			}

			public MaterialPropertyValueAveraged GetAverageCalculator()
			{
				return null;
			}

			public object GetDefaultValue()
			{
				return null;
			}
		}

		public interface MaterialPropertyValueAveraged
		{
			void TryGetPropValueFromMaterialAndBlendIntoAverage(Material mat, MaterialProperty property);

			object GetAverage();

			int NumValues();

			void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property);
		}

		public class MaterialPropertyValueAveragedFloat : MaterialPropertyValueAveraged
		{
			public float averageVal;

			public int numValues;

			public void TryGetPropValueFromMaterialAndBlendIntoAverage(Material mat, MaterialProperty property)
			{
			}

			public object GetAverage()
			{
				return null;
			}

			public int NumValues()
			{
				return default(int);
			}

			public void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property)
			{
			}

			public MaterialPropertyValueAveragedFloat()
				: base()
			{
			}
		}

		public class MaterialPropertyValueAveragedColor : MaterialPropertyValueAveraged
		{
			public Color averageVal;

			public int numValues;

			public void TryGetPropValueFromMaterialAndBlendIntoAverage(Material mat, MaterialProperty property)
			{
			}

			public object GetAverage()
			{
				return null;
			}

			public int NumValues()
			{
				return default(int);
			}

			public void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property)
			{
			}

			public MaterialPropertyValueAveragedColor()
				: base()
			{
			}
		}

		public struct TexPropertyNameColorPair
		{
			public string name;

			public Color color;

			public TexPropertyNameColorPair(string nm, Color col)
			{
				this.color = default(Color);
				this.name = default(string);
			}
		}

		private interface NonTextureProperties
		{
			bool NonTexturePropertiesAreEqual(Material a, Material b);

			Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName);

			void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, MB2_EditorMethodsInterface editorMethods);

			Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty);

			Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty);
		}

		private class NonTexturePropertiesDontBlendProps : NonTextureProperties
		{
			private MB3_TextureCombinerNonTextureProperties _textureProperties;

			public NonTexturePropertiesDontBlendProps(MB3_TextureCombinerNonTextureProperties textureProperties)
				: base()
			{
			}

			public bool NonTexturePropertiesAreEqual(Material a, Material b)
			{
				return default(bool);
			}

			public Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
			{
				return null;
			}

			public void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, MB2_EditorMethodsInterface editorMethods)
			{
			}

			public Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
			{
				return default(Color);
			}

			public Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty)
			{
				return default(Color);
			}
		}

		private class NonTexturePropertiesBlendProps : NonTextureProperties
		{
			private MB3_TextureCombinerNonTextureProperties _textureProperties;

			private TextureBlender resultMaterialTextureBlender;

			public NonTexturePropertiesBlendProps(MB3_TextureCombinerNonTextureProperties textureProperties, TextureBlender resultMats)
				: base()
			{
			}

			public bool NonTexturePropertiesAreEqual(Material a, Material b)
			{
				return default(bool);
			}

			public Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
			{
				return null;
			}

			public void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, MB2_EditorMethodsInterface editorMethods)
			{
			}

			public Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
			{
				return default(Color);
			}

			public Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty)
			{
				return default(Color);
			}
		}

		public static Color NEUTRAL_NORMAL_MAP_COLOR;

		private TexPropertyNameColorPair[] defaultTextureProperty2DefaultColorMap;

		private MaterialProperty[] _nonTextureProperties;

		private MB2_LogLevel LOG_LEVEL;

		private bool _considerNonTextureProperties;

		private TextureBlender resultMaterialTextureBlender;

		private TextureBlender[] textureBlenders;

		private Dictionary<string, Color> textureProperty2DefaultColorMap;

		private NonTextureProperties _nonTexturePropertiesBlender;

		public MB3_TextureCombinerNonTextureProperties(MB2_LogLevel ll, bool considerNonTextureProps)
			: base()
		{
		}

		internal void CollectAverageValuesOfNonTextureProperties(Material resultMaterial, Material mat)
		{
		}

		internal void LoadTextureBlendersIfNeeded(Material resultMaterial)
		{
		}

		private static bool InterfaceFilter(Type typeObj, object criteriaObj)
		{
			return default(bool);
		}

		private void FindBestTextureBlender(Material resultMaterial)
		{
		}

		private void LoadTextureBlenders()
		{
		}

		internal bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		internal Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
		{
			return null;
		}

		internal void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, MB2_EditorMethodsInterface editorMethods)
		{
		}

		internal Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
		{
			return default(Color);
		}

		internal Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty)
		{
			return default(Color);
		}

		private TextureBlender FindMatchingTextureBlender(string shaderName)
		{
			return null;
		}
	}
}
