using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Zones
{
	[RequireComponent(typeof(BoxCollider))]
	public class SceneZone : MonoBehaviour
	{
		private static ComponentCache<SceneZone> _cache;

		[SerializeField]
		[HideInInspector]
		public BoxCollider boxCollider;

		private bool _wasZoneEnabled;

		private bool _isZoneEnabled;

		private bool _wasSubZone;

		private bool _isSubZone;

		private static bool _hasZonesChanged;

		public static List<SceneZone> _allZones;

		private static List<SceneZone> _triggeredZones;

		public static List<ZoneItem> _itemsToEnable;

		public static List<ZoneItem> _itemsToDisable;

		private static List<SceneZone> _zonesToEnable;

		private static List<SceneZone> _zonesToDisable;

		private static List<ZoneItem> _primaryItems;

		private static HashSet<ZoneItem> _enabledItems;

		public SceneZone[] linkedZones;

		public List<ZoneItem> zoneItems;

		public UnityEvent onZoneEnabled;

		public UnityEvent onZoneDisabled;

		public UnityEvent onPrimaryZoneEntered;

		public UnityEvent onPrimaryZoneExited;

		public UnityEvent onSecondaryZoneEntered;

		public UnityEvent onSecondaryZoneExited;

		public UnityEvent onPrimaryZoneEnteredOneTime;

		public UnityEvent onSecondaryZoneEnteredOneTime;

		public List<NPC_Data> npcDataList;

		[HideInInspector]
		public string titleChar;

		public static ComponentCache<SceneZone> Cache
		{
			get
			{
				return null;
			}
		}

		public static SceneZone CurrentZone { get; private set; }

		public static GameObject PlayerObject { get; private set; }

		public bool IsEnabled
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsSubZone
		{
			get
			{
				return default(bool);
			}
		}

		private void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public void OnTriggerExit(Collider other)
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		public void UpdateZonesState()
		{
		}

		private void DisableZone()
		{
		}

		private void EnableZone()
		{
		}

		public void RegisterZoneItem(ZoneItem item)
		{
		}

		public void DeregisterZoneItem(ZoneItem item)
		{
		}

		public void UpdateZoneItemsState()
		{
		}

		public void DisableItem(ZoneItem item, bool inSubZone = false)
		{
		}

		public void EnableItem(ZoneItem item, bool inSubZone = false)
		{
		}

		public void Update()
		{
		}

		private IEnumerator CoEnableOverTime(int length)
		{
			return null;
		}

		public SceneZone()
			: base()
		{
		}
	}
}
