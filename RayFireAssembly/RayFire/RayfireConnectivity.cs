using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[DisallowMultipleComponent]
	[AddComponentMenu("RayFire/Rayfire Connectivity")]
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-connectivity-component/")]
	public class RayfireConnectivity : MonoBehaviour
	{
		public enum RFConnInitType
		{
			AtStart = 1,
			ByMethod = 3,
			ByIntegrity = 5
		}

		public ConnectivityType type;

		public float expand;

		public float minimumArea;

		public float minimumSize;

		public int percentage;

		public int seed;

		public bool clusterize;

		public bool demolishable;

		public RFConnInitType startCollapse;

		public int collapseByIntegrity;

		public RFCollapse collapse;

		public RFConnInitType startStress;

		public int stressByIntegrity;

		public RFStress stress;

		public bool showConnections;

		public bool showNodes;

		public bool showGizmo;

		public bool showStress;

		public bool checkConnectivity;

		public bool connectivityCheckNeed;

		public List<RayfireRigid> rigidList;

		public RFCluster cluster;

		public int initShardAmount;

		public int clsCount;

		public RayfireRigidRoot rigidRootHost;

		public RayfireRigid meshRootHost;

		public Collider triggerCollider;

		public int triggerDebris;

		[NonSerialized]
		public RFBackupCluster backup;

		[NonSerialized]
		public bool childrenChanged;

		[NonSerialized]
		private bool childrenCorState;

		[NonSerialized]
		private bool connectivityCorState;

		[NonSerialized]
		private bool corState;

		public RFConnectivityEvent connectivityEvent;

		public float AmountIntegrity
		{
			get
			{
				return default(float);
			}
		}

		private void SetRuntimeMeshRootHost()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		public void Initialize()
		{
		}

		private bool WarningCheck()
		{
			return default(bool);
		}

		public void StartAllCoroutines()
		{
		}

		private void PrepareCluster()
		{
		}

		private RFCluster CreateCluster()
		{
			return null;
		}

		private void SetClusterForMeshRoot()
		{
		}

		private void SetClusterForRigidRoot()
		{
		}

		private void SetExpand()
		{
		}

		private void SetRigidListByFragments(List<RayfireRigid> rgList)
		{
		}

		public static bool InitCachedShardsByRigidList(List<RayfireRigid> rigids, RFCluster cluster)
		{
			return default(bool);
		}

		public static void InitCachedShardsByRigidRoot(RayfireRigidRoot root, RFCluster cluster)
		{
		}

		private IEnumerator ConnectivityCor()
		{
			return null;
		}

		public void CheckConnectivity()
		{
		}

		private void CheckConnectivityRigidList()
		{
		}

		private void CheckConnectivityRigidRoot()
		{
		}

		private void ActivateShards(List<RFShard> soloShards)
		{
		}

		private void Clusterize()
		{
		}

		private static void CleanUpActivatedShardsRigidList(RFCluster cluster)
		{
		}

		private static void CheckUnyieldingRigidList(RFCluster cluster)
		{
		}

		private static void CleanUpActivatedShardsRigidRoot(RFCluster cluster)
		{
		}

		private static void CheckUnyieldingRigidRoot(RFCluster cluster)
		{
		}

		private void OnTransformChildrenChanged()
		{
		}

		private IEnumerator ChildrenCor()
		{
			return null;
		}

		private void ChildrenCheck()
		{
		}

		public void ResetConnectivity()
		{
		}

		public void ResetSetup()
		{
		}

		public void Fracture()
		{
		}

		public void Fracture(Collider col, int debris)
		{
		}

		private HashSet<Collider> GetOverlappedColliders(Collider col)
		{
			return null;
		}

		public RayfireConnectivity()
			: base()
		{
		}
	}
}
