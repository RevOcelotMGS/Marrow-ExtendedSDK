using System;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class PalletReference
	{
		[SerializeField]
		protected Barcode _barcode;

		[SerializeField]
		private string _version;

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

		public PalletReference()
			: base()
		{
		}
	}
}
