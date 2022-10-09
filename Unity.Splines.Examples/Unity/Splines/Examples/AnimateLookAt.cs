using UnityEngine;
using UnityEngine.Splines;

namespace Unity.Splines.Examples
{
	public class AnimateLookAt : MonoBehaviour
	{
		[SerializeField]
		private SplineAnimate m_SplineAnimate;

		[SerializeField]
		private PointSplineData m_LookAtPoints;

		[SerializeField]
		private Transform m_LookTransform;

		private void LateUpdate()
		{
		}

		public AnimateLookAt()
			: base()
		{
		}
	}
}
