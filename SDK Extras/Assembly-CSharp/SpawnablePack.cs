using System;
using System.Collections.Generic;
using SLZ.Marrow.Warehouse;

[Serializable]
public class SpawnablePack
{
	public List<SpawnableCrateReference> spawnableList;

	public SpawnablePack()
		: base()
	{
	}
}
