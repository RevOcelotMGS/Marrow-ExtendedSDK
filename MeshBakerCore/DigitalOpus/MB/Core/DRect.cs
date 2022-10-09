using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public struct DRect
	{
		public double x;

		public double y;

		public double width;

		public double height;

		public DVector2 minD
		{
			get
			{
				return default(DVector2);
			}
		}

		public DVector2 maxD
		{
			get
			{
				return default(DVector2);
			}
		}

		public Vector2 min
		{
			get
			{
				return default(Vector2);
			}
		}

		public Vector2 max
		{
			get
			{
				return default(Vector2);
			}
		}

		public Vector2 size
		{
			get
			{
				return default(Vector2);
			}
		}

		public DVector2 center
		{
			get
			{
				return default(DVector2);
			}
		}

		public DRect(Rect r)
		{
			this.height = default(double);
			this.width = default(double);
			this.y = default(double);
			this.x = default(double);
		}

		public DRect(Vector2 o, Vector2 s)
		{
			this.height = default(double);
			this.width = default(double);
			this.y = default(double);
			this.x = default(double);
		}

		public DRect(DRect r)
		{
			this.height = default(double);
			this.width = default(double);
			this.y = default(double);
			this.x = default(double);
		}

		public DRect(float xx, float yy, float w, float h)
		{
			this.height = default(double);
			this.width = default(double);
			this.y = default(double);
			this.x = default(double);
		}

		public DRect(double xx, double yy, double w, double h)
		{
			this.height = default(double);
			this.width = default(double);
			this.y = default(double);
			this.x = default(double);
		}

		public Rect GetRect()
		{
			return default(Rect);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public static bool operator ==(DRect a, DRect b)
		{
			return default(bool);
		}

		public static bool operator !=(DRect a, DRect b)
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}

		public void Expand(float amt)
		{
		}

		public bool Encloses(DRect smallToTestIfFits)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
