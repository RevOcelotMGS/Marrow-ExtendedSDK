using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Interaction
{
	public class InventorySlot : MonoBehaviour
	{
		public delegate void SlotDelegate(InventorySlot slot);

		[HideInInspector]
		public GameObject itemGameObject;

		public void Insert(GameObject go)
		{
		}

		public void Remove()
		{
		}

		public InventorySlot()
			: base()
		{
		}

		public event SlotDelegate slotInsertEvent;

		public event SlotDelegate slotRemoveEvent;
	}
}
