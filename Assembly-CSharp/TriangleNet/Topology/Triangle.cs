using TriangleNet.Geometry;

namespace TriangleNet.Topology
{
	public class Triangle : ITriangle
	{
		internal int hash;

		internal int id;

		internal Otri[] neighbors;

		internal Vertex[] vertices;

		internal Osub[] subsegs;

		internal int label;

		internal double area;

		internal bool infected;

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

		public int Label
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public double Area
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public Vertex GetVertex(int index)
		{
			return null;
		}

		public int GetVertexID(int index)
		{
			return default(int);
		}

		public ITriangle GetNeighbor(int index)
		{
			return null;
		}

		public int GetNeighborID(int index)
		{
			return default(int);
		}

		public ISegment GetSegment(int index)
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

		public Triangle()
			: base()
		{
		}
	}
}
