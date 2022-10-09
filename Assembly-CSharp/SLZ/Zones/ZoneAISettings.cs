using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Zones
{
	[RequireComponent(typeof(ZoneSpawner))]
	public class ZoneAISettings : ZoneItem
	{
		private static ComponentCache<ZoneAISettings> _cache;

		public ZoneSpawner zoneSpawner;

		public Transform homeTransform;

		public bool homeIsPost;

		public bool isAutoInvestigate;

		public bool isAutoAggro;

		public bool isSoundAggroWhenInSecondaryZone;

		public float investigateTimeout;

		public bool overrideRoam;

		public Vector2 roamXz;

		public float roamSpeed;

		public bool roamWanders;

		private GameObject _playerObject;

		public static ComponentCache<ZoneAISettings> Cache
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

		private void UpdateAIState(GameObject spawnedGo)
		{
		}

		public void AgroOnPlayer()
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		private void OnPreSpawn(GameObject spawnedGo, GameObject playerObject)
		{
		}

		private void OnSpawn(GameObject spawnedGo, GameObject playerObject)
		{
		}

		public ZoneAISettings()
			: base()
		{
		}
	}
}
