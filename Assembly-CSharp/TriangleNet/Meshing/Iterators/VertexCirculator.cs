using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Iterators
{
	public class VertexCirculator
	{
		private List<Otri> cache;

		public VertexCirculator(Mesh mesh)
			: base()
		{
		}

		public IEnumerable<Vertex> EnumerateVertices(Vertex vertex)
		{
			return null;
		}

		public IEnumerable<ITriangle> EnumerateTriangles(Vertex vertex)
		{
			return null;
		}

		private void BuildCache(Vertex vertex, bool vertices)
		{
		}
	}
}
