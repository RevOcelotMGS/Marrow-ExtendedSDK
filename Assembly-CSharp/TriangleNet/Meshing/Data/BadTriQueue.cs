using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Data
{
	internal class BadTriQueue
	{
		private const double SQRT2 = 1.4142135623730951;

		private BadTriangle[] queuefront;

		private BadTriangle[] queuetail;

		private int[] nextnonemptyq;

		private int firstnonemptyq;

		private int count;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public void Enqueue(BadTriangle badtri)
		{
		}

		public void Enqueue(Otri enqtri, double minedge, Vertex apex, Vertex org, Vertex dest)
		{
		}

		public BadTriangle Dequeue()
		{
			return null;
		}

		public BadTriQueue()
			: base()
		{
		}
	}
}
