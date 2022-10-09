using SLZ.AI;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Props
{
	[RequireComponent(typeof(Collider))]
	internal class ItemDropper : MonoBehaviour
	{
		public bool dropHands;

		public bool despawnOnDrop;

		public InventorySlotReceiver[] inventorySlotReceivers;

		public AudioClip dropClip;

		public UnityEvent OnDrop;

		private void Awake()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void RemoveItem(IGrippable host)
		{
		}

		private void DropItems(TriggerRefProxy playerProxy)
		{
		}

		[ContextMenu("GetWeaponSlots")]
		public void GetWeaponSlots()
		{
		}

		public ItemDropper()
			: base()
		{
		}
	}
}
