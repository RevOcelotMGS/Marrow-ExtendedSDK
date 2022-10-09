using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Data.SaveData
{
	[CreateAssetMenu(fileName = "InventorySaveFilter", menuName = "StressLevelZero/Inventory Save Filter")]
	public class InventorySaveFilter : ScriptableObject
	{
		private Dictionary<Barcode, Barcode> _replacementMap;

		public List<Replacement> Replacements { get; private set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public Barcode Filter(Barcode barcode)
		{
			return null;
		}

		public InventorySaveFilter()
			: base()
		{
		}
	}
}
