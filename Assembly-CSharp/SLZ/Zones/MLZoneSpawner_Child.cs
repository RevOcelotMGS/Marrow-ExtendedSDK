using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.AI;
using UnityEngine;

namespace SLZ.Zones
{
	public class MLZoneSpawner_Child : ZoneSpawner
	{
		public delegate void OnAutoAgroDelegate(Behaviour newVal, TriggerRefProxy trp);

		[Header("Status Section")]
		[Tooltip("Indicates if the zone is enabled")]
		public bool zoneActive;

		private bool _deathEventSent;

		private int _dead_;

		private int _total_;

		private Coroutine _emitterCoroutine;

		[Header("Inference Section")]
		[Tooltip("The model manager that this spawner is associated with")]
		public BarracudaModelManagerMono bmm;

		[Tooltip("Scriptable object that holds model manager/spawner variable and model references")]
		public ModelManagerConfig bmmConfig;

		[Tooltip("# of model layers to execute per inference step")]
		public int nbNetworkSlices;

		[Tooltip("Shape of action mask = to number of actcions the agent can take")]
		public int actionMaskSize;

		[Tooltip("Use BMM Config values for spawner values")]
		public bool overrideSpawnVals;

		[Tooltip("Whether to initialize bmm on Start()")]
		public bool bmmInitOnStart;

		[Tooltip("Set behaviour of spawned agent to agro")]
		public bool autoAgroOnSpawn;

		private Transform initialTarget;

		private InferenceAgent temp_agent;

		[HideInInspector]
		public bool engineRunning;

		[HideInInspector]
		public bool agentsSpawned;

		public bool delayedDestruction;

		private Action<GameObject> setParentAction;

		public int _Alive { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void SetParent(GameObject go)
		{
		}

		private void BMMSetup()
		{
		}

		private void OnDestroy()
		{
		}

		public void WarmStartModelManager()
		{
		}

		private void PostStart()
		{
		}

		public void StopModelManagerRoutine()
		{
		}

		public void StartModelManagerRoutine()
		{
		}

		public void StartBMM()
		{
		}

		private void ResetSpawnerValues()
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		public void StartMLSpawn(GameObject playerObject = default(GameObject))
		{
		}

		private IEnumerator CoStartEmmiter(GameObject playerObject)
		{
			return null;
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		public void CommandDeactivate()
		{
		}

		private IEnumerator DelayedDestroy(GameObject go)
		{
			return null;
		}

		private void OnDespawn(GameObject despawnedObject)
		{
		}

		private void OnDeath()
		{
		}

		private void RecycleAgentInd(int ind)
		{
		}

		private void OnResurrect()
		{
		}

		private void AgentInitialization(GameObject go, GameObject playerObject)
		{
		}

		private void AgentInitialization(GameObject go)
		{
		}

		private void MLSpawn(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneExited(GameObject playerObject)
		{
		}

		public override void OnSecondaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnSecondaryZoneExited(GameObject playerObject)
		{
		}

		public void SetZoneInactive()
		{
		}

		private void RandomizeCrate()
		{
		}

		public MLZoneSpawner_Child()
			: base()
		{
		}

		public event OnAutoAgroDelegate OnAutoAgro;
	}
}
