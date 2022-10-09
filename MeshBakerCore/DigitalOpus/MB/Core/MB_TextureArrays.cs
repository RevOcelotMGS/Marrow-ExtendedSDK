using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class MB_TextureArrays
	{
		internal class TexturePropertyData
		{
			public bool[] doMips;

			public int[] numMipMaps;

			public TextureFormat[] formats;

			public Vector2[] sizes;

			public TexturePropertyData()
				: base()
			{
			}
		}

		internal static bool[] DetermineWhichPropertiesHaveTextures(MB_AtlasesAndRects[] resultAtlasesAndRectSlices)
		{
			return null;
		}

		private static bool IsLinearProperty(List<ShaderTextureProperty> shaderPropertyNames, string shaderProperty)
		{
			return default(bool);
		}

		internal static Texture2DArray[] CreateTextureArraysForResultMaterial(TexturePropertyData texPropertyData, List<ShaderTextureProperty> masterListOfTexProperties, MB_AtlasesAndRects[] resultAtlasesAndRectSlices, bool[] hasTexForProperty, MB3_TextureCombiner combiner, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		internal static bool ConvertTexturesToReadableFormat(TexturePropertyData texturePropertyData, MB_AtlasesAndRects[] resultAtlasesAndRectSlices, bool[] hasTexForProperty, List<ShaderTextureProperty> textureShaderProperties, MB3_TextureCombiner combiner, MB2_LogLevel logLevel, List<Texture2D> createdTemporaryTextureAssets, MB2_EditorMethodsInterface textureEditorMethods)
		{
			return default(bool);
		}

		internal static void FindBestSizeAndMipCountAndFormatForTextureArrays(List<ShaderTextureProperty> texPropertyNames, int maxAtlasSize, MB_TextureArrayFormatSet targetFormatSet, MB_AtlasesAndRects[] resultAtlasesAndRectSlices, TexturePropertyData texturePropertyData)
		{
		}

		public static IEnumerator _CreateAtlasesCoroutineSingleResultMaterial(int resMatIdx, MB_TextureArrayResultMaterial bakedMatsAndSlicesResMat, MB_MultiMaterialTexArray resMatConfig, List<GameObject> objsToMesh, MB3_TextureCombiner combiner, MB_TextureArrayFormatSet[] textureArrayOutputFormats, MB_MultiMaterialTexArray[] resultMaterialsTexArray, List<ShaderTextureProperty> customShaderProperties, ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult, bool saveAtlasesAsAssets = false, MB2_EditorMethodsInterface editorMethods = default(MB2_EditorMethodsInterface), float maxTimePerFrame = 0.01f)
		{
			return null;
		}

		public MB_TextureArrays()
			: base()
		{
		}
	}
}
