using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RayFire
{
	[HelpURL("http://rayfirestudios.com/unity-online-help/components/unity-cluster-component/")]
	[SelectionBase]
	[AddComponentMenu("RayFire/Rayfire Cluster")]
	public class RayfireCluster : MonoBehaviour
	{
		public enum ClusterType
		{
			ByPointCloud = 0,
			BySharedArea = 1
		}

		[Space(2f)]
		[Header("  Properties")]
		[Space(2f)]
		public ClusterType type;

		[Range(1f, 7f)]
		public int depth;

		[Range(0f, 100f)]
		public int seed;

		[Range(0f, 4f)]
		public int smoothPass;

		[Space(2f)]
		[Header("  By Point Cloud")]
		[Range(2f, 100f)]
		public int baseAmount;

		[Range(2f, 50f)]
		public int depthAmount;

		public ConnectivityType connectivity;

		[Header("  By Shared Area")]
		[Range(2f, 8f)]
		[Space(2f)]
		public int minimumAmount;

		[Range(2f, 8f)]
		public int maximumAmount;

		[HideInInspector]
		public bool showGizmo;

		[HideInInspector]
		public bool colorPreview;

		[HideInInspector]
		public bool scalePreview;

		[HideInInspector]
		public Color wireColor;

		[HideInInspector]
		public float previewScale;

		[HideInInspector]
		public List<RFCluster> allClusters;

		[HideInInspector]
		public List<RFShard> allShards;

		private int clusterId;

		public void Extract()
		{
		}

		public void Clusterize()
		{
		}

		private void ClusterizeVoronoi()
		{
		}

		private List<RFCluster> ClusterizeClusterByAmount(RFCluster parentCluster, int amount)
		{
			return null;
		}

		private void ConnectivityCheck(List<RFCluster> childClusters)
		{
		}

		private void ClusterizeRange()
		{
		}

		private List<RFCluster> ClusterizeRangeShards(RFCluster mainCluster)
		{
			return null;
		}

		private List<RFCluster> ClusterizeRangeClusters(RFCluster parentCluster)
		{
			return null;
		}

		private static void RoughnessPassShards(List<RFCluster> clusters)
		{
		}

		private void RoughnessPassClusters(List<RFCluster> clusters)
		{
		}

		private void SetSoloShardToCluster(List<RFShard> soloShards, List<RFCluster> childClusters)
		{
		}

		private int GetNeibIndArea(RFShard shard, List<RFShard> shardList = default(List<RFShard>))
		{
			return default(int);
		}

		private void SetSoloClusterToCluster(List<RFCluster> soloClusters, List<RFCluster> childClusters)
		{
		}

		private RFCluster SetupMainCluster(ConnectivityType connect)
		{
			return null;
		}

		private void SetClusterNames()
		{
		}

		private void CreateRoot(RFCluster childCluster, Transform parentTm)
		{
		}

		private Bounds GetShardsBound(List<RFShard> shards, List<RFCluster> clusters = default(List<RFCluster>))
		{
			return default(Bounds);
		}

		private static RFShard GetNeibShardArea(List<RFShard> shardGroup, List<RFShard> shardList)
		{
			return null;
		}

		private List<Vector3> VoronoiPointCloud(Bounds bound, int am)
		{
			return null;
		}

		public RayfireCluster()
			: base()
		{
		}
	}
}
