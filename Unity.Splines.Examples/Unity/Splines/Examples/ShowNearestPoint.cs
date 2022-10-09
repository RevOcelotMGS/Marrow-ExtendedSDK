using UnityEngine;
using UnityEngine.Splines;

namespace Unity.Splines.Examples
{
	[RequireComponent(typeof(LineRenderer))]
	public class ShowNearestPoint : MonoBehaviour
	{
		private Vector3 m_Center;

		private float m_Size;

		private SplineContainer[] m_SplineContainer;

		private LineRenderer m_LineRenderer;

		[SerializeField]
		private Transform m_NearestPoint;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private Vector3 CalculatePosition()
		{
			return default(Vector3);
		}

		private void OnDrawGizmosSelected()
		{
		}

		public ShowNearestPoint()
			: base()
		{
		}
	}
}
