using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[DisallowMultipleComponent]
	public class MarrowBody : MarrowBehaviour
	{
		private static ComponentCache<MarrowBody> _cache;

		[SerializeField]
		private Collider[] _colliders;

		[SerializeField]
		private Rigidbody _rigidbody;

		[SerializeField]
		private RigidbodyInfo _rigidbodySettings;

		[SerializeField]
		private MarrowBodyTracker _tracker;

		private RigidbodyInfo _rbFreezeInfo;

		public static ComponentCache<MarrowBody> Cache
		{
			get
			{
				return null;
			}
		}

		public SimpleTransform InitInEntityTransform { get; private set; }

		public bool HasRigidbody { get; private set; }

		public MarrowEntity Entity { get; private set; }

		public Bounds Bounds { get; private set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void DestroyRigidbody()
		{
		}

		public void CreateRigidbody()
		{
		}

		public void ResetConfig()
		{
		}

		public bool TryGetRigidbody([Out] Rigidbody rigidbody)
		{
			return default(bool);
		}

		public MarrowBody()
			: base()
		{
		}
	}
}
