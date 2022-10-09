using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFCluster : IComparable<RFCluster>
	{
		public int id;

		public Transform tm;

		[HideInInspector]
		public int depth;

		[HideInInspector]
		public Vector3 pos;

		[HideInInspector]
		public Quaternion rot;

		[HideInInspector]
		public Vector3 scl;

		[HideInInspector]
		public Bounds bound;

		[HideInInspector]
		public bool demolishable;

		[HideInInspector]
		public RayfireRigid rigid;

		[HideInInspector]
		public List<RFShard> shards;

		[HideInInspector]
		public float areaCollapse;

		[HideInInspector]
		public float minimumArea;

		[HideInInspector]
		public float maximumArea;

		[HideInInspector]
		public float sizeCollapse;

		[HideInInspector]
		public float minimumSize;

		[HideInInspector]
		public float maximumSize;

		[HideInInspector]
		public int randomCollapse;

		[HideInInspector]
		public int randomSeed;

		[HideInInspector]
		public bool cachedHost;

		[NonSerialized]
		public bool initialized;

		[NonSerialized]
		public RFCluster mainCluster;

		[NonSerialized]
		public List<RFCluster> childClusters;

		[NonSerialized]
		public List<RFCluster> neibClusters;

		[NonSerialized]
		public List<float> neibArea;

		[NonSerialized]
		public List<float> neibPerc;

		[NonSerialized]
		private List<RFShard> checkShards;

		[NonSerialized]
		private List<RFShard> newClusterShards;

		public bool HasChildClusters
		{
			get
			{
				return default(bool);
			}
		}

		public bool UnyieldingByShard
		{
			get
			{
				return default(bool);
			}
		}

		public bool UnyieldingByRigid
		{
			get
			{
				return default(bool);
			}
		}

		public RFCluster()
			: base()
		{
		}

		public RFCluster(RFCluster source)
			: this()
		{
		}

		public int CompareTo(RFCluster otherCluster)
		{
			return default(int);
		}

		public static void InitCluster(RayfireRigid scr, RFCluster cluster)
		{
		}

		private static void InitConnectedCluster(RFCluster cluster)
		{
		}

		private static void InitNestedCluster(RayfireRigid scr, RFCluster cluster)
		{
		}

		public static void ConnectivityUnyCheck(RFCluster cluster)
		{
		}

		public static void ConnectivityCheck(RFCluster cluster)
		{
		}

		public static void NewClusterByShards(RFCluster mainCLuster, List<RFShard> shards)
		{
		}

		public void AddChildCluster(RFCluster cluster)
		{
		}

		public static void ReduceChildClusters(RFCluster cluster)
		{
		}

		public static Bounds GetChildrenBound(Transform tm)
		{
			return default(Bounds);
		}

		public static Bounds GetClusterBound(RFCluster cluster)
		{
			return default(Bounds);
		}

		public static Bounds GetBoundsBound(List<Bounds> bounds)
		{
			return default(Bounds);
		}

		public static Bounds GetShardsBound(List<RFShard> shards)
		{
			return default(Bounds);
		}

		public static Bounds GetShardsBoundByPosition(List<RFShard> shards)
		{
			return default(Bounds);
		}

		public static int GetBiggestCluster(List<RFCluster> clusters)
		{
			return default(int);
		}

		public static void GetSoloShards(RFCluster cluster, List<RFShard> soloShards)
		{
		}

		public static int GetUniqClusterId(RFCluster cluster)
		{
			return default(int);
		}

		public static bool IntegrityCheck(RFCluster cluster)
		{
			return default(bool);
		}

		public static void CreateClusterRoot(RFCluster cluster, Vector3 pos, Quaternion rot, int layer, string tag, string nm)
		{
		}

		private List<RFShard> GetNestedShards(bool OwnShards = false)
		{
			return null;
		}

		public List<RFCluster> GetNestedClusters()
		{
			return null;
		}

		private bool TrisNeib(RFCluster otherCluster)
		{
			return default(bool);
		}

		private float NeibArea(RFCluster otherCluster)
		{
			return default(float);
		}

		public int GetNeibIndArea(List<RFCluster> clusterList = default(List<RFCluster>))
		{
			return default(int);
		}

		public static void SetClusterNeib(List<RFCluster> clusters, bool connectivity)
		{
		}

		public static RFCluster GetNeibClusterArea(List<RFCluster> clusters, List<RFCluster> clusterList)
		{
			return null;
		}
	}
}
