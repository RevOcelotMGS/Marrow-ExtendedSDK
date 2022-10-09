using System;
using System.Runtime.InteropServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Utilities
{
	public class UtilitySpawnables : MonoBehaviour
	{
		private static UtilitySpawnables _instance;

		public Spawnable audioPlayerSpawnable;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public static void SpawnAudioPlayer(Vector3 position = default(Vector3), Action<GameObject> callback = default(Action<GameObject>))
		{
		}

		public UtilitySpawnables()
			: base()
		{
		}
	}
}
