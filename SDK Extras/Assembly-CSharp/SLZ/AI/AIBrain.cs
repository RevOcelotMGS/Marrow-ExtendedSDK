using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.AI
{
	public class AIBrain : SpawnEvents
	{
		private static ComponentCache<AIBrain> _cache;

		public EnemyTurret turret;

		public bool dontClearBaseConfig;

		public Action onDeathDelegate;

		public Action onResurrectDelegate;

		public Action<AIBrain> onNPC_DeathDelegate;

		public bool autoDespawn;

		[HideInInspector]
		public bool isDead;

		private Rigidbody[] _rigidbodies;

		private bool _wasConfigSet;

		private Coroutine arenaEntranceRoutine;

		private float entranceTimer;

		public static ComponentCache<AIBrain> Cache
		{
			get
			{
				return null;
			}
		}

		public bool IsSoundAggroWhenInSecondaryZone
		{
			get
			{
				return default(bool);
			}
		}

		private void Reset()
		{
		}

		protected void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetVelocity(Vector3 velocity)
		{
		}

		public void SetAngularVelocity(Vector3 angularVelocity)
		{
		}

		public void SetAngularVelocity(float minAngularSpeed, float maxAngularSpeed)
		{
		}

		private void OnDeath()
		{
		}

		private void OnResurrection()
		{
		}

		public void StartArenaEntranceTimer(float time = 120f)
		{
		}

		public void StopArenaEntranceTimer()
		{
		}

		private IEnumerator CoArenaEntrance()
		{
			return null;
		}

		public AIBrain()
			: base()
		{
		}
	}
}
