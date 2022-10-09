using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Warehouse;

namespace SLZ.Data.SaveData
{
	[Serializable]
	public struct Replacement
	{
		public SpawnableCrateReference From
		{
			[IsReadOnly]
			get;
			private set; }

		public SpawnableCrateReference To
		{
			[IsReadOnly]
			get;
			private set; }
	}
}
