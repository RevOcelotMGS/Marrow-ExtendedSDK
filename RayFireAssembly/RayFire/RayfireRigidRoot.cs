using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RayFire
{
	[DisallowMultipleComponent]
	[AddComponentMenu("RayFire/Rayfire Rigid Root")]
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-rigid-root-component/")]
	[SelectionBase]
	public class RayfireRigidRoot : MonoBehaviour
	{
		public enum InitType
		{
			ByMethod = 0,
			AtStart = 1
		}

		public InitType initialization;

		public SimType simulationType;

		public RFPhysic physics;

		public RFActivation activation;

		public RFRigidRootDemolition demolition;

		public RFFade fading;

		public RFReset reset;

		public Transform tm;

		public RayfireSound sound;

		public RFCluster cluster;

		public List<RayfireRigid> meshRoots;

		public bool initialized;

		public bool cached;

		public float sizeBox;

		public float sizeSum;

		public List<Collider> collidersList;

		public List<RFShard> meshRootShards;

		public List<RFShard> rigidRootShards;

		[NonSerialized]
		public List<RFCluster> clusters;

		[NonSerialized]
		public List<RFShard> inactiveShards;

		[NonSerialized]
		public List<RFShard> offsetFadeShards;

		[NonSerialized]
		public List<RFShard> destroyShards;

		[NonSerialized]
		public List<RFShard> meshRigidShards;

		[NonSerialized]
		public List<Transform> parentList;

		[NonSerialized]
		public List<RayfireDebris> debrisList;

		[NonSerialized]
		public List<RayfireDust> dustList;

		[NonSerialized]
		public List<RayfireUnyielding> unyList;

		[NonSerialized]
		public List<Transform> particleList;

		[NonSerialized]
		public bool corState;

		[NonSerialized]
		public HashSet<Collider> collidersHash;

		public RFActivationEvent activationEvent;

		private static string strRoot;

		public bool HasClusters
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasDebris
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasDust
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasUny
		{
			get
			{
				return default(bool);
			}
		}

		private void Awake()
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

		private void InitConnectivity()
		{
		}

		public void ResetRigidRoot()
		{
		}

		public void EditorSetup()
		{
		}

		public void ResetSetup()
		{
		}

		private void AwakeMethods()
		{
		}

		private void SetComponents()
		{
		}

		private bool MeshRootCheck()
		{
			return default(bool);
		}

		private void SetShards()
		{
		}

		private void SetCustomShardsLists()
		{
		}

		private void SetShardsSimulationType()
		{
		}

		private void SetParentList()
		{
		}

		private void AddShard(Transform shardTm, RayfireRigid rigid = default(RayfireRigid))
		{
		}

		private void AddShardWithRigid(RayfireRigid rigid)
		{
		}

		private void SetColliders()
		{
		}

		private void SetCollidersMaterial()
		{
		}

		public void SetInactiveList()
		{
		}

		private void SetUnyielding()
		{
		}

		public void StartAllCoroutines()
		{
		}

		public void CopyPropertiesTo(RayfireRigid toScr)
		{
		}

		private static bool IsNestedCluster(Transform trans)
		{
			return default(bool);
		}

		private static bool ShardFilter(RFShard shard, RayfireRigidRoot scr)
		{
			return default(bool);
		}

		public void CollideTest()
		{
		}

		public RayfireRigidRoot()
			: base()
		{
		}
	}
}
