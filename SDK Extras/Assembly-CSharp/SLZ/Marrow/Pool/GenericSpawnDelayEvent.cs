using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow.Pool
{
	public class GenericSpawnDelayEvent : SpawnEvents
	{
		public float secondsUntilEvent;

		public UnityEvent delayedEvent;

		protected override void OnSpawn(GameObject go)
		{
		}

		private UniTaskVoid AsyncDespawn(int timeMs)
		{
			return default(UniTaskVoid);
		}

		public GenericSpawnDelayEvent()
			: base()
		{
		}
	}
}
