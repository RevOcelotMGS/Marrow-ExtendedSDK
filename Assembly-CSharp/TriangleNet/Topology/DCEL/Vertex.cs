using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TriangleNet.Geometry;

namespace TriangleNet.Topology.DCEL
{
	public class Vertex : Point
	{
		internal HalfEdge leaving;

		public HalfEdge Leaving
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vertex(double x, double y)
			: base()
		{
		}

		public Vertex(double x, double y, HalfEdge leaving)
			: base()
		{
		}

		public IEnumerable<HalfEdge> EnumerateEdges()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
