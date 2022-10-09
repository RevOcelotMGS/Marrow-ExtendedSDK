using System;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	public class AtlasPackingResult
	{
		public int atlasX;

		public int atlasY;

		public int usedW;

		public int usedH;

		public Rect[] rects;

		public AtlasPadding[] padding;

		public int[] srcImgIdxs;

		public object data;

		public AtlasPackingResult(AtlasPadding[] pds)
			: base()
		{
		}

		public void CalcUsedWidthAndHeight()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
