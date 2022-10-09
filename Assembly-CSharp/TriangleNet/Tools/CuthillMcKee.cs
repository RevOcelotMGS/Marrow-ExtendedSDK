namespace TriangleNet.Tools
{
	public class CuthillMcKee
	{
		private AdjacencyMatrix matrix;

		public int[] Renumber(Mesh mesh)
		{
			return null;
		}

		public int[] Renumber(AdjacencyMatrix matrix)
		{
			return null;
		}

		private int[] GenerateRcm()
		{
			return null;
		}

		private void Rcm(int root, int[] mask, int[] perm, int offset, int iccsze)
		{
		}

		private void FindRoot(int root, int[] mask, int level_num, int[] level_row, int[] level, int offset)
		{
		}

		private void GetLevelSet(int root, int[] mask, int level_num, int[] level_row, int[] level, int offset)
		{
		}

		private void Degree(int root, int[] mask, int[] deg, int iccsze, int[] ls, int offset)
		{
		}

		private int PermBandwidth(int[] perm, int[] perm_inv)
		{
			return default(int);
		}

		private int[] PermInverse(int[] perm)
		{
			return null;
		}

		private void ReverseVector(int[] a, int offset, int size)
		{
		}

		private void Shift(int[] a, bool up)
		{
		}

		public CuthillMcKee()
			: base()
		{
		}
	}
}
