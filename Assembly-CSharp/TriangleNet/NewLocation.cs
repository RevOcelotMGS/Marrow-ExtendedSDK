using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet
{
	internal class NewLocation
	{
		private const double EPS = 1E-50;

		private IPredicates predicates;

		private Mesh mesh;

		private Behavior behavior;

		private double[] petalx;

		private double[] petaly;

		private double[] petalr;

		private double[] wedges;

		private double[] initialConvexPoly;

		private double[] points_p;

		private double[] points_q;

		private double[] points_r;

		private double[] poly1;

		private double[] poly2;

		private double[][] polys;

		public NewLocation(Mesh mesh, IPredicates predicates)
			: base()
		{
		}

		public Point FindLocation(Vertex org, Vertex dest, Vertex apex, double xi, double eta, bool offcenter, Otri badotri)
		{
			return null;
		}

		private Point FindNewLocationWithoutMaxAngle(Vertex torg, Vertex tdest, Vertex tapex, double xi, double eta, bool offcenter, Otri badotri)
		{
			return null;
		}

		private Point FindNewLocation(Vertex torg, Vertex tdest, Vertex tapex, double xi, double eta, bool offcenter, Otri badotri)
		{
			return null;
		}

		private int LongestShortestEdge(double aodist, double dadist, double dodist)
		{
			return default(int);
		}

		private int DoSmoothing(Otri badotri, Vertex torg, Vertex tdest, Vertex tapex, double[] newloc)
		{
			return default(int);
		}

		private int GetStarPoints(Otri badotri, Vertex p, Vertex q, Vertex r, int whichPoint, double[] points)
		{
			return default(int);
		}

		private bool GetNeighborsVertex(Otri badotri, double first_x, double first_y, double second_x, double second_y, double[] thirdpoint, Otri neighotri)
		{
			return default(bool);
		}

		private bool GetWedgeIntersectionWithoutMaxAngle(int numpoints, double[] points, double[] newloc)
		{
			return default(bool);
		}

		private bool GetWedgeIntersection(int numpoints, double[] points, double[] newloc)
		{
			return default(bool);
		}

		private bool ValidPolygonAngles(int numpoints, double[] points)
		{
			return default(bool);
		}

		private bool IsBadPolygonAngle(double x1, double y1, double x2, double y2, double x3, double y3)
		{
			return default(bool);
		}

		private void LineLineIntersection(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double[] p)
		{
		}

		private int HalfPlaneIntersection(int numvertices, double[] convexPoly, double x1, double y1, double x2, double y2)
		{
			return default(int);
		}

		private int SplitConvexPolygon(int numvertices, double[] convexPoly, double x1, double y1, double x2, double y2, double[][] polys)
		{
			return default(int);
		}

		private int LinePointLocation(double x1, double y1, double x2, double y2, double x, double y)
		{
			return default(int);
		}

		private void LineLineSegmentIntersection(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double[] p)
		{
		}

		private void FindPolyCentroid(int numpoints, double[] points, double[] centroid)
		{
		}

		private void CircleLineIntersection(double x1, double y1, double x2, double y2, double x3, double y3, double r, double[] p)
		{
		}

		private bool ChooseCorrectPoint(double x1, double y1, double x2, double y2, double x3, double y3, bool isObtuse)
		{
			return default(bool);
		}

		private void PointBetweenPoints(double x1, double y1, double x2, double y2, double x, double y, double[] p)
		{
		}

		private bool IsBadTriangleAngle(double x1, double y1, double x2, double y2, double x3, double y3)
		{
			return default(bool);
		}

		private double MinDistanceToNeighbor(double newlocX, double newlocY, Otri searchtri)
		{
			return default(double);
		}
	}
}
