using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;

namespace UnityEngine.AI
{
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	[AddComponentMenu("Navigation/NavMeshSurface", 30)]
	[DefaultExecutionOrder(-102)]
	[ExecuteAlways]
	public class NavMeshSurface : MonoBehaviour
	{
		[SerializeField]
		private int m_AgentTypeID;

		[SerializeField]
		private CollectObjects m_CollectObjects;

		[SerializeField]
		private Vector3 m_Size;

		[SerializeField]
		private Vector3 m_Center;

		[SerializeField]
		private LayerMask m_LayerMask;

		[SerializeField]
		private NavMeshCollectGeometry m_UseGeometry;

		[SerializeField]
		private int m_DefaultArea;

		[SerializeField]
		private bool m_IgnoreNavMeshAgent;

		[SerializeField]
		private bool m_IgnoreNavMeshObstacle;

		[SerializeField]
		private bool m_OverrideTileSize;

		[SerializeField]
		private int m_TileSize;

		[SerializeField]
		private bool m_OverrideVoxelSize;

		[SerializeField]
		private float m_VoxelSize;

		[SerializeField]
		private bool m_BuildHeightMesh;

		[FormerlySerializedAs("m_BakedNavMeshData")]
		[SerializeField]
		private NavMeshData m_NavMeshData;

		private NavMeshDataInstance m_NavMeshDataInstance;

		private Vector3 m_LastPosition;

		private Quaternion m_LastRotation;

		private static readonly List<NavMeshSurface> s_NavMeshSurfaces;

		public int agentTypeID
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public CollectObjects collectObjects
		{
			get
			{
				return default(CollectObjects);
			}
			set
			{
			}
		}

		public Vector3 size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 center
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public LayerMask layerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public NavMeshCollectGeometry useGeometry
		{
			get
			{
				return default(NavMeshCollectGeometry);
			}
			set
			{
			}
		}

		public int defaultArea
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool ignoreNavMeshAgent
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool ignoreNavMeshObstacle
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool overrideTileSize
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int tileSize
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool overrideVoxelSize
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float voxelSize
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool buildHeightMesh
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public NavMeshData navMeshData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static List<NavMeshSurface> activeSurfaces
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

		public void AddData()
		{
		}

		public void RemoveData()
		{
		}

		public NavMeshBuildSettings GetBuildSettings()
		{
			return default(NavMeshBuildSettings);
		}

		public void BuildNavMesh()
		{
		}

		public AsyncOperation UpdateNavMesh(NavMeshData data)
		{
			return null;
		}

		private static void Register(NavMeshSurface surface)
		{
		}

		private static void Unregister(NavMeshSurface surface)
		{
		}

		private static void UpdateActive()
		{
		}

		private void AppendModifierVolumes(List<NavMeshBuildSource> sources)
		{
		}

		private List<NavMeshBuildSource> CollectSources()
		{
			return null;
		}

		private static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds)
		{
			return default(Bounds);
		}

		private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources)
		{
			return default(Bounds);
		}

		private bool HasTransformChanged()
		{
			return default(bool);
		}

		private void UpdateDataIfTransformChanged()
		{
		}

		public NavMeshSurface()
			: base()
		{
		}
	}
}
