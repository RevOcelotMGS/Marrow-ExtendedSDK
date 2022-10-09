using TriangleNet.Geometry;

namespace TriangleNet.Topology
{
	public struct Otri
	{
		internal Triangle tri;

		internal int orient;

		private static readonly int[] plus1Mod3;

		private static readonly int[] minus1Mod3;

		public Triangle Triangle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}

		public void Sym(Otri ot)
		{
		}

		public void Sym()
		{
		}

		public void Lnext(Otri ot)
		{
		}

		public void Lnext()
		{
		}

		public void Lprev(Otri ot)
		{
		}

		public void Lprev()
		{
		}

		public void Onext(Otri ot)
		{
		}

		public void Onext()
		{
		}

		public void Oprev(Otri ot)
		{
		}

		public void Oprev()
		{
		}

		public void Dnext(Otri ot)
		{
		}

		public void Dnext()
		{
		}

		public void Dprev(Otri ot)
		{
		}

		public void Dprev()
		{
		}

		public void Rnext(Otri ot)
		{
		}

		public void Rnext()
		{
		}

		public void Rprev(Otri ot)
		{
		}

		public void Rprev()
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

		public Vertex Apex()
		{
			return null;
		}

		public void Copy(Otri ot)
		{
		}

		public bool Equals(Otri ot)
		{
			return default(bool);
		}

		internal void SetOrg(Vertex v)
		{
		}

		internal void SetDest(Vertex v)
		{
		}

		internal void SetApex(Vertex v)
		{
		}

		internal void Bond(Otri ot)
		{
		}

		internal void Dissolve(Triangle dummy)
		{
		}

		internal void Infect()
		{
		}

		internal void Uninfect()
		{
		}

		internal bool IsInfected()
		{
			return default(bool);
		}

		internal void Pivot(Osub os)
		{
		}

		internal void SegBond(Osub os)
		{
		}

		internal void SegDissolve(SubSegment dummy)
		{
		}

		internal static bool IsDead(Triangle tria)
		{
			return default(bool);
		}

		internal static void Kill(Triangle tri)
		{
		}
	}
}
