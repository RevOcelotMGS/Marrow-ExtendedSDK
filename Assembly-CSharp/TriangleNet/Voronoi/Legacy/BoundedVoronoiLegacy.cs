using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Voronoi.Legacy
{
	[Obsolete("Use TriangleNet.Voronoi.BoundedVoronoi class instead.")]
	public class BoundedVoronoiLegacy : IVoronoi
	{
		private IPredicates predicates;

		private Mesh mesh;

		private Point[] points;

		private List<VoronoiRegion> regions;

		private List<Point> segPoints;

		private int segIndex;

		private Dictionary<int, SubSegment> subsegMap;

		private bool includeBoundary;

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

		public BoundedVoronoiLegacy(Mesh mesh)
			: base()
		{
		}

		public BoundedVoronoiLegacy(Mesh mesh, bool includeBoundary)
			: base()
		{
		}

		private void Generate()
		{
		}

		private void ComputeCircumCenters()
		{
		}

		private void TagBlindTriangles()
		{
		}

		private bool TriangleIsBlinded(Otri tri, Osub seg)
		{
			return default(bool);
		}

		private void ConstructCell(Vertex vertex)
		{
		}

		private void ConstructBoundaryCell(Vertex vertex)
		{
		}

		private bool SegmentsIntersect(Point p1, Point p2, Point p3, Point p4, [Out] Point p, bool strictIntersect)
		{
			return default(bool);
		}

		private IEnumerable<IEdge> EnumerateEdges()
		{
			return null;
		}
	}
}
