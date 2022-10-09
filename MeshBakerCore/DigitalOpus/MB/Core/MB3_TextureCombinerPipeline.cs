using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class MB3_TextureCombinerPipeline
	{
		public struct CreateAtlasForProperty
		{
			public bool allTexturesAreNull;

			public bool allTexturesAreSame;

			public bool allNonTexturePropsAreSame;

			public bool allSrcMatsOmittedTextureProperty;

			public override string ToString()
			{
				return null;
			}
		}

		internal class TexturePipelineData
		{
			internal MB2_TextureBakeResults _textureBakeResults;

			internal int _atlasPadding;

			internal int _maxAtlasWidth;

			internal int _maxAtlasHeight;

			internal bool _useMaxAtlasHeightOverride;

			internal bool _useMaxAtlasWidthOverride;

			internal bool _resizePowerOfTwoTextures;

			internal bool _fixOutOfBoundsUVs;

			internal int _maxTilingBakeSize;

			internal bool _saveAtlasesAsAssets;

			internal MB2_PackingAlgorithmEnum _packingAlgorithm;

			internal int _layerTexturePackerFastV2;

			internal bool _meshBakerTexturePackerForcePowerOfTwo;

			internal List<ShaderTextureProperty> _customShaderPropNames;

			internal bool _normalizeTexelDensity;

			internal bool _considerNonTextureProperties;

			internal bool doMergeDistinctMaterialTexturesThatWouldExceedAtlasSize;

			internal ColorSpace colorSpace;

			internal MB3_TextureCombinerNonTextureProperties nonTexturePropertyBlender;

			internal List<MB_TexSet> distinctMaterialTextures;

			internal List<GameObject> allObjsToMesh;

			internal List<Material> allowedMaterialsFilter;

			internal List<ShaderTextureProperty> texPropertyNames;

			internal CreateAtlasForProperty[] allTexturesAreNullAndSameColor;

			internal MB2_TextureBakeResults.ResultType resultType;

			internal Material resultMaterial;

			internal int numAtlases
			{
				get
				{
					return default(int);
				}
			}

			internal bool OnlyOneTextureInAtlasReuseTextures()
			{
				return default(bool);
			}

			public TexturePipelineData()
				: base()
			{
			}
		}

		public static bool USE_EXPERIMENTAL_HOIZONTALVERTICAL;

		public static ShaderTextureProperty[] shaderTexPropertyNames;

		internal static bool _ShouldWeCreateAtlasForThisProperty(int propertyIndex, bool considerNonTextureProperties, CreateAtlasForProperty[] allTexturesAreNullAndSameColor)
		{
			return default(bool);
		}

		internal static bool _DoAnySrcMatsHaveProperty(int propertyIndex, CreateAtlasForProperty[] allTexturesAreNullAndSameColor)
		{
			return default(bool);
		}

		internal static bool _CollectPropertyNames(TexturePipelineData data, MB2_LogLevel LOG_LEVEL)
		{
			return default(bool);
		}

		internal static bool _CollectPropertyNames(List<ShaderTextureProperty> texPropertyNames, List<ShaderTextureProperty> _customShaderPropNames, Material resultMaterial, MB2_LogLevel LOG_LEVEL)
		{
			return default(bool);
		}

		public static Texture GetTextureConsideringStandardShaderKeywords(string shaderName, Material mat, string propertyName)
		{
			return null;
		}

		internal virtual IEnumerator __Step1_CollectDistinctMatTexturesAndUsedObjects(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, List<GameObject> usedObjsToMesh, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		private static CreateAtlasForProperty[] CalculateAllTexturesAreNullAndSameColor(TexturePipelineData data, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		internal virtual IEnumerator CalculateIdealSizesForTexturesInAtlasAndPadding(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		internal virtual AtlasPackingResult[] RunTexturePackerOnly(TexturePipelineData data, bool doSplitIntoMultiAtlasIfTooBig, MB_AtlasesAndRects resultAtlasesAndRects, MB_ITextureCombinerPacker texturePacker, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		internal virtual MB_ITextureCombinerPacker CreatePacker(bool onlyOneTextureInAtlasReuseTextures, MB2_PackingAlgorithmEnum packingAlgorithm)
		{
			return null;
		}

		internal virtual IEnumerator __Step3_BuildAndSaveAtlasesAndStoreResults(MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, ProgressUpdateDelegate progressInfo, TexturePipelineData data, MB3_TextureCombiner combiner, MB_ITextureCombinerPacker packer, AtlasPackingResult atlasPackingResult, MB2_EditorMethodsInterface textureEditorMethods, MB_AtlasesAndRects resultAtlasesAndRects, StringBuilder report, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		private void FillAtlasPackingResultAuxillaryData(TexturePipelineData data, AtlasPackingResult[] atlasPackingResults)
		{
		}

		private void FillResultAtlasesAndRects(TexturePipelineData data, AtlasPackingResult atlasPackingResult, MB_AtlasesAndRects resultAtlasesAndRects, Texture2D[] atlases)
		{
		}

		internal virtual StringBuilder GenerateReport(TexturePipelineData data)
		{
			return null;
		}

		internal static MB2_TexturePacker CreateTexturePacker(MB2_PackingAlgorithmEnum _packingAlgorithm)
		{
			return null;
		}

		internal static Vector2 GetAdjustedForScaleAndOffset2Dimensions(MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, TexturePipelineData data, MB2_LogLevel LOG_LEVEL)
		{
			return default(Vector2);
		}

		internal static Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
		{
			return default(Color32);
		}

		internal static void GetMaterialScaleAndOffset(Material mat, string propertyName, [Out] Vector2 offset, [Out] Vector2 scale)
		{
		}

		internal static float GetSubmeshArea(Mesh m, int submeshIdx)
		{
			return default(float);
		}

		internal static bool IsPowerOfTwo(int x)
		{
			return default(bool);
		}

		public MB3_TextureCombinerPipeline()
			: base()
		{
		}
	}
}
