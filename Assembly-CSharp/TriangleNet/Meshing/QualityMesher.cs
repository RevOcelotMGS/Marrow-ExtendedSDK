using System.Collections.Generic;
using TriangleNet.Logging;
using TriangleNet.Meshing.Data;
using TriangleNet.Topology;

namespace TriangleNet.Meshing
{
	internal class QualityMesher
	{
		private IPredicates predicates;

		private Queue<BadSubseg> badsubsegs;

		private BadTriQueue queue;

		private Mesh mesh;

		private Behavior behavior;

		private NewLocation newLocation;

		private ILog<LogItem> logger;

		private Triangle newvertex_tri;

		public QualityMesher(Mesh mesh, Configuration config)
			: base()
		{
		}

		public void Apply(QualityOptions quality, bool delaunay = false)
		{
		}

		public void AddBadSubseg(BadSubseg badseg)
		{
		}

		public int CheckSeg4Encroach(Osub testsubseg)
		{
			return default(int);
		}

		public void TestTriangle(Otri testtri)
		{
		}

		private void TallyEncs()
		{
		}

		private void SplitEncSegs(bool triflaws)
		{
		}

		private void TallyFaces()
		{
		}

		private void SplitTriangle(BadTriangle badtri)
		{
		}

		private void EnforceQuality()
		{
		}
	}
}
