using TriangleNet.Geometry;

namespace TriangleNet.Voronoi
{
	public class StandardVoronoi : VoronoiBase
	{
		public StandardVoronoi(Mesh mesh)
			: this(mesh, default(TriangleNet.Geometry.Rectangle))
		{
		}

		public StandardVoronoi(Mesh mesh, Rectangle box)
			: this(mesh)
		{
		}

		public StandardVoronoi(Mesh mesh, Rectangle box, IVoronoiFactory factory, IPredicates predicates)
			: this(mesh)
		{
		}

		private void PostProcess(Rectangle box)
		{
		}
	}
}
