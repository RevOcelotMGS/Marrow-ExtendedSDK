using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SplineMesh
{
	[RequireComponent(typeof(MeshFilter))]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(MeshRenderer))]
	public class ExtrusionSegment : MonoBehaviour
	{
		[Serializable]
		public class Vertex
		{
			public Vector2 point;

			public Vector2 normal;

			public float uCoord;

			public Vertex(Vector2 point, Vector2 normal, float uCoord)
				: base()
			{
			}

			public Vertex(Vertex other)
				: base()
			{
			}
		}

		private bool isDirty;

		private MeshFilter mf;

		private Mesh result;

		private bool useSpline;

		private CubicBezierCurve curve;

		private Spline spline;

		private float intervalStart;

		private float intervalEnd;

		private List<Vertex> shapeVertices;

		private float textureScale;

		private float textureOffset;

		private float sampleSpacing;

		public List<Vertex> ShapeVertices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float TextureScale
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float TextureOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float SampleSpacing
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		public void SetInterval(CubicBezierCurve curve)
		{
		}

		public void SetInterval(Spline spline, float intervalStart, float intervalEnd = 0f)
		{
		}

		private void SetDirty()
		{
		}

		private void LateUpdate()
		{
		}

		public void ComputeIfNeeded()
		{
		}

		private List<CurveSample> GetPath()
		{
			return null;
		}

		public void Compute()
		{
		}

		public ExtrusionSegment()
			: base()
		{
		}
	}
}
