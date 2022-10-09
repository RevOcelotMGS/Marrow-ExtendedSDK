using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Splines;

namespace Unity.Splines.Examples
{
	public class PointSplineData : MonoBehaviour
	{
		[SerializeField]
		private SplineData<float2> m_Points;

		private SplineContainer m_SplineContainer;

		public SplineData<float2> points
		{
			get
			{
				return null;
			}
		}

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public SplineContainer container
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PointSplineData()
			: base()
		{
		}
	}
}
