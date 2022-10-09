using TriangleNet.Geometry;

namespace TriangleNet.Tools
{
	public static class PolygonValidator
	{
		public static bool IsConsistent(IPolygon poly)
		{
			return default(bool);
		}

		public static bool HasDuplicateVertices(IPolygon poly)
		{
			return default(bool);
		}

		public static bool HasBadAngles(IPolygon poly, double threshold = 2E-12)
		{
			return default(bool);
		}

		private static bool IsBadAngle(Point a, Point b, Point c, double threshold = 0.0)
		{
			return default(bool);
		}

		private static double DotProduct(Point a, Point b, Point c)
		{
			return default(double);
		}

		private static double CrossProductLength(Point a, Point b, Point c)
		{
			return default(double);
		}

		private static int CheckVertexIDs(IPolygon poly, int count)
		{
			return default(int);
		}

		private static int CheckDuplicateIDs(IPolygon poly)
		{
			return default(int);
		}
	}
}
