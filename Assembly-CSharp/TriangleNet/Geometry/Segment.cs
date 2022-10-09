namespace TriangleNet.Geometry
{
	public class Segment : ISegment, IEdge
	{
		private Vertex v0;

		private Vertex v1;

		private int label;

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

		public Segment(Vertex v0, Vertex v1)
			: base()
		{
		}

		public Segment(Vertex v0, Vertex v1, int label)
			: base()
		{
		}

		public Vertex GetVertex(int index)
		{
			return null;
		}

		public ITriangle GetTriangle(int index)
		{
			return null;
		}
	}
}
