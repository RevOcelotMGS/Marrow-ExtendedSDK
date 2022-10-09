using TriangleNet.Geometry;

namespace TriangleNet
{
	public interface IPredicates
	{
		double CounterClockwise(Point a, Point b, Point c);

		double InCircle(Point a, Point b, Point c, Point p);

		Point FindCircumcenter(Point org, Point dest, Point apex, double xi, double eta);

		Point FindCircumcenter(Point org, Point dest, Point apex, double xi, double eta, double offconstant);
	}
}
