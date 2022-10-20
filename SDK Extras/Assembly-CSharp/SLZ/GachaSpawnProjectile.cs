using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ
{
	public class GachaSpawnProjectile : SpawnEvents
	{
		private static ComponentCache<GachaSpawnProjectile> _cache;

		public Rigidbody rb;

		public Spawnable spawnable;

		public MeshFilter previewMeshFilter;

		public Transform previewMeshTransform;

		public float startScale;

		public CurveData growAnim;

		public static ComponentCache<GachaSpawnProjectile> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		protected override void OnPostSpawn(GameObject go)
		{
		}

		private UniTaskVoid AsyncSpawnProcedure()
		{
			return default(UniTaskVoid);
		}

		public GachaSpawnProjectile()
			: base()
		{
		}
	}
}
