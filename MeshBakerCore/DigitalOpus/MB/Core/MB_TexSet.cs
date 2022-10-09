using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class MB_TexSet
	{
		private interface PipelineVariation
		{
			void GetRectsForTextureBakeResults([Out] Rect allPropsUseSameTiling_encapsulatingSamplingRect, [Out] Rect propsUseDifferntTiling_obUVRect);

			void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment);

			Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex);

			void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props);
		}

		private class PipelineVariationAllTexturesUseSameMatTiling : PipelineVariation
		{
			private MB_TexSet texSet;

			public PipelineVariationAllTexturesUseSameMatTiling(MB_TexSet ts)
				: base()
			{
			}

			public void GetRectsForTextureBakeResults([Out] Rect allPropsUseSameTiling_encapsulatingSamplingRect, [Out] Rect propsUseDifferntTiling_obUVRect)
			{
			}

			public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
			{
			}

			public Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
			{
				return default(Rect);
			}

			public void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props)
			{
			}
		}

		private class PipelineVariationSomeTexturesUseDifferentMatTiling : PipelineVariation
		{
			private MB_TexSet texSet;

			public PipelineVariationSomeTexturesUseDifferentMatTiling(MB_TexSet ts)
				: base()
			{
			}

			public void GetRectsForTextureBakeResults([Out] Rect allPropsUseSameTiling_encapsulatingSamplingRect, [Out] Rect propsUseDifferntTiling_obUVRect)
			{
			}

			public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
			{
			}

			public Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
			{
				return default(Rect);
			}

			public void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props)
			{
			}
		}

		public MeshBakerMaterialTexture[] ts;

		public MatsAndGOs matsAndGOs;

		public int idealWidth;

		public int idealHeight;

		private PipelineVariation pipelineVariation;

		public bool allTexturesUseSameMatTiling { get; private set; }

		public bool thisIsOnlyTexSetInAtlas { get; private set; }

		public MB_TextureTilingTreatment tilingTreatment { get; private set; }

		public Vector2 obUVoffset { get; private set; }

		public Vector2 obUVscale { get; private set; }

		internal DRect obUVrect
		{
			get
			{
				return default(DRect);
			}
		}

		public MB_TexSet(MeshBakerMaterialTexture[] tss, Vector2 uvOffset, Vector2 uvScale, MB_TextureTilingTreatment treatment)
			: base()
		{
		}

		internal bool IsEqual(object obj, bool fixOutOfBoundsUVs, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender)
		{
			return default(bool);
		}

		public Vector2 GetMaxRawTextureHeightWidth()
		{
			return default(Vector2);
		}

		private Rect GetEncapsulatingSamplingRectIfTilingSame()
		{
			return default(Rect);
		}

		public void SetEncapsulatingSamplingRectWhenMergingTexSets(DRect newEncapsulatingSamplingRect)
		{
		}

		public void SetEncapsulatingSamplingRectForTesting(int propIdx, DRect newEncapsulatingSamplingRect)
		{
		}

		public void SetEncapsulatingRect(int propIdx, bool considerMeshUVs)
		{
		}

		public void CreateColoredTexToReplaceNull(string propName, int propIdx, bool considerMeshUVs, MB3_TextureCombiner combiner, Color col, bool isLinear)
		{
		}

		public void SetThisIsOnlyTexSetInAtlasTrue()
		{
		}

		public void SetAllTexturesUseSameMatTilingTrue()
		{
		}

		public void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props)
		{
		}

		public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
		{
		}

		internal void GetRectsForTextureBakeResults([Out] Rect allPropsUseSameTiling_encapsulatingSamplingRect, [Out] Rect propsUseDifferntTiling_obUVRect)
		{
		}

		internal Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
		{
			return default(Rect);
		}

		internal void CalcInitialFullSamplingRects(bool fixOutOfBoundsUVs)
		{
		}

		internal void CalcMatAndUVSamplingRects()
		{
		}

		public bool AllTexturesAreSameForMerge(MB_TexSet other, bool considerNonTextureProperties, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender)
		{
			return default(bool);
		}

		public void DrawRectsToMergeGizmos(Color encC, Color innerC)
		{
		}

		internal string GetDescription()
		{
			return null;
		}

		internal string GetMatSubrectDescriptions()
		{
			return null;
		}
	}
}
