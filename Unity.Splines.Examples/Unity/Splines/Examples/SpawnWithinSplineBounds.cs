using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Splines;

namespace Unity.Splines.Examples
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class SpawnWithinSplineBounds : MonoBehaviour
	{
		private struct SpawnPoint
		{
			public float3 pos;

			public float3 right;

			public float3 up;
		}

		[SerializeField]
		private SplineContainer m_SplineContainer;

		[SerializeField]
		private Transform m_SpawnContainer;

		[SerializeField]
		private int m_MaxIterations;

		[Header("Spawning")]
		[SerializeField]
		private List<GameObject> m_Prefabs;

		[SerializeField]
		private float m_SpawnSpacing;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_SpawnChance;

		[SerializeField]
		private List<GameObject> m_BorderPrefabs;

		[SerializeField]
		private float m_BorderSpawnSpacing;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_BorderSpawnChance;

		[SerializeField]
		private SplineData<float> m_SpawnBorderData;

		[Header("Randomization")]
		[SerializeField]
		private int m_RandomSeed;

		[SerializeField]
		private Vector2 m_RotationRandomRange;

		private int m_Iterations;

		private List<Vector2> m_SplineSegments;

		private List<Vector2> m_ParentPointSegments;

		private const int k_SegmentsPerCurve = 10;

		public SplineContainer splineContainer
		{
			get
			{
				return null;
			}
		}

		public SplineData<float> spawnBorderData
		{
			get
			{
				return null;
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnValidate()
		{
		}

		private void CleanUp()
		{
		}

		private void OnSplineModified(Spline spline)
		{
		}

		private void SpawnObjectsWithinSpline(SplineContainer splineContainer, float spawnChance, float spawnSpacing, bool spawnOnBorder)
		{
		}

		private void SpawnObjectsForPoints(List<SpawnPoint> points, float spawnChance, float spawnSpacing, bool spawnOnBorder)
		{
		}

		private void SpawnRandomPrefab(List<GameObject> prefabs, Vector3 position, Vector3 forward, Vector3 up, float spawnChance)
		{
		}

		private void OnSpawnBorderDataChanged()
		{
		}

		private void BuildSplineSegments()
		{
		}

		private bool PointInsidePolygon(Vector2 point, List<Vector2> polygon)
		{
			return default(bool);
		}

		public SpawnWithinSplineBounds()
			: base()
		{
		}
	}
}
