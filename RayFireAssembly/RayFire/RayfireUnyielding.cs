using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[AddComponentMenu("RayFire/Rayfire Unyielding")]
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-unyielding-component/")]
	public class RayfireUnyielding : MonoBehaviour
	{
		public enum UnySimType
		{
			Original = 1,
			Inactive = 2,
			Kinematic = 3
		}

		public bool unyielding;

		public bool activatable;

		public UnySimType simulationType;

		public Vector3 centerPosition;

		public Vector3 size;

		public RayfireRigid rigidHost;

		public List<RayfireRigid> rigidList;

		public List<RFShard> shardList;

		public bool showGizmo;

		public bool showCenter;

		private bool HasRigids
		{
			get
			{
				return default(bool);
			}
		}

		private bool HasShards
		{
			get
			{
				return default(bool);
			}
		}

		public Vector3 Extents
		{
			get
			{
				return default(Vector3);
			}
		}

		public static void ClusterSetup(RayfireRigid rigid)
		{
		}

		private static void ClusterOverlap(RayfireUnyielding uny)
		{
		}

		private static int ClusterLayerMask(RayfireRigid rigid)
		{
			return default(int);
		}

		private static void SetShardUnyState(RFShard shard, bool unyielding, bool activatable)
		{
		}

		public static void MeshRootSetup(RayfireRigid mRoot)
		{
		}

		private static List<RayfireUnyielding> GetUnyList(Transform tm)
		{
			return null;
		}

		private static void SetMeshRootUnyRigidList(RayfireRigid mRoot, RayfireUnyielding uny)
		{
		}

		private static int MeshRootLayerMask(RayfireRigid mRoot)
		{
			return default(int);
		}

		public static void SetMeshRootUny(Transform tm, List<RayfireUnyielding> unyList)
		{
		}

		private static void SetRigidUnyState(RayfireUnyielding uny)
		{
		}

		private static void SetRigidUnySim(RayfireUnyielding uny)
		{
		}

		public static void SetUnyieldingFragments(RayfireRigid scr)
		{
		}

		private static void SetRigidUnyState(RayfireRigid rigid, bool uny, bool act)
		{
		}

		private static void CopyUny(RayfireUnyielding source, GameObject target)
		{
		}

		public void GetRigidRootUnyShardList(RayfireRigidRoot rigidRoot)
		{
		}

		public void SetRigidRootUnyShardList()
		{
		}

		public void Activate()
		{
		}

		public RayfireUnyielding()
			: base()
		{
		}
	}
}
