using UnityEngine;
using UnityEngine.Splines;

namespace samples.Runtime
{
	[RequireComponent(typeof(SplineExtrude))]
	internal class AnimateSplineExtrude : MonoBehaviour
	{
		private SplineExtrude m_Extrude;

		[SerializeField]
		[Range(0.0001f, 2f)]
		private float m_Speed;

		private float m_Span;

		[SerializeField]
		private bool m_RebuildExtrudeOnUpdate;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public AnimateSplineExtrude()
			: base()
		{
		}
	}
}
