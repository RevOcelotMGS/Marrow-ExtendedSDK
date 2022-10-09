using System.Runtime.CompilerServices;

namespace MK.Glow
{
	internal struct RenderDimension : IDimension
	{
		public int width
		{
			[IsReadOnly]
			get;
			set; }

		public int height
		{
			[IsReadOnly]
			get;
			set; }

		public RenderDimension renderDimension
		{
			get
			{
				return default(RenderDimension);
			}
		}

		public RenderDimension(int width, int height)
		{
			this.height = default(int);
			this.width = default(int);
		}
	}
}
