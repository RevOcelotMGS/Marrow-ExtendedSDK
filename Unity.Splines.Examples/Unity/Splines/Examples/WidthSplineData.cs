using UnityEngine;
using UnityEngine.Splines;

namespace Unity.Splines.Examples
{
	public class WidthSplineData : MonoBehaviour
	{
		public float m_DefaultWidth;

		[SerializeField]
		private SplineData<float> m_Width;

		private SplineContainer m_SplineContainer;

		public SplineData<float> width
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

		public WidthSplineData()
			: base()
		{
		}
	}
}
