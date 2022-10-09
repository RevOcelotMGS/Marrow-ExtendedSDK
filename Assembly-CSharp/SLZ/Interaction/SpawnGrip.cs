using System;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class SpawnGrip : HandReciever
	{
		[Range(0f, 10f)]
		public float priority;

		public Action<Hand> onSpawnGrabDelegate;

		[SerializeField]
		private bool enableUpdateVolume;

		[SerializeField]
		private CapsuleCollider _interactableCol;

		[SerializeField]
		private Transform _t1Tran;

		public Vector3 t1PlaneOffset;

		private static ComponentCache<SpawnGrip> _cache;

		public new static ComponentCache<SpawnGrip> Cache
		{
			get
			{
				return null;
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		private void Update()
		{
		}

		public override float ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return default(float);
		}

		private void UpdateInteractionVolume()
		{
		}

		public SpawnGrip()
			: base()
		{
		}
	}
}
