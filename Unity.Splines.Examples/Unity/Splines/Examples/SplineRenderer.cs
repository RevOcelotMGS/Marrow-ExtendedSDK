using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Splines;

namespace Unity.Splines.Examples
{
	[RequireComponent(typeof(LineRenderer), typeof(SplineContainer))]
	public class SplineRenderer : MonoBehaviour
	{
		private Spline m_Spline;

		private LineRenderer m_Line;

		private bool m_Dirty;

		private Vector3[] m_Points;

		[Range(16f, 512f)]
		[SerializeField]
		private int m_Segments;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public SplineRenderer()
			: base()
		{
		}
	}
}
