using UnityEngine;

namespace MK.Glow
{
	public static class Compatibility
	{
		private static readonly bool _defaultHDRFormatSupported;

		private static readonly bool _11R11G10BFormatSupported;

		private static readonly bool _2A10R10G10BFormatSupported;

		public static readonly bool IsSupported;

		public static bool CheckGeometryShaderSupport()
		{
			return default(bool);
		}

		public static bool CheckComputeShaderSupport()
		{
			return default(bool);
		}

		public static bool CheckLensFlareFeatureSupport()
		{
			return default(bool);
		}

		public static bool CheckGlareFeatureSupport()
		{
			return default(bool);
		}

		internal static RenderTextureFormat CheckSupportedRenderTextureFormat()
		{
			return default(RenderTextureFormat);
		}
	}
}
