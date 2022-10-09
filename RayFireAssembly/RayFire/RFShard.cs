using System;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFShard : IComparable<RFShard>
	{
		public int id;

		public float sz;

		public bool uny;

		public bool act;

		public Bounds bnd;

		public Vector3 pos;

		public SimType sm;

		[NonSerialized]
		public Quaternion rot;

		[NonSerialized]
		public Vector3 scl;

		[NonSerialized]
		public Vector3 los;

		[NonSerialized]
		public float m;

		public int nAm;

		public List<int> nIds;

		public List<float> nArea;

		public List<int> sIds;

		public List<float> nSt;

		public float sSt;

		public Transform tm;

		public MeshFilter mf;

		public Collider col;

		public Rigidbody rb;

		public RayfireRigid rigid;

		[NonSerialized]
		public int fade;

		[NonSerialized]
		public float fo;

		[NonSerialized]
		public List<RFTriangle> tris;

		[NonSerialized]
		public List<RFFace> poly;

		[NonSerialized]
		public RFCluster cluster;

		[NonSerialized]
		public List<RFShard> neibShards;

		[NonSerialized]
		public bool check;

		[NonSerialized]
		public bool[] sCheck;

		public bool StressState
		{
			get
			{
				return default(bool);
			}
		}

		public bool SupportState
		{
			get
			{
				return default(bool);
			}
		}

		public bool InactiveOrKinematic
		{
			get
			{
				return default(bool);
			}
		}

		public RFShard()
			: base()
		{
		}

		public RFShard(RFShard source)
			: this()
		{
		}

		public RFShard(Transform Tm)
			: this()
		{
		}

		public RFShard(RayfireRigid scr)
			: this()
		{
		}

		public int CompareTo(RFShard otherShard)
		{
			return default(int);
		}

		public static void SetMeshData(List<RFShard> shards, ConnectivityType type)
		{
		}

		public static void SetMeshData(RFShard shard, ConnectivityType type)
		{
		}

		public static void SetShards(RFCluster cluster, ConnectivityType connectivity, bool setRigid = false)
		{
		}

		public static void SetShardsByTransformList(RFCluster cluster, List<Transform> tmList, ConnectivityType connectivity, bool setRigid = false)
		{
		}

		public static void SetShardsByRigidList(RFCluster cluster, List<RayfireRigid> rigids, ConnectivityType connectivity)
		{
		}

		private float NeibAreaByPoly(RFShard otherShard)
		{
			return default(float);
		}

		private float NeibAreaByTris(RFShard otherShard)
		{
			return default(float);
		}

		public static void SetShardNeibs(List<RFShard> shards, ConnectivityType type, float minArea = 0f, float minSize = 0f, int perc = 0, int seed = 0)
		{
		}

		public static void ReinitNeibs(List<RFShard> shards)
		{
		}

		public void RemoveNeibAt(int ind)
		{
		}

		public void ClearNeib()
		{
		}

		public static void SetUnchecked(List<RFShard> shards)
		{
		}

		public static Plane GetSlicePlane(Bounds bound)
		{
			return default(Plane);
		}

		public static List<RFShard> SortByDistanceToPoint(List<RFShard> shards, Vector3 point, int amount)
		{
			return null;
		}

		public static List<RFShard> SortByDistanceToPlane(List<RFShard> shards, Vector3 point, Vector3 normal, int amount)
		{
			return null;
		}

		public static bool UnyieldingByShard(List<RFShard> shards)
		{
			return default(bool);
		}

		public static bool AllUnyShards(List<RFShard> shards)
		{
			return default(bool);
		}

		public static RFShard GetShardByCollider(List<RFShard> shards, Collider collider)
		{
			return null;
		}

		public static List<RFShard> GetShardsByColliders(List<RFShard> shards, List<Collider> colliders)
		{
			return null;
		}
	}
}
