using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Props.Weapons
{
	public class GravityStaffReciever : MonoBehaviour
	{
		public float pickupCooldown;

		public GravityManipulatorJob manipulator;

		private CoreBomb _activeCore;

		private List<Collider> _activeCoreColliders;

		private bool _isActive;

		public float _lastDropTime;

		private void Awake()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public void Deactivate()
		{
		}

		public void Activate()
		{
		}

		private void OnCoreCiticalHit()
		{
		}

		public GravityStaffReciever()
			: base()
		{
		}
	}
}
