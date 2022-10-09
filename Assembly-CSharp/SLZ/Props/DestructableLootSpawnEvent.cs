using System;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Props
{
	[Serializable]
	public class DestructableLootSpawnEvent : UnityEvent<ObjectDestructable, Spawnable, GameObject>
	{
		public DestructableLootSpawnEvent()
			: base()
		{
		}
	}
}
