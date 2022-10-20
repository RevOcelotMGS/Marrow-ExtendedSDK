using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ
{
	public class PrefabSpawner : MonoBehaviour
	{
		[Tooltip("Spawnable")]
		[SerializeField]
		private Spawnable spawnable;

		private void Awake()
		{
		}

		public void SpawnPrefab()
		{
		}

		public PrefabSpawner()
			: base()
		{
		}
	}
}
