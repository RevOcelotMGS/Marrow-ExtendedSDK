using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[SelectionBase]
	public class SpawnableCratePlacer : MonoBehaviour
	{
		[SerializeField]
		public SpawnableCrateReference spawnableCrateReference;

		[SerializeField]
		public CrateQuery crateQuery;

		public bool useQuery;

		[SerializeField]
		[Tooltip("Trigger the Placer manually through PlaceSpawnable()")]
		public bool manualMode;

		[SerializeField]
		public OnPlaceEvent OnPlaceEvent;

		[SerializeField]
		public bool previewMeshInPlaymode;

		[SerializeField]
		public Material playmodePreviewMaterial;

		public Func<bool> shouldPlace;

		[SerializeField]
		[ReadOnly(false)]
		private bool placed;

		[ReadOnly(false)]
		[SerializeField]
		private bool placing;

		[SerializeField]
		[ReadOnly(false)]
		public GameObject placedSpawnable;

		private Spawnable spawnable;

		private bool runtimeMeshGenerated;

		private MarrowAsset runtimeMeshAsset;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private UniTaskVoid DelayedStart()
		{
			return default(UniTaskVoid);
		}

		private SpawnableCrateReference GetCrateReference()
		{
			return null;
		}

		[ContextMenu("Place Spawnable")]
		public void PlaceSpawnable()
		{
		}

		public UniTask PlaceSpawnableAsync()
		{
			return default(UniTask);
		}

		public void RePlaceSpawnable()
		{
		}

		[ContextMenu("Run Query")]
		private void RunQuery()
		{
		}

		[ContextMenu("Create Runtime Preview")]
		private void CreateRuntimePreview()
		{
		}

		private void OnDestroy()
		{
		}

		public SpawnableCratePlacer()
			: base()
		{
		}
	}
}
