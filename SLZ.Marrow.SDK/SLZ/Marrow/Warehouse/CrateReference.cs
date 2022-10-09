using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public abstract class CrateReference : ICrateReference
	{
		[SerializeField]
		protected Barcode _barcode;

		[SerializeField]
		private string _version;

		[SerializeField]
		private Barcode _palletBarcode;

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

		public string Version
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Barcode PalletBarcode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual Crate Crate
		{
			get
			{
				return null;
			}
		}

		public CrateReference()
			: base()
		{
		}

		public CrateReference(string barcode)
			: this()
		{
		}

		public bool TryGetCrate([Out] Crate crate)
		{
			return default(bool);
		}

		public bool IsValid()
		{
			return default(bool);
		}

		public static bool IsValid(CrateReference crateReference)
		{
			return default(bool);
		}
	}
}
