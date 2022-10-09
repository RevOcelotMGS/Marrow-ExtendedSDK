using System;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class OnPlaceEvent : UnityEvent<SpawnableCratePlacer, GameObject>
	{
		public OnPlaceEvent()
			: base()
		{
		}
	}
}
