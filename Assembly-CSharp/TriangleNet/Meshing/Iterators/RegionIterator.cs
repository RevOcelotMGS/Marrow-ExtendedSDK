using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Iterators
{
	public class RegionIterator
	{
		private List<Triangle> region;

		public RegionIterator(Mesh mesh)
			: base()
		{
		}

		public void Process(Triangle triangle, int boundary = 0)
		{
		}

		public void Process(Triangle triangle, Action<Triangle> action, int boundary = 0)
		{
		}

		private void ProcessRegion(Action<Triangle> action, Func<SubSegment, bool> protector)
		{
		}
	}
}
