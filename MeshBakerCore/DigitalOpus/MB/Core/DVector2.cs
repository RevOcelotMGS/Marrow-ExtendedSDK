using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public struct DVector2
	{
		private static double epsilon;

		public double x;

		public double y;

		public static DVector2 Subtract(DVector2 a, DVector2 b)
		{
			return default(DVector2);
		}

		public DVector2(double xx, double yy)
		{
			this.y = default(double);
			this.x = default(double);
		}

		public DVector2(DVector2 r)
		{
			this.y = default(double);
			this.x = default(double);
		}

		public Vector2 GetVector2()
		{
			return default(Vector2);
		}

		public bool IsContainedIn(DRect r)
		{
			return default(bool);
		}

		public bool IsContainedInWithMargin(DRect r)
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string formatS)
		{
			return null;
		}

		public static double Distance(DVector2 a, DVector2 b)
		{
			return default(double);
		}
	}
}
