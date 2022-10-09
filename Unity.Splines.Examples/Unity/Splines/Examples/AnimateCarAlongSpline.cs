using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Splines;

namespace Unity.Splines.Examples
{
	public class AnimateCarAlongSpline : MonoBehaviour
	{
		[SerializeField]
		private SplineContainer m_SplineContainer;

		[SerializeField]
		private Car m_CarToAnimate;

		[Min(0f)]
		public float m_DefaultSpeed;

		[Min(0f)]
		public float m_MaxSpeed;

		[SerializeField]
		private SplineData<float> m_Speed;

		public Vector3 m_DefaultTilt;

		[SerializeField]
		private SplineData<float3> m_Tilt;

		[SerializeField]
		private DriftSplineData m_Drift;

		[SerializeField]
		private PointSplineData m_LookAtPoints;

		[SerializeField]
		private Transform m_LookTransform;

		private float m_CurrentOffset;

		private float m_CurrentSpeed;

		private float m_SplineLength;

		private Spline m_Spline;

		public SplineContainer splineContainer
		{
			get
			{
				return null;
			}
		}

		public SplineData<float> speed
		{
			get
			{
				return null;
			}
		}

		public SplineData<float3> tilt
		{
			get
			{
				return null;
			}
		}

		public DriftSplineData driftData
		{
			get
			{
				return null;
			}
		}

		public PointSplineData lookAtPoints
		{
			get
			{
				return null;
			}
		}

		public void Initialize()
		{
		}

		private void Start()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		public AnimateCarAlongSpline()
			: base()
		{
		}
	}
}
