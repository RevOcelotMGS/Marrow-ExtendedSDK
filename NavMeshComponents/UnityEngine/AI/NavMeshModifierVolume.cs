using System.Collections.Generic;

namespace UnityEngine.AI
{
	[AddComponentMenu("Navigation/NavMeshModifierVolume", 31)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	[ExecuteInEditMode]
	public class NavMeshModifierVolume : MonoBehaviour
	{
		[SerializeField]
		private Vector3 m_Size;

		[SerializeField]
		private Vector3 m_Center;

		[SerializeField]
		private int m_Area;

		[SerializeField]
		private List<int> m_AffectedAgents;

		private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers;

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

		public static List<NavMeshModifierVolume> activeModifiers
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

		public bool AffectsAgentType(int agentTypeID)
		{
			return default(bool);
		}

		public NavMeshModifierVolume()
			: base()
		{
		}
	}
}
