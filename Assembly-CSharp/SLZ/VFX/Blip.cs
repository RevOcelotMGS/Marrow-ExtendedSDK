using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.VFX
{
	public class Blip : SpawnEvents
	{
		private static ComponentCache<Blip> _cache;

		[SerializeField]
		private Renderer[] Renderers;

		[SerializeField]
		private Spawnable fizzlerSpawnable;

		[SerializeField]
		private Spawnable spawnSpawnable;

		[HideInInspector]
		[Header("DO NOT SET IN INSPECTOR")]
		public Vector3 velocity;

		private bool isDestructible;

		[Header("DO NOT SET IN INSPECTOR")]
		[HideInInspector]
		public bool forceBlip;

		private bool sfxPlayed;

		private List<Mesh> cashedMeshes;

		private Vector3 vecone;

		public static ComponentCache<Blip> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void OnPostSpawn(GameObject go)
		{
		}

		protected override void OnDespawn(GameObject go)
		{
		}

		public void CallSpawnEffect()
		{
		}

		public void CallDespawnEffect()
		{
		}

		public void FireEffect(Spawnable effect, Color? color = default(Color?))
		{
		}

		private float GetVolumeSurface(Vector3 size)
		{
			return default(float);
		}

		public Blip()
			: base()
		{
		}
	}
}
