using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SplineMesh;
using UnityEngine;

namespace SLZ
{
	public class CurveSegment
	{
		private CurveSample _sampleA;

		private Vector3 _binormalA;

		private Vector3 _normalA;

		private CurveSample _sampleB;

		private Vector3 _binormalB;

		private Vector3 _normalB;

		private float _scale;

		public float Distance { get; private set; }

		public Vector3 Direction { get; private set; }

		public Vector3 Location
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 Normal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 Tangent
		{
			get
			{
				return default(Vector3);
			}
		}

		public CurveSample SampleA
		{
			get
			{
				return default(CurveSample);
			}
		}

		public CurveSegment(CurveSample sampleA, CurveSample sampleB)
			: base()
		{
		}

		public CurveSample GetFirstSample(Transform parent = default(Transform))
		{
			return default(CurveSample);
		}

		public CurveSample GetSampleFromPoint(Vector3 position, Transform parent = default(Transform))
		{
			return default(CurveSample);
		}
	}
}
