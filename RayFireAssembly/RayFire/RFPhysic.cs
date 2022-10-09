using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFPhysic
	{
		private struct RFIgnorePair
		{
			private int a;

			private int b;

			public RFIgnorePair(int A, int B)
			{
				this.b = default(int);
				this.a = default(int);
			}
		}

		public MaterialType materialType;

		public PhysicMaterial material;

		public MassType massBy;

		public float mass;

		public RFColliderType colliderType;

		public bool planarCheck;

		public bool ignoreNear;

		public bool useGravity;

		public int solverIterations;

		public float dampening;

		public Rigidbody rigidBody;

		public Collider meshCollider;

		public List<Collider> clusterColliders;

		public List<int> ignoreList;

		public bool rec;

		public bool exclude;

		public int solidity;

		public bool destructible;

		public bool physicsDataCorState;

		[NonSerialized]
		public Vector3 velocity;

		[NonSerialized]
		public Vector3 initScale;

		[NonSerialized]
		public Vector3 initPosition;

		[NonSerialized]
		public Quaternion initRotation;

		[NonSerialized]
		public Vector3 localPosition;

		[NonSerialized]
		public IEnumerator physicsEnum;

		public static int coplanarVertLimit;

		public bool HasIgnore
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasClusterColliders
		{
			get
			{
				return default(bool);
			}
		}

		public bool Destructible
		{
			get
			{
				return default(bool);
			}
		}

		public int Solidity
		{
			get
			{
				return default(int);
			}
		}

		public PhysicMaterial PhysMaterial
		{
			get
			{
				return null;
			}
		}

		public void CopyFrom(RFPhysic physics)
		{
		}

		public void Reset()
		{
		}

		public void SaveInitTransform(Transform tm)
		{
		}

		public void LoadInitTransform(Transform tm)
		{
		}

		public static void SetSimulationType(Rigidbody rb, SimType simulationType, ObjectType objectType, bool useGravity, int solver)
		{
		}

		private static void SetDynamic(Rigidbody rb, bool useGravity)
		{
		}

		private static void SetSleeping(Rigidbody rb, bool useGravity)
		{
		}

		private static void SetInactive(Rigidbody rb)
		{
		}

		private static void SetKinematic(Rigidbody rb, bool useGravity)
		{
		}

		private static void SetCollisionDetection(Rigidbody rb, ObjectType objectType)
		{
		}

		public static void SetDensity(RayfireRigid scr)
		{
		}

		public static void SetDensity(RFShard shard, RFPhysic physics, float density)
		{
		}

		private static float MassLimit(float m)
		{
			return default(float);
		}

		public static void SetMassByParent(RFPhysic target, float targetSize, float parentMass, float parentSize)
		{
		}

		public static void SetDrag(RayfireRigid scr)
		{
		}

		public static void SetDrag(RFShard shard, float drag, float dragAngular)
		{
		}

		public static void SetFragmentsVelocity(RayfireRigid scr)
		{
		}

		public static void SetFragmentCollider(RayfireRigid scr, Mesh mesh)
		{
		}

		public static void SetRigidCollider(RayfireRigid scr, Mesh mesh = default(Mesh))
		{
		}

		public static void SetRigidRootCollider(RayfireRigidRoot root, RFPhysic physics, RFShard shard)
		{
		}

		public static void SetupMeshRootColliders(RayfireRigid scr)
		{
		}

		public static void SetClusterCollidersByShards(RayfireRigid scr)
		{
		}

		private static void CollidersRemoveNull(RayfireRigid scr)
		{
		}

		private static void SetShardColliders(RayfireRigid scr, RFCluster cluster)
		{
		}

		private static void SetDeepShardColliders(RayfireRigid scr, RFCluster cluster)
		{
		}

		public static void CollectClusterColliders(RayfireRigid scr, RFCluster cluster)
		{
		}

		private static void CollectDeepColliders(RayfireRigid scr, RFCluster cluster)
		{
		}

		public static void SetColliderMaterial(RayfireRigid scr)
		{
		}

		public static void SetColliderMaterial(RFPhysic physics, RFShard shard)
		{
		}

		public static void SetParticleColliderMaterial(List<RayfireDebris> debris)
		{
		}

		public static void SetColliderConvex(RayfireRigid scr)
		{
		}

		public static void DestroyColliders(RayfireRigid scr)
		{
		}

		public static void SetPhysics(RayfireRigidRoot root)
		{
		}

		public static void SetPhysics(List<RFShard> shards, RFPhysic physic)
		{
		}

		public static void SetPhysics(RFShard shard, RFPhysic physic)
		{
		}

		public static void SetIgnoreColliders(RFPhysic physics, List<RayfireRigid> rigids)
		{
		}

		public static void SetIgnoreColliders(RFPhysic physics, List<RFShard> shards)
		{
		}

		public static void SetIgnoreListShards(RFPhysic physics, List<RFShard> shards)
		{
		}

		public static List<int> GetIgnoreListFast(List<Bounds> bounds)
		{
			return null;
		}

		public static List<int> GetIgnoreListShort(List<Bounds> bounds)
		{
			return null;
		}

		public static void IgnoreNeibCollision(List<RayfireRigid> rigids, List<int> pr)
		{
		}

		public static void IgnoreNeibCollision(List<RFShard> shards, List<int> pr)
		{
		}

		public static bool IsNull(Rigidbody rb)
		{
			return default(bool);
		}

		public IEnumerator PhysicsDataCor(RayfireRigid scr)
		{
			return null;
		}

		public RFPhysic()
			: base()
		{
		}
	}
}
