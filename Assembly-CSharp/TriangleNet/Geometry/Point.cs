using System;

namespace TriangleNet.Geometry
{
	public class Point : IComparable<Point>, IEquatable<Point>
	{
		internal int id;

		internal int label;

		internal double x;

		internal double y;

		internal double z;

		public int ID
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public double X
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public double Y
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public double Z
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public int Label
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public Point()
			: base()
		{
		}

		public Point(double x, double y)
			: this()
		{
		}

		public Point(double x, double y, int label)
			: this()
		{
		}

		public static bool operator ==(Point a, Point b)
		{
			return default(bool);
		}

		public static bool operator !=(Point a, Point b)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public bool Equals(Point p)
		{
			return default(bool);
		}

		public int CompareTo(Point other)
		{
			return default(int);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
