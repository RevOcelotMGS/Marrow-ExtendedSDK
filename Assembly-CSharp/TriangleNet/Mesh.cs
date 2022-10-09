using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TriangleNet.Geometry;
using TriangleNet.Logging;
using TriangleNet.Meshing;
using TriangleNet.Meshing.Iterators;
using TriangleNet.Topology;

namespace TriangleNet
{
	public class Mesh : IMesh
	{
		private IPredicates predicates;

		private ILog<LogItem> logger;

		private QualityMesher qualityMesher;

		private Stack<Otri> flipstack;

		internal TrianglePool triangles;

		internal Dictionary<int, SubSegment> subsegs;

		internal Dictionary<int, Vertex> vertices;

		internal int hash_vtx;

		internal int hash_seg;

		internal int hash_tri;

		internal List<Point> holes;

		internal List<RegionPointer> regions;

		internal Rectangle bounds;

		internal int invertices;

		internal int insegments;

		internal int undeads;

		internal int mesh_dim;

		internal int nextras;

		internal int hullsize;

		internal int steinerleft;

		internal bool checksegments;

		internal bool checkquality;

		internal Vertex infvertex1;

		internal Vertex infvertex2;

		internal Vertex infvertex3;

		internal TriangleLocator locator;

		internal Behavior behavior;

		internal NodeNumbering numbering;

		internal const int DUMMY = -1;

		internal Triangle dummytri;

		internal SubSegment dummysub;

		public Rectangle Bounds
		{
			get
			{
				return null;
			}
		}

		public ICollection<Vertex> Vertices
		{
			get
			{
				return null;
			}
		}

		public IList<Point> Holes
		{
			get
			{
				return null;
			}
		}

		public ICollection<Triangle> Triangles
		{
			get
			{
				return null;
			}
		}

		public ICollection<SubSegment> Segments
		{
			get
			{
				return null;
			}
		}

		public IEnumerable<Edge> Edges
		{
			[IteratorStateMachine(typeof(_003Cget_Edges_003Ed__39))]
			get
			{
				return null;
			}
		}

		public int NumberOfInputPoints
		{
			get
			{
				return default(int);
			}
		}

		public int NumberOfEdges
		{
			get
			{
				return default(int);
			}
		}

		public bool IsPolygon
		{
			get
			{
				return default(bool);
			}
		}

		public NodeNumbering CurrentNumbering
		{
			get
			{
				return default(NodeNumbering);
			}
		}

		private void Initialize()
		{
		}

		public Mesh(Configuration config)
			: base()
		{
		}

		public void Refine(QualityOptions quality, bool delaunay = false)
		{
		}

		public void Renumber()
		{
		}

		public void Renumber(NodeNumbering num)
		{
		}

		internal void SetQualityMesher(QualityMesher qmesher)
		{
		}

		internal void CopyTo(Mesh target)
		{
		}

		private void ResetData()
		{
		}

		private void Reset()
		{
		}

		internal void TransferNodes(IList<Vertex> points)
		{
		}

		internal void MakeVertexMap()
		{
		}

		internal void MakeTriangle(Otri newotri)
		{
		}

		internal void MakeSegment(Osub newsubseg)
		{
		}

		internal InsertVertexResult InsertVertex(Vertex newvertex, Otri searchtri, Osub splitseg, bool segmentflaws, bool triflaws)
		{
			return default(InsertVertexResult);
		}

		internal void InsertSubseg(Otri tri, int subsegmark)
		{
		}

		internal void Flip(Otri flipedge)
		{
		}

		internal void Unflip(Otri flipedge)
		{
		}

		private void TriangulatePolygon(Otri firstedge, Otri lastedge, int edgecount, bool doflip, bool triflaws)
		{
		}

		internal void DeleteVertex(Otri deltri)
		{
		}

		internal void UndoVertex()
		{
		}

		internal void TriangleDealloc(Triangle dyingtriangle)
		{
		}

		internal void VertexDealloc(Vertex dyingvertex)
		{
		}

		internal void SubsegDealloc(SubSegment dyingsubseg)
		{
		}
	}
}
