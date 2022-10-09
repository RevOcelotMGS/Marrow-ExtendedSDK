using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MK.Glow
{
	internal sealed class ComputeShaderVariants
	{
		internal static class KeywordValues
		{
			internal const int BLOOM = 1;

			internal const int LENS_SURFACE = 1;

			internal const int LENS_FLARE = 1;

			internal const int GLARE = 4;

			internal const int MK_NATURAL = 1;

			internal const int RENDER_PRIORITY = 2;
		}

		internal struct KeywordState
		{
			public int bloom;

			public int lensSurface;

			public int lensFlare;

			public int glare;

			public int natural;

			public int renderPriority;

			public KeywordState(int bloom, int lensSurface, int lensFlare, int glare, int natural, int renderPriority)
			{
				this.renderPriority = default(int);
				this.natural = default(int);
				this.glare = default(int);
				this.lensFlare = default(int);
				this.lensSurface = default(int);
				this.bloom = default(int);
			}
		}

		private Dictionary<KeywordState, int> variants;

		internal void GetVariantNumber(KeywordState features, [Out] int index)
		{
		}

		public ComputeShaderVariants(int offset)
			: base()
		{
		}
	}
}
