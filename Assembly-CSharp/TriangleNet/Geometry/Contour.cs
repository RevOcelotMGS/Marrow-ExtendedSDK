using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TriangleNet.Geometry
{
	public class Contour
	{
		private int marker;

		private bool convex;

		public List<Vertex> Points { get; set; }

		public Contour(IEnumerable<Vertex> points)
			: base()
		{
		}

		public Contour(IEnumerable<Vertex> points, int marker)
			: base()
		{
		}

		public Contour(IEnumerable<Vertex> points, int marker, bool convex)
			: base()
		{
		}

		public List<ISegment> GetSegments()
		{
			return null;
		}

		public Point FindInteriorPoint(int limit = 5, double eps = 2E-05)
		{
			return null;
		}

		private void AddPoints(IEnumerable<Vertex> points)
		{
		}

		private static Point FindPointInPolygon(List<Vertex> contour, int limit, double eps)
		{
			return null;
		}

		private static bool IsPointInPolygon(Point point, List<Vertex> poly)
		{
			return default(bool);
		}
	}
}
