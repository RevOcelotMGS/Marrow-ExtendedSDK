using UnityEngine;
using UnityEngine.Splines;

namespace Unity.Splines.Examples.Editor
{
	[RequireComponent(typeof(SplineContainer))]
	internal class SplineOscillator : MonoBehaviour
	{
		private Spline m_Spline;

		private BezierKnot[] m_Origins;

		[SerializeField]
		[Range(0.1f, 10f)]
		private float m_Speed;

		[SerializeField]
		[Range(1f, 10f)]
		private float m_Frequency;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public SplineOscillator()
			: base()
		{
		}
	}
}
