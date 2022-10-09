using TriangleNet.Geometry;

namespace TriangleNet.Topology
{
	public struct Osub
	{
		internal SubSegment seg;

		internal int orient;

		public SubSegment Segment
		{
			get
			{
				return null;
			}
		}

		public override string ToString()
		{
			return null;
		}

		public void Sym(Osub os)
		{
		}

		public void Sym()
		{
		}

		public void Pivot(Osub os)
		{
		}

		internal void Pivot(Otri ot)
		{
		}

		public void Next(Osub ot)
		{
		}

		public void Next()
		{
		}

		public Vertex Org()
		{
			return null;
		}

		public Vertex Dest()
		{
			return null;
		}

		internal void SetOrg(Vertex vertex)
		{
		}

		internal void SetDest(Vertex vertex)
		{
		}

		internal Vertex SegOrg()
		{
			return null;
		}

		internal Vertex SegDest()
		{
			return null;
		}

		internal void SetSegOrg(Vertex vertex)
		{
		}

		internal void SetSegDest(Vertex vertex)
		{
		}

		internal void Bond(Osub os)
		{
		}

		internal void Dissolve(SubSegment dummy)
		{
		}

		internal bool Equal(Osub os)
		{
			return default(bool);
		}

		internal void TriDissolve(Triangle dummy)
		{
		}

		internal static bool IsDead(SubSegment sub)
		{
			return default(bool);
		}

		internal static void Kill(SubSegment sub)
		{
		}
	}
}
