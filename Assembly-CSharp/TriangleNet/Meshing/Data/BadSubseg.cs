using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Data
{
	internal class BadSubseg
	{
		public Osub subseg;

		public Vertex org;

		public Vertex dest;

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		public BadSubseg()
			: base()
		{
		}
	}
}
