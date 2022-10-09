using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public abstract class MB2_TexturePacker
	{
		internal enum NodeType
		{
			Container = 0,
			maxDim = 1,
			regular = 2
		}

		internal class PixRect
		{
			public int x;

			public int y;

			public int w;

			public int h;

			public PixRect()
				: base()
			{
			}

			public PixRect(int xx, int yy, int ww, int hh)
				: this()
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		internal class Image
		{
			public int imgId;

			public int w;

			public int h;

			public int x;

			public int y;

			public Image(int id, int tw, int th, AtlasPadding padding, int minImageSizeX, int minImageSizeY)
				: base()
			{
			}

			public Image(Image im)
				: base()
			{
			}
		}

		internal class ImgIDComparer : IComparer<Image>
		{
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			public ImgIDComparer()
				: base()
			{
			}
		}

		internal class ImageHeightComparer : IComparer<Image>
		{
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			public ImageHeightComparer()
				: base()
			{
			}
		}

		internal class ImageWidthComparer : IComparer<Image>
		{
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			public ImageWidthComparer()
				: base()
			{
			}
		}

		internal class ImageAreaComparer : IComparer<Image>
		{
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			public ImageAreaComparer()
				: base()
			{
			}
		}

		public MB2_LogLevel LOG_LEVEL;

		internal const int MAX_RECURSION_DEPTH = 10;

		public bool atlasMustBePowerOfTwo;

		public static int RoundToNearestPositivePowerOfTwo(int x)
		{
			return default(int);
		}

		public static int CeilToNearestPowerOfTwo(int x)
		{
			return default(int);
		}

		public abstract AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, int maxDimensionX, int maxDimensionY, int padding);

		public abstract AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas);

		internal bool ScaleAtlasToFitMaxDim(Vector2 rootWH, List<Image> images, int maxDimensionX, int maxDimensionY, AtlasPadding padding, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, int outW, int outH, [Out] float padX, [Out] float padY, [Out] int newMinSizeX, [Out] int newMinSizeY)
		{
			return default(bool);
		}

		public void ConvertToRectsWithoutPaddingAndNormalize01(AtlasPackingResult rr, AtlasPadding padding)
		{
		}

		public MB2_TexturePacker()
			: base()
		{
		}
	}
}
