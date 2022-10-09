using UnityEngine;
using UnityEngine.Splines;

namespace SLZ
{
	public class SplineTimeline : MonoBehaviour
	{
		public SplineData<SplineTimelineNode> points;

		private SplineContainer splineContainer;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public SplineContainer Container
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SplineTimeline()
			: base()
		{
		}
	}
}
