using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TriangleNet.Geometry;

namespace TriangleNet.Voronoi.Legacy
{
	[Obsolete("Use TriangleNet.Voronoi.StandardVoronoi class instead.")]
	public class SimpleVoronoi : IVoronoi
	{
		private IPredicates predicates;

		private Mesh mesh;

		private Point[] points;

		private Dictionary<int, VoronoiRegion> regions;

		private Dictionary<int, Point> rayPoints;

		private int rayIndex;

		private Rectangle bounds;

		public Point[] Points
		{
			get
			{
				return null;
			}
		}

		public ICollection<VoronoiRegion> Regions
		{
			get
			{
				return null;
			}
		}

		public IEnumerable<IEdge> Edges
		{
			get
			{
				return null;
			}
		}

		public SimpleVoronoi(Mesh mesh)
			: base()
		{
		}

		private void Generate()
		{
		}

		private void ComputeCircumCenters()
		{
		}

		private void ConstructCell(VoronoiRegion region)
		{
		}

		private bool BoxRayIntersection(Point pt, double dx, double dy, [Out] Point intersect)
		{
			return default(bool);
		}

		private IEnumerable<IEdge> EnumerateEdges()
		{
			return null;
		}
	}
}
