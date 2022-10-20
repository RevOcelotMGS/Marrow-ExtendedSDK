using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Props;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Combat
{
	[RequireComponent(typeof(Collider))]
	public class Powerable_DamageVolume : Powerable
	{
		[Header("Layer needs to be Trigger to attack")]
		[Range(0.25f, 10f)]
		public float tickFrequency;

		public float damage;

		public AttackType damageType;

		public Transform damageSourceTransform;

		[Tooltip("Setting 0 will make damage always be at an effective distance")]
		public float effectiveDistance;

		private float _damageScale;

		public float map_low;

		public float map_high;

		private Dictionary<GameObject, Rigidbody> _goToRbMap;

		private Dictionary<Rigidbody, int> _rigidbodyRefs;

		private List<PlayerDamageReceiver> _playerDamageRecievers;

		private List<ObjectDestructable> _objectDamageRecievers;

		private int _affectedProxiesCount;

		private float _lastTickTime;

		[Header("Velocity Damage")]
		public bool staticVelocityDamage;

		public bool invertVelocity;

		public Rigidbody assosiatedRb;

		public float velocityMinimum;

		public float velocityMaximum;

		[Header("Distance Settings")]
		public bool scaleDamageWithDistance;

		public float distanceMinimum;

		public float distanceMaximum;

		private List<Rigidbody> _rbToRemove;

		private void Awake()
		{
		}

		private bool AddDamageRecieverInformation(Rigidbody rb)
		{
			return default(bool);
		}

		private bool RemoveDamageRecieverInformation(Rigidbody rb)
		{
			return default(bool);
		}

		private void OnDespawn(GameObject go)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void Update()
		{
		}

		public void ProcessDamage(Rigidbody rb, float mult)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		public override void SwitchPowerOnOff(bool isOn)
		{
		}

		public override void VoltageToObject(float voltage, int id = 0)
		{
		}

		private void OnDrawGizmos()
		{
		}

		public Powerable_DamageVolume()
			: base()
		{
		}
	}
}
