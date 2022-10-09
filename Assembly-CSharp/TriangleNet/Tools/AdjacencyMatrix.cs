namespace TriangleNet.Tools
{
	public class AdjacencyMatrix
	{
		private int nnz;

		private int[] pcol;

		private int[] irow;

		public readonly int N;

		public int[] ColumnPointers
		{
			get
			{
				return null;
			}
		}

		public int[] RowIndices
		{
			get
			{
				return null;
			}
		}

		public AdjacencyMatrix(Mesh mesh)
			: base()
		{
		}

		public AdjacencyMatrix(int[] pcol, int[] irow)
			: base()
		{
		}

		public int Bandwidth()
		{
			return default(int);
		}

		private int[] AdjacencyCount(Mesh mesh)
		{
			return null;
		}

		private int[] AdjacencySet(Mesh mesh, int[] pcol)
		{
			return null;
		}

		public void SortIndices()
		{
		}
	}
}
