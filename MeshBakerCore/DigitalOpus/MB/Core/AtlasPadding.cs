using System;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	public struct AtlasPadding
	{
		public int topBottom;

		public int leftRight;

		public AtlasPadding(int p)
		{
			this.leftRight = default(int);
			this.topBottom = default(int);
		}

		public AtlasPadding(int px, int py)
		{
			this.leftRight = default(int);
			this.topBottom = default(int);
		}
	}
}
