using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PuppetMasta;
using SLZ.AI;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Zones
{
	public class ZoneSpawner : ZoneItem
	{
		public enum modes
		{
			SINGLE = 0,
			EMITTER = 1
		}

		private static ComponentCache<ZoneSpawner> _cache;

		public bool autoStart;

		[Tooltip("Short-Circuit the spawning while active")]
		public bool isSpawningAllowed;

		public Spawnable spawnable;

		[Tooltip("Check this to have spawner use array below for random enemy")]
		public bool useRandomCrate;

		[Tooltip("Add crates of all enemies you want to random select from")]
		public Spawnable[] randomeSpawnables;

		[HideInInspector]
		public int amountOfCrates;

		public Spawnable spawnVFX;

		public Vector3 VFXPosition;

		public modes mode;

		[Header("Emitter Settings")]
		[Tooltip("Maximum that can be spawned ")]
		public int max;

		[Tooltip("Maximum spawns that can be alive before spawning stops (0 = Infinity)")]
		public int concurrentAlive;

		[Tooltip("Maximum spawns that can be alive or dead before spawning stops (0 = Infinity), Will require dead spawns to be manually cleaned up before spawning can continue")]
		public int concurrentTotal;

		[Tooltip("Resets when zone is entered by player, set to true if you want the emitter to persist")]
		public bool isResetOnZoneEnable;

		public AudioClip[] spawnClip;

		[Tooltip("Per-Second")]
		public float frequency;

		public Vector3 spawnVelocity;

		public Vector3 spawnAngularVelocity;

		public float minSpawnAngularVelocity;

		public float maxSpawnAngularVelocity;

		public Action<GameObject, GameObject> OnPreSpawnDelegate;

		public Action<GameObject, GameObject> OnSpawnDelegate;

		public Action<GameObject> OnDespawnDelegate;

		public Action OnDeathDelegate;

		public UnityEvent onActivate;

		public UnityEvent onDeactivate;

		public UnityEvent onSpawn;

		public UnityEvent onDeath;

		public UnityEvent onDeathOneShot;

		private bool deathEventSent;

		public Action<ZoneSpawner, AIBrain, EnemyProfile, bool> onSpawnNPCDelegate;

		public Action<BehaviourBaseNav, Rigidbody> OnSpawn_NPC_Launcher;

		private GameObject _playerObject;

		private int _dead;

		private int _total;

		private Coroutine _emitterCoroutine;

		[Header("Arena")]
		[Tooltip("Used for explicit arena spawns only, useful for enemies spawned on ziplines or at heights, disables damage from collision for x seconds after spawn")]
		[SerializeField]
		private float blockCollisionDelay;

		public EnemyProfile currEnemyProfile;

		public bool enableAgentLinking;

		public bool customSpawnerName;

		[HideInInspector]
		public GameObject playerObj;

		[HideInInspector]
		public Arena_GameController arenaGameController;

		[Tooltip("Reference to game obj that will be the spawned npc's parent")]
		public GameObject parentOverride;

		public static ComponentCache<ZoneSpawner> Cache
		{
			get
			{
				return null;
			}
		}

		public List<GameObject> spawns { get; private set; }

		public bool IsActive { get; private set; }

		public int Alive { get; private set; }

		protected void InitSpawns()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		public void Activate()
		{
		}

		public void AllowSpawning(bool isAllowed)
		{
		}

		public void SetAutostart(bool isAutoStart)
		{
		}

		public void Deactivate()
		{
		}

		public bool IsUnderMaxSpawn()
		{
			return default(bool);
		}

		public bool IsUnderConcurrentSpawn()
		{
			return default(bool);
		}

		public bool CanSpawn()
		{
			return default(bool);
		}

		public void SetMaxSpawnCount(int val)
		{
		}

		public void TriggerSpawn()
		{
		}

		public void ResetEmitter()
		{
		}

		public void StopEmitterSpawns()
		{
		}

		public void ExplicitFriendlySpawn(Vector3 spawnPos, Quaternion spawnRot, EnemyProfile enemyProfile, BaseEnemyConfig baseConfig = default(BaseEnemyConfig), bool autoDespawn = false, float colDelay = 0f)
		{
		}

		public void ExplicitArenaSpawn(EnemyProfile enemyProfile, bool autoDespawn = false, float colDelay = 0f, bool isFriendly = false)
		{
		}

		private void Spawn(GameObject playerObject)
		{
		}

		public void StartSpawn(GameObject playerObject = default(GameObject))
		{
		}

		private IEnumerator CoStartEmmiter(GameObject playerObject)
		{
			return null;
		}

		public void DisableSpawning()
		{
		}

		public void EnableSpawning()
		{
		}

		private void OnDespawn(GameObject despawnedObject)
		{
		}

		private void OnDeath()
		{
		}

		private void OnResurrect()
		{
		}

		private void RandomizeCrate()
		{
		}

		public ZoneSpawner()
			: base()
		{
		}
	}
}
