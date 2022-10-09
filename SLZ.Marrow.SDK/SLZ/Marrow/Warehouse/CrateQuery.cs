using System;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class CrateQuery : CrateReference
	{
		private class CrateQueryFilter : ICrateFilter<Crate>
		{
			private readonly string tagFilter;

			private readonly string titleFilter;

			public CrateQueryFilter(string tagFilter, string titleFilter)
				: base()
			{
			}

			public bool Filter(Crate crate)
			{
				return default(bool);
			}
		}

		[SerializeField]
		public string tagFilter;

		[SerializeField]
		public string titleFilter;

		private bool queryRan;

		private Barcode tempBarcode;

		public void RunQuery()
		{
		}

		public CrateQuery()
			: base()
		{
		}
	}
}
