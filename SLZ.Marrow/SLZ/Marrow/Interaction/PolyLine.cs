using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Splines;

namespace SLZ.Marrow.Interaction
{
	[RequireComponent(typeof(SplineContainer))]
	public class PolyLine : MonoBehaviour
	{
		private static readonly float LINEAR_LOOKUP_MIN_DIST;

		[SerializeField]
		public PolyLineData lineData;

		private PolyLineVert[] _polyVerts;

		private float _segmentDistance;

		private float _totalDistance;

		private bool _isBaked;

		[SerializeField]
		private SplineContainer _splineContainer;

		public SplineContainer SplineContainer
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public int GetNearestPoint(float3 worldPos, [Out] float3 position, [Out] float3 tangent, [Out] float3 normal)
		{
			return default(int);
		}

		public int GetPointAtLinearDistance(float3 worldPos, float distance, [Out] float3 position, [Out] float3 tangent, [Out] float3 normal, int startIndex = 0)
		{
			return default(int);
		}

		public int GetNearestPointFromIndex(float3 worldPos, [Out] float3 position, [Out] float3 tangent, [Out] float3 normal, int startIndex = 0)
		{
			return default(int);
		}

		public bool IsACappedIndex(int index)
		{
			return default(bool);
		}

		public void GetPointAtIndex(int index, [Out] float3 position, [Out] float3 tangent, [Out] float3 normal)
		{
		}

		private int GetNearestVertWithinRange(float3 localPos, int start, int end, [Out] int interval, uint intervalDivision = 1u)
		{
			return default(int);
		}

		public static int Mod(int i, int max)
		{
			return default(int);
		}

		private void Reset()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void DrawSplineGizmo()
		{
		}

		public PolyLine()
			: base()
		{
		}
	}
}
