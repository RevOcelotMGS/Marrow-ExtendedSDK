using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RealisticEyeMovements
{
	public class DestroyNotifier : MonoBehaviour
	{
		private void OnDestroyed()
		{
		}

		public DestroyNotifier()
			: base()
		{
		}

		public event Action<DestroyNotifier> OnDestroyedEvent;
	}
}
