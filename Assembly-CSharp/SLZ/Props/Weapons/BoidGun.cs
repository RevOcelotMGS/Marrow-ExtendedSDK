using SLZ.Interaction;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Props.Weapons
{
	public class BoidGun : MonoBehaviour
	{
		public Grip triggerGrip;

		public Transform spawnPointTransform;

		public GunSFX gunSFX;

		private bool bmmActive;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTriggerGripAttached(Hand hand)
		{
		}

		private void OnTriggerGripDetached(Hand hand)
		{
		}

		private void OnTriggerGripUpdate(Hand hand)
		{
		}

		private void Fire()
		{
		}

		public BoidGun()
			: base()
		{
		}
	}
}
