using System;
using System.Runtime.CompilerServices;

namespace RayFire
{
	[Serializable]
	public class RFReset
	{
		public enum PostDemolitionType
		{
			DestroyWithDelay = 0,
			DeactivateToReset = 1
		}

		public enum MeshResetType
		{
			Destroy = 0,
			ReuseInputMesh = 2,
			ReuseFragmentMeshes = 4
		}

		public enum FragmentsResetType
		{
			Destroy = 0,
			Reuse = 2,
			Preserve = 4
		}

		public bool transform;

		public bool damage;

		public bool connectivity;

		public PostDemolitionType action;

		public float destroyDelay;

		public MeshResetType mesh;

		public FragmentsResetType fragments;

		[NonSerialized]
		public bool toBeDestroyed;

		public void CopyFrom(RFReset reset, ObjectType objectType)
		{
		}

		public static void ResetRigid(RayfireRigid scr)
		{
		}

		public static void ResetFade(RayfireRigid scr)
		{
		}

		private static bool MeshRootReset(RayfireRigid scr)
		{
			return default(bool);
		}

		private static bool MeshRootCleanup(RayfireRigid scr)
		{
			return default(bool);
		}

		public static void RigidRootReset(RayfireRigidRoot scr)
		{
		}

		private static void ResetParentAndTm(RayfireRigidRoot scr)
		{
		}

		private static void ResetSimType(RayfireRigidRoot scr)
		{
		}

		public static void DestroyParticles(RayfireRigidRoot scr)
		{
		}

		public static void DestroyClusters(RayfireRigidRoot scr)
		{
		}

		public static void ResetMeshDemolition(RayfireRigid scr)
		{
		}

		private static void DestroyFragments(RayfireRigid scr)
		{
		}

		public static void DestroyParticles(RayfireRigid scr)
		{
		}

		private static void ReuseFragments(RayfireRigid scr)
		{
		}

		private static void PreserveFragments(RayfireRigid scr)
		{
		}

		private static void ResetClusterDemolition(RayfireRigid scr)
		{
		}

		private static bool ObjectReuseState(RayfireRigid scr)
		{
			return default(bool);
		}

		private static bool FragmentReuseState(RayfireRigid scr)
		{
			return default(bool);
		}

		private static void RestoreTransform(RayfireRigid scr)
		{
		}

		public static void Reset(RayfireRigid scr)
		{
		}

		public static void ResetSound(RayfireSound scr)
		{
		}

		public RFReset()
			: base()
		{
		}
	}
}
