using TriangleNet.Geometry;

namespace TriangleNet.Tools
{
	public class QualityMeasure
	{
		private class AreaMeasure
		{
			public double area_min;

			public double area_max;

			public double area_total;

			public int area_zero;

			public void Reset()
			{
			}

			public double Measure(Point a, Point b, Point c)
			{
				return default(double);
			}

			public AreaMeasure()
				: base()
			{
			}
		}

		private class AlphaMeasure
		{
			public double alpha_min;

			public double alpha_max;

			public double alpha_ave;

			public double alpha_area;

			public void Reset()
			{
			}

			private double acos(double c)
			{
				return default(double);
			}

			public double Measure(double ab, double bc, double ca, double area)
			{
				return default(double);
			}

			public void Normalize(int n, double area_total)
			{
			}

			public AlphaMeasure()
				: base()
			{
			}
		}

		private class Q_Measure
		{
			public double q_min;

			public double q_max;

			public double q_ave;

			public double q_area;

			public void Reset()
			{
			}

			public double Measure(double ab, double bc, double ca, double area)
			{
				return default(double);
			}

			public void Normalize(int n, double area_total)
			{
			}

			public Q_Measure()
				: base()
			{
			}
		}

		private AreaMeasure areaMeasure;

		private AlphaMeasure alphaMeasure;

		private Q_Measure qMeasure;

		private Mesh mesh;

		public double AreaMinimum
		{
			get
			{
				return default(double);
			}
		}

		public double AreaMaximum
		{
			get
			{
				return default(double);
			}
		}

		public double AreaRatio
		{
			get
			{
				return default(double);
			}
		}

		public double AlphaMinimum
		{
			get
			{
				return default(double);
			}
		}

		public double AlphaMaximum
		{
			get
			{
				return default(double);
			}
		}

		public double AlphaAverage
		{
			get
			{
				return default(double);
			}
		}

		public double AlphaArea
		{
			get
			{
				return default(double);
			}
		}

		public double Q_Minimum
		{
			get
			{
				return default(double);
			}
		}

		public double Q_Maximum
		{
			get
			{
				return default(double);
			}
		}

		public double Q_Average
		{
			get
			{
				return default(double);
			}
		}

		public double Q_Area
		{
			get
			{
				return default(double);
			}
		}

		public void Update(Mesh mesh)
		{
		}

		private void Compute()
		{
		}

		public int Bandwidth()
		{
			return default(int);
		}

		public QualityMeasure()
			: base()
		{
		}
	}
}
