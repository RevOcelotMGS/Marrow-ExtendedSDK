using UnityEngine;

namespace SLZ.VFX
{
	public class BendLine : MonoBehaviour
	{
		private LineRenderer mLineRenderer;

		public Transform start;

		public Transform end;

		private int count;

		private void Awake()
		{
		}

		public void ApplyLines(Vector3 direction)
		{
		}

		private Vector3 GetSplinePoint(float perc, Vector3 start, Vector3 startTangent, Vector3 endTangent, Vector3 end)
		{
			return default(Vector3);
		}

		public BendLine()
			: base()
		{
		}
	}
}
