using System;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFRuntimeCaching
	{
		public CachingType type;

		[Range(2f, 300f)]
		public int frames;

		[Range(1f, 20f)]
		public int fragments;

		public bool skipFirstDemolition;

		[HideInInspector]
		public bool inProgress;

		[HideInInspector]
		public bool wasUsed;

		[HideInInspector]
		public bool stop;

		public static List<int> GetBatchByFrames(int frames, int amount)
		{
			return null;
		}

		public static List<int> GetBatchByFragments(int fragments, int amount)
		{
			return null;
		}

		public static List<int> GetMarkedElements(int batchInd, List<int> batchAmount)
		{
			return null;
		}

		public static GameObject CreateTmRef(RayfireRigid rfScr)
		{
			return null;
		}

		public RFRuntimeCaching()
			: base()
		{
		}
	}
}
