using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TriangleNet.Geometry
{
	public class Polygon : IPolygon
	{
		private List<Vertex> points;

		private List<Point> holes;

		private List<RegionPointer> regions;

		private List<ISegment> segments;

		public List<Vertex> Points
		{
			get
			{
				return null;
			}
		}

		public List<Point> Holes
		{
			get
			{
				return null;
			}
		}

		public List<RegionPointer> Regions
		{
			get
			{
				return null;
			}
		}

		public List<ISegment> Segments
		{
			get
			{
				return null;
			}
		}

		public bool HasPointMarkers { get; set; }

		public bool HasSegmentMarkers { get; set; }

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public Polygon()
			: base()
		{
		}

		public Polygon(int capacity)
			: this()
		{
		}

		public Polygon(int capacity, bool markers)
			: this()
		{
		}

		[Obsolete("Use polygon.Add(contour) method instead.")]
		public void AddContour(IEnumerable<Vertex> points, int marker = 0, bool hole = false, bool convex = false)
		{
		}

		[Obsolete("Use polygon.Add(contour) method instead.")]
		public void AddContour(IEnumerable<Vertex> points, int marker, Point hole)
		{
		}

		public Rectangle Bounds()
		{
			return null;
		}

		public void Add(Vertex vertex)
		{
		}

		public void Add(ISegment segment, bool insert = false)
		{
		}

		public void Add(ISegment segment, int index)
		{
		}

		public void Add(Contour contour, bool hole = false)
		{
		}

		public void Add(Contour contour, Point hole)
		{
		}
	}
}
