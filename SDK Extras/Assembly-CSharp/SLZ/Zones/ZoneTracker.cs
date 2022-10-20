using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Zones
{
	public class ZoneTracker : ZoneItem
	{
		private static ComponentCache<ZoneTracker> _cache;

		[HideInInspector]
		public ZoneSpawner spawner;

		public UnityEvent onDisabledDelegate;

		public UnityEvent onEnabledDelegate;

		public Action<ZoneTracker> onDisabledTracker;

		private AssetPoolee _poolee;

		private List<SceneZone> _triggeredZones;

		private SceneZone _parentZone;

		[SerializeField]
		private ZoneTrigger _zoneTrigger;

		public static ComponentCache<ZoneTracker> Cache
		{
			get
			{
				return null;
			}
		}

		public ZoneTrigger ZoneTrigger
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnDestroy()
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		public void Despawn(bool? playVFX = default(bool?))
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		public void OnZoneTriggerEnter(SceneZone zone)
		{
		}

		public void OnZoneTriggerExit(SceneZone zone)
		{
		}

		public void OnDespawn(GameObject despawnedObject)
		{
		}

		private void UpdateZoneRegistration()
		{
		}

		public ZoneTracker()
			: base()
		{
		}
	}
}
