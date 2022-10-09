using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Zones
{
	public class ZoneEncounter : ZoneItem
	{
		public enum SpawnOrder
		{
			PARALLEL = 0
		}

		[Serializable]
		public class SpawnGroup
		{
			[Tooltip("Total spawned at one time")]
			public uint concurrent;

			[Tooltip("Total Amount Spawned")]
			public uint maxSpawn;

			[Tooltip("Initial delay for the group.")]
			public float initialGroupDelay;

			[Tooltip("Time between each spawn")]
			public float spawnInterval;

			public ZoneSpawner[] spawners;

			public bool hostileGroup;

			private int _aliveCount;

			private int _deathCount;

			private int _spawnCount;

			private int _spawnerIndex;

			public int GetDeath()
			{
				return default(int);
			}

			public void Setup()
			{
			}

			public void Cleanup()
			{
			}

			private void OnSpawn(GameObject spawnedObject, GameObject playerObject)
			{
			}

			private void OnDespawn(GameObject despawnedObject)
			{
			}

			private void OnDeath()
			{
			}

			public bool IsAllDead()
			{
				return default(bool);
			}

			public bool IsUnderMax()
			{
				return default(bool);
			}

			public bool IsUnderConcurrent()
			{
				return default(bool);
			}

			public bool Spawn()
			{
				return default(bool);
			}

			public string Stats()
			{
				return null;
			}

			public SpawnGroup()
				: base()
			{
			}
		}

		public SpawnOrder spawnOrder;

		public SpawnGroup[] spawnGroups;

		[Header("Encounter Music")]
		public AudioClip encounterMusic;

		[Range(0f, 1f)]
		public float volume;

		public bool loop;

		[Range(0f, 10f)]
		public float fadeInTime;

		[Range(0f, 10f)]
		public float fadeOutTime;

		private Coroutine[] _spawnCoroutines;

		private bool _complete;

		private bool _encounterActive;

		public UnityEvent OnComplete;

		private void Awake()
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		public void StartEncounter()
		{
		}

		public void PauseEncounter()
		{
		}

		public void CompleteEncounter()
		{
		}

		public IEnumerator Encounter(SpawnGroup group)
		{
			return null;
		}

		public ZoneEncounter()
			: base()
		{
		}
	}
}
