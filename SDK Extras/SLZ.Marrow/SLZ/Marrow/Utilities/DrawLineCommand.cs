using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public struct DrawLineCommand
	{
		public float startTime;

		public float duration;

		public Vector3[] verticies;

		public Color[] colors;

		public int[] indicies;

		public bool isDrawOnce;

		public void Draw(Vector3 start, Vector3 end, Color color, float startTime, float duration, bool isDrawOnce)
		{
		}

		public void CopyToBuffers(int startBufferIndex, [In] Vector3[] verticies, [In] Color[] colors, [In] int[] indicies, int vertLength)
		{
		}

		public void CopyToCommand(DrawLineCommand other)
		{
		}
	}
}
