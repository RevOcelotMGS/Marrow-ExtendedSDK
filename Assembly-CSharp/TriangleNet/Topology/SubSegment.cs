using TriangleNet.Geometry;

namespace TriangleNet.Topology
{
	public class SubSegment : ISegment, IEdge
	{
		internal int hash;

		internal Osub[] subsegs;

		internal Vertex[] vertices;

		internal Otri[] triangles;

		internal int boundary;

		public int P0
		{
			get
			{
				return default(int);
			}
		}

		public int P1
		{
			get
			{
				return default(int);
			}
		}

		public int Label
		{
			get
			{
				return default(int);
			}
		}

		public Vertex GetVertex(int index)
		{
			return null;
		}

		public ITriangle GetTriangle(int index)
		{
			return null;
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		public SubSegment()
			: base()
		{
		}
	}
}
