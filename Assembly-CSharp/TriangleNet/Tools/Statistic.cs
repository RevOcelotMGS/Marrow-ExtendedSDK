namespace TriangleNet.Tools
{
	public class Statistic
	{
		public static long InCircleCount;

		public static long InCircleAdaptCount;

		public static long CounterClockwiseCount;

		public static long CounterClockwiseAdaptCount;

		public static long Orient3dCount;

		public static long HyperbolaCount;

		public static long CircumcenterCount;

		public static long CircleTopCount;

		public static long RelocationCount;

		private double minEdge;

		private double maxEdge;

		private double minAspect;

		private double maxAspect;

		private double minArea;

		private double maxArea;

		private double minAngle;

		private double maxAngle;

		private int[] angleTable;

		private int[] minAngles;

		private int[] maxAngles;

		private static readonly int[] plus1Mod3;

		private static readonly int[] minus1Mod3;

		public double ShortestEdge
		{
			get
			{
				return default(double);
			}
		}

		public double LongestEdge
		{
			get
			{
				return default(double);
			}
		}

		public double ShortestAltitude
		{
			get
			{
				return default(double);
			}
		}

		public double LargestAspectRatio
		{
			get
			{
				return default(double);
			}
		}

		public double SmallestArea
		{
			get
			{
				return default(double);
			}
		}

		public double LargestArea
		{
			get
			{
				return default(double);
			}
		}

		public double SmallestAngle
		{
			get
			{
				return default(double);
			}
		}

		public double LargestAngle
		{
			get
			{
				return default(double);
			}
		}

		public int[] AngleHistogram
		{
			get
			{
				return null;
			}
		}

		public int[] MinAngleHistogram
		{
			get
			{
				return null;
			}
		}

		public int[] MaxAngleHistogram
		{
			get
			{
				return null;
			}
		}

		private void GetAspectHistogram(Mesh mesh)
		{
		}

		public void Update(Mesh mesh, int sampleDegrees)
		{
		}

		public Statistic()
			: base()
		{
		}
	}
}
