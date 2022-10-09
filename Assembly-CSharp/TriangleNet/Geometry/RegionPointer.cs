namespace TriangleNet.Geometry
{
	public class RegionPointer
	{
		internal Point point;

		internal int id;

		internal double area;

		public double Area
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public RegionPointer(double x, double y, int id)
			: base()
		{
		}

		public RegionPointer(double x, double y, int id, double area)
			: base()
		{
		}
	}
}
