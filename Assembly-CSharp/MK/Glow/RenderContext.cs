using UnityEngine;

namespace MK.Glow
{
	internal sealed class RenderContext : IDimension
	{
		private RenderTextureDescriptor _descriptor;

		public RenderTextureDescriptor descriptor
		{
			get
			{
				return default(RenderTextureDescriptor);
			}
		}

		public RenderDimension renderDimension
		{
			get
			{
				return default(RenderDimension);
			}
		}

		public bool enableRandomWrite
		{
			get
			{
				return default(bool);
			}
		}

		public int width
		{
			get
			{
				return default(int);
			}
		}

		public int height
		{
			get
			{
				return default(int);
			}
		}

		internal RenderContext()
			: base()
		{
		}

		internal void SinglePassStereoAdjustWidth(bool stereoEnabled)
		{
		}

		internal void UpdateRenderContext(CameraData cameraData, RenderTextureFormat format, int depthBufferBits, bool enableRandomWrite, RenderDimension dimension)
		{
		}
	}
}
