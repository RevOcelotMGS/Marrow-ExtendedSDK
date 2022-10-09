using System;
using System.Runtime.CompilerServices;
using TriangleNet.Geometry;

namespace TriangleNet
{
	internal class Behavior
	{
		private bool poly;

		private bool quality;

		private bool varArea;

		private bool convex;

		private bool jettison;

		private bool boundaryMarkers;

		private bool noHoles;

		private bool conformDel;

		private Func<ITriangle, double, bool> usertest;

		private int noBisect;

		private double minAngle;

		private double maxAngle;

		private double maxArea;

		internal bool fixedArea;

		internal bool useSegments;

		internal bool useRegions;

		internal double goodAngle;

		internal double maxGoodAngle;

		internal double offconstant;

		public static bool NoExact { get; set; }

		public bool Quality
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public double MinAngle
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public double MaxAngle
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public double MaxArea
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public bool VarArea
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool Poly
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Func<ITriangle, double, bool> UserTest
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Convex
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool ConformingDelaunay
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int NoBisect
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool UseBoundaryMarkers
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool NoHoles
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool Jettison
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Behavior(bool quality = false, double minAngle = 20.0)
			: base()
		{
		}

		private void Update()
		{
		}
	}
}
