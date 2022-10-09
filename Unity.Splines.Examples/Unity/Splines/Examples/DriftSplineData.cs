using UnityEngine;
using UnityEngine.Splines;

namespace Unity.Splines.Examples
{
	public class DriftSplineData : MonoBehaviour
	{
		public float m_Default;

		[SerializeField]
		private SplineData<float> m_Drift;

		private SplineContainer m_SplineContainer;

		public SplineData<float> drift
		{
			get
			{
				return null;
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

		public DriftSplineData()
			: base()
		{
		}
	}
}
