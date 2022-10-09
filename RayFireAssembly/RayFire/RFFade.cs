using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFFade
	{
		public bool onDemolition;

		public bool onActivation;

		public float byOffset;

		public RFFadeLifeType lifeType;

		public float lifeTime;

		public float lifeVariation;

		public FadeType fadeType;

		public float fadeTime;

		public float sizeFilter;

		public int shardAmount;

		[NonSerialized]
		public int state;

		[NonSerialized]
		public bool stop;

		[NonSerialized]
		public Vector3 position;

		[NonSerialized]
		public bool offsetCorState;

		[NonSerialized]
		public IEnumerator offsetEnum;

		public void CopyFrom(RFFade fade)
		{
		}

		public void Reset()
		{
		}

		public void DemolitionFade(List<RayfireRigid> fadeObjects)
		{
		}

		public static IEnumerator FadeOffsetCor(RayfireRigid scr)
		{
			return null;
		}

		public static IEnumerator FadeOffsetCor(RayfireRigidRoot scr)
		{
			return null;
		}

		public static void FadeRigid(RayfireRigid scr)
		{
		}

		public static void FadeShard(RayfireRigidRoot scr, RFShard shard)
		{
		}

		public static void FadeClusterShards(RayfireRigid scr, List<RFShard> fadeShards)
		{
		}

		private static IEnumerator LivingCor(RayfireRigid scr)
		{
			return null;
		}

		private static IEnumerator LivingCor(RayfireRigidRoot root, RFShard shard)
		{
			return null;
		}

		private static IEnumerator SimulationLivingCor(Transform tm)
		{
			return null;
		}

		private static void FadeExclude(RayfireRigid rigid)
		{
		}

		private static void FadeExclude(RayfireRigidRoot root, RFShard shard)
		{
		}

		private static IEnumerator FallDownCor(RayfireRigid rigid)
		{
			return null;
		}

		private static IEnumerator FallDownCor(RayfireRigidRoot root, RFShard shard)
		{
			return null;
		}

		private static IEnumerator ScaleDownCor(RayfireRigid scr)
		{
			return null;
		}

		private static IEnumerator ScaleDownCor(RayfireRigidRoot root, RFShard shard)
		{
			return null;
		}

		private static IEnumerator FadeMoveDownCor(RayfireRigid rigid)
		{
			return null;
		}

		private static IEnumerator FadeMoveDownCor(RayfireRigidRoot root, RFShard shard)
		{
			return null;
		}

		private static void DisableClusterColliders(RayfireRigid rigid)
		{
		}

		public static void SetOffsetFadeList(RayfireRigidRoot root)
		{
		}

		public RFFade()
			: base()
		{
		}
	}
}
