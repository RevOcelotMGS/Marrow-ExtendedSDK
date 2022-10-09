using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TriangleNet.Geometry;

namespace TriangleNet.Topology.DCEL
{
	public class Face
	{
		public static readonly Face Empty;

		internal int id;

		internal Point generator;

		internal HalfEdge edge;

		internal bool bounded;

		public int ID
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public HalfEdge Edge
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Bounded
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		static Face()
		{
		}

		public Face(Point generator)
			: base()
		{
		}

		public Face(Point generator, HalfEdge edge)
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
