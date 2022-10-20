using System;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Props.Weapons
{
	public class WeaponSlot : MonoBehaviour
	{
		[Flags]
		public enum SlotType
		{
			SIDEARM = 1,
			PRIMARY = 2,
			SECONDARY = 4,
			HEAD = 8
		}

		private static ComponentCache<WeaponSlot> _cache;

		[Header("Options")]
		public SlotType slotType;

		[Header("References")]
		public InteractableHost interactableHost;

		public AmmoSocket magazineSocket;

		public Gun gun;

		public Grip grip;

		public UnityEvent onSlotInsert;

		public UnityEvent onSlotRemove;

		public static ComponentCache<WeaponSlot> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public WeaponSlot()
			: base()
		{
		}
	}
}
