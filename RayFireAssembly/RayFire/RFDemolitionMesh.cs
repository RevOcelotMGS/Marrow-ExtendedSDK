using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RayFire.DotNet;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFDemolitionMesh
	{
		public enum MeshInputType
		{
			AtStart = 3,
			AtInitialization = 6,
			AtDemolition = 9
		}

		public int amount;

		public int variation;

		public float depthFade;

		public float contactBias;

		public int seed;

		public bool useShatter;

		public bool clusterize;

		public FragSimType simType;

		public MeshInputType meshInput;

		public RFFragmentProperties properties;

		public RFRuntimeCaching runtimeCaching;

		[NonSerialized]
		public int badMesh;

		[NonSerialized]
		public int shatterMode;

		[NonSerialized]
		public int totalAmount;

		[NonSerialized]
		public int innerSubId;

		[HideInInspector]
		public Quaternion cacheRotationStart;

		public Mesh mesh;

		public RFShatter rfShatter;

		public RayfireShatter scrShatter;

		private static string fragmentStr;

		public void CopyFrom(RFDemolitionMesh demolition)
		{
		}

		public void Reset()
		{
		}

		public static bool DemolishMesh(RayfireRigid scr)
		{
			return default(bool);
		}

		public static bool ClusterizeFragments(RayfireRigid rigid)
		{
			return default(bool);
		}

		public static List<RayfireRigid> CreateFragments(RayfireRigid scr)
		{
			return null;
		}

		public static void SliceMesh(RayfireRigid scr)
		{
		}

		public static List<RayfireRigid> CreateSlices(RayfireRigid scr)
		{
			return null;
		}

		private static void SetFragmentSimulationType(RayfireRigid frag, RayfireRigid scr)
		{
		}

		private static void CacheRuntime(RayfireRigid scr)
		{
		}

		private static void CacheInstant(RayfireRigid scr)
		{
		}

		public int GetLayer(RayfireRigid scr)
		{
			return default(int);
		}

		public IEnumerator RuntimeCachingCor(RayfireRigid scr)
		{
			return null;
		}

		public void StopRuntimeCaching()
		{
		}

		private void ResetRuntimeCaching(RayfireRigid scr, GameObject tmRefGo)
		{
		}

		public static void AwakePrecache(RayfireRigid scr)
		{
		}

		public static void AwakePrefragment(RayfireRigid scr)
		{
		}

		private static void PreCache(RayfireRigid scr)
		{
		}

		public static void ChildrenToFragments(RayfireRigid scr)
		{
		}

		public RFDemolitionMesh()
			: base()
		{
		}
	}
}
