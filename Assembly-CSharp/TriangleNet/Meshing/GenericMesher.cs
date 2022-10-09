using System.Collections.Generic;
using TriangleNet.Geometry;

namespace TriangleNet.Meshing
{
	public class GenericMesher
	{
		private Configuration config;

		private ITriangulator triangulator;

		public GenericMesher()
			: base()
		{
		}

		public GenericMesher(ITriangulator triangulator)
			: this()
		{
		}

		public GenericMesher(Configuration config)
			: this()
		{
		}

		public GenericMesher(ITriangulator triangulator, Configuration config)
			: this()
		{
		}

		public IMesh Triangulate(IList<Vertex> points)
		{
			return null;
		}

		public IMesh Triangulate(IPolygon polygon)
		{
			return null;
		}

		public IMesh Triangulate(IPolygon polygon, ConstraintOptions options)
		{
			return null;
		}

		public IMesh Triangulate(IPolygon polygon, QualityOptions quality)
		{
			return null;
		}

		public IMesh Triangulate(IPolygon polygon, ConstraintOptions options, QualityOptions quality)
		{
			return null;
		}

		public static IMesh StructuredMesh(double width, double height, int nx, int ny)
		{
			return null;
		}

		public static IMesh StructuredMesh(Rectangle bounds, int nx, int ny)
		{
			return null;
		}
	}
}
