using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet
{
	public class TriangleLocator
	{
		private TriangleSampler sampler;

		private Mesh mesh;

		private IPredicates predicates;

		internal Otri recenttri;

		public TriangleLocator(Mesh mesh)
			: base()
		{
		}

		public TriangleLocator(Mesh mesh, IPredicates predicates)
			: base()
		{
		}

		public void Update(Otri otri)
		{
		}

		public void Reset()
		{
		}

		public LocateResult PreciseLocate(Point searchpoint, Otri searchtri, bool stopatsubsegment)
		{
			return default(LocateResult);
		}

		public LocateResult Locate(Point searchpoint, Otri searchtri)
		{
			return default(LocateResult);
		}
	}
}
