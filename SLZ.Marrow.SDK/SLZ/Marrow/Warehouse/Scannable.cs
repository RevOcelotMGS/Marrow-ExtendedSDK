using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	public abstract class Scannable : ScriptableObject, IScannable, IReadOnlyScannable
	{
		[SerializeField]
		private Barcode _barcode;

		[SerializeField]
		private Barcode _barcodeOld;

		[SerializeField]
		private MarrowGuid _slimCode;

		[Delayed]
		[SerializeField]
		private string _title;

		[SerializeField]
		private string _description;

		[SerializeField]
		[Tooltip("Locks the crate from the user until it is unlocked")]
		private bool _unlockable;

		[Tooltip("Hides the crate from Menus")]
		[SerializeField]
		private bool _redacted;

		private List<PackedAsset> packedAssets;

		public Barcode Barcode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Barcode BarcodeOld
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MarrowGuid SlimCode
		{
			get
			{
				return default(MarrowGuid);
			}
			set
			{
			}
		}

		public string Title
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Unlockable
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool Redacted
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public List<PackedAsset> PackedAssets
		{
			get
			{
				return null;
			}
		}

		public void GenerateBarcode(bool forceGeneration = false)
		{
		}

		public abstract void GenerateBarcodeInternal(bool forceGeneration = false);

		public virtual List<PackedAsset> CollectPackedAssets()
		{
			return null;
		}

		public Scannable()
			: base()
		{
		}
	}
}
