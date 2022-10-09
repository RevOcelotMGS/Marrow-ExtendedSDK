using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TriangleNet.Geometry;
using TriangleNet.Meshing;
using TriangleNet.Topology;
using TriangleNet.Topology.DCEL;
using TriangleNet.Voronoi;

namespace TriangleNet.Smoothing
{
	public class SimpleSmoother : ISmoother
	{
		private TrianglePool pool;

		private Configuration config;

		private IVoronoiFactory factory;

		private ConstraintOptions options;

		public SimpleSmoother()
			: base()
		{
		}

		public SimpleSmoother(IVoronoiFactory factory)
			: this()
		{
		}

		public SimpleSmoother(IVoronoiFactory factory, Configuration config)
			: this()
		{
		}

		public void Smooth(IMesh mesh)
		{
		}

		public void Smooth(IMesh mesh, int limit)
		{
		}

		private void Step(Mesh mesh, IVoronoiFactory factory, IPredicates predicates)
		{
		}

		private void Centroid(Face face, [Out] double x, [Out] double y)
		{
		}

		private Polygon Rebuild(Mesh mesh)
		{
			return null;
		}
	}
}
