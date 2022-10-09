using System;
using System.Runtime.CompilerServices;

namespace TriangleNet.Meshing
{
	public class ConstraintOptions
	{
		[Obsolete("Not used anywhere, will be removed in beta 4.")]
		public bool UseRegions { get; set; }

		public bool ConformingDelaunay { get; set; }

		public bool Convex { get; set; }

		public int SegmentSplitting { get; set; }

		public ConstraintOptions()
			: base()
		{
		}
	}
}
