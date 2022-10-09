using TriangleNet.Geometry;

namespace TriangleNet.IO
{
	public class InputTriangle : ITriangle
	{
		internal int[] vertices;

		internal int label;

		internal double area;

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

		public InputTriangle(int p0, int p1, int p2)
			: base()
		{
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
	}
}
