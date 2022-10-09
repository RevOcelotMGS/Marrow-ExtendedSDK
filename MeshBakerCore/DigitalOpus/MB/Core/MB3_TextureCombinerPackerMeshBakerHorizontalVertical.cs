using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	internal class MB3_TextureCombinerPackerMeshBakerHorizontalVertical : MB3_TextureCombinerPackerMeshBaker
	{
		private interface IPipeline
		{
			MB2_PackingAlgorithmEnum GetPackingAlg();

			void SortTexSetIntoBins(MB_TexSet texSet, List<MB_TexSet> horizontalVert, List<MB_TexSet> regular, int maxAtlasWidth, int maxAtlasHeight);

			MB_TextureTilingTreatment GetEdge2EdgeTreatment();

			void InitializeAtlasPadding(AtlasPadding padding, int paddingValue);

			void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, [Out] Rect AatlasToFinal, [Out] Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, [Out] int atlasX, [Out] int atlasY);

			void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, [Out] int atlasRegularMaxWidth, [Out] int atlasRegularMaxHeight);
		}

		private class VerticalPipeline : IPipeline
		{
			public MB2_PackingAlgorithmEnum GetPackingAlg()
			{
				return default(MB2_PackingAlgorithmEnum);
			}

			public void SortTexSetIntoBins(MB_TexSet texSet, List<MB_TexSet> horizontalVert, List<MB_TexSet> regular, int maxAtlasWidth, int maxAtlasHeight)
			{
			}

			public MB_TextureTilingTreatment GetEdge2EdgeTreatment()
			{
				return default(MB_TextureTilingTreatment);
			}

			public void InitializeAtlasPadding(AtlasPadding padding, int paddingValue)
			{
			}

			public void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, [Out] Rect AatlasToFinal, [Out] Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, [Out] int atlasX, [Out] int atlasY)
			{
			}

			public void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, [Out] int atlasRegularMaxWidth, [Out] int atlasRegularMaxHeight)
			{
			}

			public VerticalPipeline()
				: base()
			{
			}
		}

		private class HorizontalPipeline : IPipeline
		{
			public MB2_PackingAlgorithmEnum GetPackingAlg()
			{
				return default(MB2_PackingAlgorithmEnum);
			}

			public void SortTexSetIntoBins(MB_TexSet texSet, List<MB_TexSet> horizontalVert, List<MB_TexSet> regular, int maxAtlasWidth, int maxAtlasHeight)
			{
			}

			public MB_TextureTilingTreatment GetEdge2EdgeTreatment()
			{
				return default(MB_TextureTilingTreatment);
			}

			public void InitializeAtlasPadding(AtlasPadding padding, int paddingValue)
			{
			}

			public void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, [Out] Rect AatlasToFinal, [Out] Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, [Out] int atlasX, [Out] int atlasY)
			{
			}

			public void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, [Out] int atlasRegularMaxWidth, [Out] int atlasRegularMaxHeight)
			{
			}

			public HorizontalPipeline()
				: base()
			{
			}
		}

		public enum AtlasDirection
		{
			horizontal = 0,
			vertical = 1
		}

		private AtlasDirection _atlasDirection;

		public MB3_TextureCombinerPackerMeshBakerHorizontalVertical(AtlasDirection ad)
			: base()
		{
		}

		public override AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		public static AtlasPackingResult TestStackRectanglesHorizontal(AtlasPackingResult a, AtlasPackingResult b, int maxHeightDim, int maxWidthDim, bool stretchBToAtlasWidth)
		{
			return null;
		}

		public static AtlasPackingResult TestStackRectanglesVertical(AtlasPackingResult a, AtlasPackingResult b, int maxHeightDim, int maxWidthDim, bool stretchBToAtlasWidth)
		{
			return null;
		}

		private static AtlasPackingResult MergeAtlasPackingResultStackBonA(AtlasPackingResult a, AtlasPackingResult b, int maxWidthDim, int maxHeightDim, bool stretchBToAtlasWidth, IPipeline pipeline)
		{
			return null;
		}
	}
}
