using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFCollapse
	{
		public enum RFCollapseType
		{
			ByArea = 1,
			BySize = 3,
			Random = 5
		}

		[Tooltip(" By Area: Shard will loose it's connections if it's shared area surface is less then defined value.\n By Size: Shard will loose it's connections if it's Size is less then defined value.\n Random: Shard will loose it's connections if it's random value in range from 0 to 100 is less then defined value.")]
		public RFCollapseType type;

		public int start;

		public int end;

		public int steps;

		public float duration;

		[NonSerialized]
		public bool inProgress;

		public static void StartCollapse(RayfireRigid scr)
		{
		}

		private IEnumerator CollapseCor(RayfireRigid scr)
		{
			return null;
		}

		public static void StartCollapse(RayfireConnectivity scr)
		{
		}

		public static void StopCollapse(RayfireConnectivity scr)
		{
		}

		private IEnumerator CollapseCor(RayfireConnectivity scr)
		{
			return null;
		}

		public static void AreaCollapse(RayfireRigid scr, int areaPercentage)
		{
		}

		public static void SizeCollapse(RayfireRigid scr, int sizePercentage)
		{
		}

		public static void AreaCollapse(RayfireRigid scr, float minAreaValue)
		{
		}

		public static void SizeCollapse(RayfireRigid scr, float minSizeValue)
		{
		}

		public static void RandomCollapse(RayfireRigid scr, int randomValue, int randomSeed)
		{
		}

		private static void CollapseCluster(RayfireRigid scr)
		{
		}

		public static void AreaCollapse(RayfireConnectivity connectivity, int areaPercentage)
		{
		}

		public static void SizeCollapse(RayfireConnectivity connectivity, int sizePercentage)
		{
		}

		public static void AreaCollapse(RayfireConnectivity connectivity, float areaValue)
		{
		}

		public static void SizeCollapse(RayfireConnectivity connectivity, float sizeValue)
		{
		}

		public static void RandomCollapse(RayfireConnectivity connectivity, int randomPercentage, int seedValue)
		{
		}

		private static int RemNeibByArea(RFCluster cluster, float minArea)
		{
			return default(int);
		}

		private static int RemNeibBySize(RFCluster cluster, float minSize)
		{
			return default(int);
		}

		private static int RemNeibRandom(RFCluster cluster, int percent, int seed)
		{
			return default(int);
		}

		public static void SetRangeData(RFCluster cluster, int perc = 0, int seed = 0)
		{
		}

		public RFCollapse()
			: base()
		{
		}
	}
}
