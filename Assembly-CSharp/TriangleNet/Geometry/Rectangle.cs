using System.Collections.Generic;

namespace TriangleNet.Geometry
{
	public class Rectangle
	{
		private double xmin;

		private double ymin;

		private double xmax;

		private double ymax;

		public double Left
		{
			get
			{
				return default(double);
			}
		}

		public double Right
		{
			get
			{
				return default(double);
			}
		}

		public double Bottom
		{
			get
			{
				return default(double);
			}
		}

		public double Top
		{
			get
			{
				return default(double);
			}
		}

		public double Width
		{
			get
			{
				return default(double);
			}
		}

		public double Height
		{
			get
			{
				return default(double);
			}
		}

		public Rectangle()
			: base()
		{
		}

		public Rectangle(Rectangle other)
			: this()
		{
		}

		public Rectangle(double x, double y, double width, double height)
			: this()
		{
		}

		public void Resize(double dx, double dy)
		{
		}

		public void Expand(Point p)
		{
		}

		public void Expand(IEnumerable<Point> points)
		{
		}

		public void Expand(Rectangle other)
		{
		}

		public bool Contains(double x, double y)
		{
			return default(bool);
		}

		public bool Contains(Point pt)
		{
			return default(bool);
		}

		public bool Contains(Rectangle other)
		{
			return default(bool);
		}

		public bool Intersects(Rectangle other)
		{
			return default(bool);
		}
	}
}
