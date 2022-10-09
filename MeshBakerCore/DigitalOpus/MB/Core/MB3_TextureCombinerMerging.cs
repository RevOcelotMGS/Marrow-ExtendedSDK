using System.Collections.Generic;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class MB3_TextureCombinerMerging
	{
		public static bool DO_INTEGRITY_CHECKS;

		private bool _HasBeenInitialized;

		private bool _considerNonTextureProperties;

		private MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender;

		private bool fixOutOfBoundsUVs;

		public MB2_LogLevel LOG_LEVEL;

		private static bool LOG_LEVEL_TRACE_MERGE_MAT_SUBRECTS;

		public static Rect BuildTransformMeshUV2AtlasRect(bool considerMeshUVs, Rect _atlasRect, Rect _obUVRect, Rect _sourceMaterialTiling, Rect _encapsulatingRect)
		{
			return default(Rect);
		}

		public MB3_TextureCombinerMerging(bool considerNonTextureProps, MB3_TextureCombinerNonTextureProperties resultMaterialTexBlender, bool fixObUVs, MB2_LogLevel logLevel)
			: base()
		{
		}

		public void MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects(List<MB_TexSet> distinctMaterialTextures)
		{
		}

		public void MergeDistinctMaterialTexturesThatWouldExceedMaxAtlasSizeAndCalcMaterialSubrects(List<MB_TexSet> distinctMaterialTextures, int maxAtlasSize)
		{
		}

		public void DoIntegrityCheckMergedEncapsulatingSamplingRects(List<MB_TexSet> distinctMaterialTextures)
		{
		}
	}
}
