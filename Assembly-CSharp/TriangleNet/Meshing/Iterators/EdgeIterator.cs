using System;
using System.Collections;
using System.Collections.Generic;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Iterators
{
	public class EdgeIterator : IEnumerator<Edge>, IEnumerator, IDisposable
	{
		private IEnumerator<Triangle> triangles;

		private Otri tri;

		private Otri neighbor;

		private Osub sub;

		private Edge current;

		private Vertex p1;

		private Vertex p2;

		public Edge Current
		{
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				return null;
			}
		}

		public EdgeIterator(Mesh mesh)
			: base()
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return default(bool);
		}

		public void Reset()
		{
		}
	}
}
