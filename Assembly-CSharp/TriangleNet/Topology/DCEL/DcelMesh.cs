using System.Collections.Generic;
using TriangleNet.Geometry;

namespace TriangleNet.Topology.DCEL
{
	public class DcelMesh
	{
		protected List<Vertex> vertices;

		protected List<HalfEdge> edges;

		protected List<Face> faces;

		public List<Vertex> Vertices
		{
			get
			{
				return null;
			}
		}

		public List<HalfEdge> HalfEdges
		{
			get
			{
				return null;
			}
		}

		public List<Face> Faces
		{
			get
			{
				return null;
			}
		}

		public IEnumerable<IEdge> Edges
		{
			get
			{
				return null;
			}
		}

		public DcelMesh()
			: base()
		{
		}

		protected DcelMesh(bool initialize)
			: this()
		{
		}

		public virtual bool IsConsistent(bool closed = true, int depth = 0)
		{
			return default(bool);
		}

		public void ResolveBoundaryEdges()
		{
		}

		protected virtual IEnumerable<IEdge> EnumerateEdges()
		{
			return null;
		}
	}
}
