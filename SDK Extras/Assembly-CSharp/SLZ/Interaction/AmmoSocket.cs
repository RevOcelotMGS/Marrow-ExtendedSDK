using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Props.Weapons;
using UnityEngine;

namespace SLZ.Interaction
{
	public class AmmoSocket : Socket
	{
		[Header("Magazine Socket")]
		public string platform;

		[Header("References")]
		public Grip primaryGrip;

		public Gun gun;

		public bool despawnOnInsert;

		private bool _isHostGrabbed;

		private bool _isMagazineInserted;

		private bool _isProxyGripState;

		private AmmoPlug _magazinePlug;

		public override bool IsClearOnInsert
		{
			get
			{
				return default(bool);
			}
		}

		public bool hasMagazine
		{
			get
			{
				return default(bool);
			}
		}

		protected override void Awake()
		{
		}

		public InteractableHost GetHost()
		{
			return null;
		}

		private void OnPlugLocked(Plug plug)
		{
		}

		private void OnPlugUnlocked()
		{
		}

		protected override void OnPlugEnter(Plug plug)
		{
		}

		protected override void OnPlugExit(Plug plug)
		{
		}

		private void UpdateProxyGripState(Hand hand)
		{
		}

		public void EjectMagazine()
		{
		}

		private void UpdateMagGripPriority(int ammoCount)
		{
		}

		private void OnAttachedHandDelegate(InteractableHost host, Hand hand)
		{
		}

		private void OnDetachedHandDelegate(InteractableHost host, Hand hand)
		{
		}

		private void ForceLoad(MagazineData magazineData)
		{
		}

		public AmmoSocket()
			: base()
		{
		}
	}
}
