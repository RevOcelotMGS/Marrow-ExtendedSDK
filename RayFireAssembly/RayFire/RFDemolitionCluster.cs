using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFDemolitionCluster
	{
		public enum RFDetachType
		{
			RatioToSize = 0,
			WorldUnits = 3
		}

		public ConnectivityType connectivity;

		public float minimumArea;

		public float minimumSize;

		public int percentage;

		public int seed;

		public RFDetachType type;

		public int ratio;

		public float units;

		public int shardArea;

		public bool shardDemolition;

		public int minAmount;

		public int maxAmount;

		public bool demolishable;

		public RFCollapse collapse;

		public int clsCount;

		public RFCluster cluster;

		public List<RFCluster> minorClusters;

		public bool cn;

		public bool nd;

		public int am;

		[NonSerialized]
		public RFBackupCluster backup;

		[NonSerialized]
		public float damageRadius;

		public static string nameApp;

		public bool HasChildClusters
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasMinorClusters
		{
			get
			{
				return default(bool);
			}
		}

		public void CopyFrom(RFDemolitionCluster demolition)
		{
		}

		public void Reset()
		{
		}

		public static void ResetClusterize(RayfireRigid scr)
		{
		}

		public static void ClusterizeEditor(RayfireRigid scr)
		{
		}

		public static void Clusterize(RayfireRigid scr)
		{
		}

		private static void ClusterizeConnected(RayfireRigid scr)
		{
		}

		private static void ClusterizeNested(RayfireRigid scr)
		{
		}

		private static void ClusterizeNestedRecursive(RayfireRigid scr, Transform transform, RFCluster cluster, ConnectivityType connectivity)
		{
		}

		public static bool DemolishCluster(RayfireRigid scr)
		{
			return default(bool);
		}

		public static List<RFShard> DemolishConnectedCluster(RayfireRigid scr, Collider[] detachColliders = default(Collider[]))
		{
			return null;
		}

		private static Collider[] GetDetachColliders(RayfireRigid scr)
		{
			return null;
		}

		private static List<RFShard> DetachShardsByColliders(RayfireRigid scr, Collider[] detachColliders)
		{
			return null;
		}

		private static void DemolishNestedCluster(RayfireRigid scr)
		{
		}

		public static void PostDemolitionCluster(RayfireRigid scr, List<RFShard> detachShards)
		{
		}

		private static void SetupDetachShards(RayfireRigid scr, List<RFShard> detachShards)
		{
		}

		private static void CreateChildClusters(RayfireRigid scr, List<RFCluster> childClusters)
		{
		}

		private static void UpdateOriginalCluster(RayfireRigid scr)
		{
		}

		public static void SliceConnectedCluster(RayfireRigid scr)
		{
		}

		private static void SetupPlaneShards(RayfireRigid scr, List<RFShard> clusterShards, List<RFShard> detachShards)
		{
		}

		private static void ClusterizeDetachShards(RayfireRigid scr, List<RFShard> detachShards, int clusterAmount, int sortType)
		{
		}

		public static void CreateClusterRuntime(RayfireRigid scr, RFCluster cluster)
		{
		}

		private static void DivideAllShards(RFCluster cluster, List<RFShard> detachShards, int amount)
		{
		}

		private static void DivideShards(RFCluster mainCluster, RFCluster childCluster)
		{
		}

		public static void DetachEdgeShards(RFCluster cluster, List<RFShard> detachShards, int edgeShardArea)
		{
		}

		private static void DetachOneNeibShards(List<RFCluster> childClusters, List<RFShard> detachShards, int edgeAmount, int startIndex)
		{
		}

		private static void DetachOneNeibShard(RFCluster cls, List<RFShard> detachShards)
		{
		}

		private static void AddRigidComponent(RayfireRigid scr, List<RFShard> shardList)
		{
		}

		private static void AddRigidComponent(RayfireRigid scr, RFShard shard, Transform parent)
		{
		}

		private static void SetRigidRootShard(RayfireRigid scr, List<RFShard> shards)
		{
		}

		private static bool SameClusterCheck(RayfireRigid scr, List<RFShard> detachShards, int shardAmount, int clusterAmount)
		{
			return default(bool);
		}

		public RFDemolitionCluster()
			: base()
		{
		}
	}
}
