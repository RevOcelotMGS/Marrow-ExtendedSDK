using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

namespace Unity.Splines.Examples
{
	[RequireComponent(typeof(SplineContainer), typeof(MeshRenderer), typeof(MeshFilter))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class LoftRoadBehaviour : MonoBehaviour
	{
		[SerializeField]
		private SplineContainer m_Spline;

		[SerializeField]
		private int m_SegmentsPerMeter;

		[SerializeField]
		private Mesh m_Mesh;

		[SerializeField]
		private float m_TextureScale;

		private WidthSplineData m_WidthData;

		private List<Vector3> m_Positions;

		private List<Vector3> m_Normals;

		private List<Vector2> m_Textures;

		private List<int> m_Indices;

		private WidthSplineData widthData
		{
			get
			{
				return null;
			}
		}

		public Spline spline
		{
			get
			{
				return null;
			}
		}

		public Mesh mesh
		{
			get
			{
				return null;
			}
		}

		public int segmentsPerMeter
		{
			get
			{
				return default(int);
			}
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void OnAfterSplineWasModified(Spline s)
		{
		}

		private void OnAfterSplineDataWasModified(SplineData<float> splineData)
		{
		}

		public void Loft()
		{
		}

		public LoftRoadBehaviour()
			: base()
		{
		}
	}
}
