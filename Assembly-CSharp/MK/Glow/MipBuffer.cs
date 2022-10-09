using UnityEngine;
using UnityEngine.Rendering;

namespace MK.Glow
{
	internal sealed class MipBuffer
	{
		private RenderTarget[] _renderTargets;

		internal RenderTarget[] renderTargets
		{
			get
			{
				return null;
			}
		}

		public MipBuffer(string name, RenderPipeline renderPipeline)
			: base()
		{
		}

		internal void CreateTemporary(RenderContext[] renderContext, int level, CommandBuffer cmd, RenderTextureFormat format, bool useComputeShaders, RenderPipeline renderPipeline)
		{
		}

		internal void ClearTemporary(CommandBuffer cmd, int level, RenderPipeline renderPipeline)
		{
		}
	}
}
