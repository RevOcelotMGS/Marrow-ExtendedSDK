using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFStress
	{
		public bool enable;

		public int threshold;

		public float erosion;

		public float interval;

		public int support;

		public bool exposed;

		public bool bySize;

		public List<RFShard> strShards;

		public List<RFShard> supShards;

		public Vector3 rotCache;

		public Vector3 grvCache;

		public int supCache;

		public float sizeCache;

		public bool initialized;

		private List<RFShard> checkShards;

		[NonSerialized]
		public bool inProgress;

		[NonSerialized]
		public int strAmount;

		[NonSerialized]
		public int supAmount;

		private List<int> path;

		private List<int> frontier;

		private List<int> frontPrior;

		public static void StopStress(RayfireConnectivity scr)
		{
		}

		public static void StartStress(RayfireConnectivity scr)
		{
		}

		private IEnumerator StressCor(RayfireConnectivity scr)
		{
			return null;
		}

		private bool CheckSupport(RayfireConnectivity scr)
		{
			return default(bool);
		}

		private static void StressErosion(RayfireConnectivity scr)
		{
		}

		private static void StressCollapse(RayfireConnectivity connectivity, int maxStressValue)
		{
		}

		private static int RemNeibByStress(RFStress stress, int stressVal)
		{
			return default(int);
		}

		public static void Initialize(RayfireConnectivity conn)
		{
		}

		private static bool InitializeNeed(RayfireConnectivity conn)
		{
			return default(bool);
		}

		private static void SetStressConnections(RayfireConnectivity conn)
		{
		}

		private static void SetStressSupport(List<RFShard> shards, RFStress stress)
		{
		}

		private static void PrepareCheckShards(RFStress stress)
		{
		}

		private static void SetSizeMultiplier(RayfireConnectivity conn)
		{
		}

		private static void SetSizeMultiplierOLD(RayfireConnectivity conn)
		{
		}

		private static List<int> GetPathAstar(RFStress str, List<RFShard> shards, int startId, int lastId)
		{
			return null;
		}

		public RFStress()
			: base()
		{
		}
	}
}
