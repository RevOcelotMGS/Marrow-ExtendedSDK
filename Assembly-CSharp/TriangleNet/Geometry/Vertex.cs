using TriangleNet.Topology;

namespace TriangleNet.Geometry
{
	public class Vertex : Point
	{
		internal int hash;

		internal VertexType type;

		internal Otri tri;

		public VertexType Type
		{
			get
			{
				return default(VertexType);
			}
		}

		public double this[int i]
		{
			get
			{
				return default(double);
			}
		}

		public Vertex()
			: base()
		{
		}

		public Vertex(double x, double y)
			: this()
		{
		}

		public Vertex(double x, double y, int mark)
			: this()
		{
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
