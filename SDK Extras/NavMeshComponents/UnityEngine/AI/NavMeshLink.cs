using System.Collections.Generic;

namespace UnityEngine.AI
{
	[ExecuteInEditMode]
	[DefaultExecutionOrder(-101)]
	[AddComponentMenu("Navigation/NavMeshLink", 33)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshLink : MonoBehaviour
	{
		[SerializeField]
		private int m_AgentTypeID;

		[SerializeField]
		private Vector3 m_StartPoint;

		[SerializeField]
		private Vector3 m_EndPoint;

		[SerializeField]
		private float m_Width;

		[SerializeField]
		private int m_CostModifier;

		[SerializeField]
		private bool m_Bidirectional;

		[SerializeField]
		private bool m_AutoUpdatePosition;

		[SerializeField]
		private int m_Area;

		private NavMeshLinkInstance m_LinkInstance;

		private Vector3 m_LastPosition;

		private Quaternion m_LastRotation;

		private static readonly List<NavMeshLink> s_Tracked;

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

		public Vector3 startPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 endPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float width
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int costModifier
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool bidirectional
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool autoUpdate
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int area
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateLink()
		{
		}

		private static void AddTracking(NavMeshLink link)
		{
		}

		private static void RemoveTracking(NavMeshLink link)
		{
		}

		private void SetAutoUpdate(bool value)
		{
		}

		private void AddLink()
		{
		}

		private bool HasTransformChanged()
		{
			return default(bool);
		}

		private void OnDidApplyAnimationProperties()
		{
		}

		private static void UpdateTrackedInstances()
		{
		}

		public NavMeshLink()
			: base()
		{
		}
	}
}
