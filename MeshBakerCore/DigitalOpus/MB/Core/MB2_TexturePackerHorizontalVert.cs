using System.Collections.Generic;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class MB2_TexturePackerHorizontalVert : MB2_TexturePacker
	{
		public enum TexturePackingOrientation
		{
			horizontal = 0,
			vertical = 1
		}

		public TexturePackingOrientation packingOrientation;

		public bool stretchImagesToEdges;

		public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, int maxDimensionX, int maxDimensionY, int padding)
		{
			return null;
		}

		public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas)
		{
			return null;
		}

		private AtlasPackingResult _GetRectsSingleAtlas(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, int recursionDepth)
		{
			return null;
		}

		private AtlasPackingResult[] _GetRectsMultiAtlasVertical(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionPassedX, int maxDimensionPassedY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY)
		{
			return null;
		}

		private AtlasPackingResult[] _GetRectsMultiAtlasHorizontal(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionPassedX, int maxDimensionPassedY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY)
		{
			return null;
		}

		private Image PopLargestThatFits(List<Image> images, int spaceRemaining, int maxDim, bool emptyAtlas)
		{
			return null;
		}

		public MB2_TexturePackerHorizontalVert()
			: base()
		{
		}
	}
}
