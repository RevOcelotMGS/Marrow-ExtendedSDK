using System.Collections.Generic;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Algorithm
{
	public class Dwyer : ITriangulator
	{
		private IPredicates predicates;

		public bool UseDwyer;

		private Vertex[] sortarray;

		private Mesh mesh;

		public IMesh Triangulate(IList<Vertex> points, Configuration config)
		{
			return null;
		}

		private void MergeHulls(Otri farleft, Otri innerleft, Otri innerright, Otri farright, int axis)
		{
		}

		private void DivconqRecurse(int left, int right, int axis, Otri farleft, Otri farright)
		{
		}

		private int RemoveGhosts(Otri startghost)
		{
			return default(int);
		}

		public Dwyer()
			: base()
		{
		}
	}
}
