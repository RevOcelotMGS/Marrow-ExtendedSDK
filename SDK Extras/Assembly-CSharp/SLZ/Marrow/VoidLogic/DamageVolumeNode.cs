using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Combat;
using SLZ.Marrow.Data;
using SLZ.Props;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Damage Volume")]
	public class DamageVolumeNode : BaseNode
	{
		[SerializeField]
		[Header("Damage")]
		[Range(0.25f, 10f)]
		private float _tickFrequency;

		[SerializeField]
		private float _damage;

		[SerializeField]
		private AttackType _damageType;

		[SerializeField]
		private Transform _damageSourceTransform;

		[Tooltip("Setting 0 will make damage always be at an effective distance")]
		[SerializeField]
		private float _effectiveDistance;

		private float _damageScale;

		[SerializeField]
		private float _mapLow;

		[SerializeField]
		private float _mapHigh;

		private Dictionary<GameObject, Rigidbody> _gameObjectToRigidbodyMap;

		private Dictionary<Rigidbody, int> _rigidbodyRefcounts;

		private List<PlayerDamageReceiver> _playerDamageRecievers;

		private List<ObjectDestructable> _objectDamageRecievers;

		private float _lastTickTime;

		[Header("Velocity Damage")]
		public bool staticVelocityDamage;

		public bool invertVelocity;

		public Rigidbody associatedRb;

		public float velocityMinimum;

		public float velocityMaximum;

		[Header("Distance Settings")]
		public bool scaleDamageWithDistance;

		public float distanceMinimum;

		public float distanceMaximum;

		private List<Rigidbody> _rigidbodiesToRemove;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		private int _AffectedProxiesCount
		{
			get
			{
				return default(int);
			}
		}

		protected override float CalculateValue()
		{
			return default(float);
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private bool OnFirstRigidbodyAdded(Rigidbody rb)
		{
			return default(bool);
		}

		private bool AddDamageReceiverInformation(Rigidbody rb)
		{
			return default(bool);
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnLastRigidbodyRemoved(Rigidbody rb, int removedCount)
		{
		}

		private bool RemoveDamageReceiverInformation(Rigidbody rb)
		{
			return default(bool);
		}

		private void OnDespawn(GameObject go)
		{
		}

		public void ProcessDamage(Rigidbody rb, float mult)
		{
		}

		public override IReadOnlyList<InputDescription> DescribeInputs()
		{
			return null;
		}

		public DamageVolumeNode()
			: base()
		{
		}
	}
}
