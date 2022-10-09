using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using SLZ.Utilities;
using UnityEngine;

namespace SLZ.Combat
{
	public class FirearmCartridge : SpawnEvents
	{
		private static ComponentCache<FirearmCartridge> _cache;

		private RigidbodyData _rbData;

		private bool _isStatic;

		public Rigidbody rb;

		public Collider col;

		public ShellSFX shellSfx;

		public float despawnDelaySeconds;

		public float startSpeed;

		public float startAxisSpeed;

		public static ComponentCache<FirearmCartridge> Cache
		{
			get
			{
				return null;
			}
		}

		private void Reset()
		{
		}

		protected void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		protected override void OnDespawn(GameObject go)
		{
		}

		protected override void OnSpawn(GameObject go)
		{
		}

		public void ForceInDirection(Vector3 startDirection, Vector3 startRotationAxis, Rigidbody hostRigidbody)
		{
		}

		private UniTaskVoid ColliderEnableDelay()
		{
			return default(UniTaskVoid);
		}

		private UniTaskVoid DisableDelay()
		{
			return default(UniTaskVoid);
		}

		public void MakeStatic()
		{
		}

		public void MakeDynamic()
		{
		}

		public FirearmCartridge()
			: base()
		{
		}
	}
}
