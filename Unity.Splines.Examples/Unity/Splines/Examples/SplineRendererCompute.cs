using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Splines;

namespace Unity.Splines.Examples
{
	[RequireComponent(typeof(LineRenderer), typeof(SplineContainer))]
	public class SplineRendererCompute : MonoBehaviour
	{
		[SerializeField]
		private ComputeShader m_ComputeShader;

		[Range(16f, 512f)]
		[SerializeField]
		private int m_Segments;

		private Spline m_Spline;

		private LineRenderer m_Line;

		private bool m_Dirty;

		private SplineComputeBufferScope<Spline> m_SplineBuffers;

		private Vector3[] m_Positions;

		private ComputeBuffer m_PositionsBuffer;

		private int m_GetPositionsKernel;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public SplineRendererCompute()
			: base()
		{
		}
	}
}
