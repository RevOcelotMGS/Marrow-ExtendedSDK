using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class InteractableHostManager : MonoBehaviour
	{
		private static ComponentCache<InteractableHostManager> _cache;

		public InteractableHost[] hosts;

		public Action<InteractableHost, Hand> onHandAttached;

		public Action<InteractableHost, Hand> onHandDetached;

		[HideInInspector]
		public List<InteractableHost> grabbedHosts;

		public static ComponentCache<InteractableHostManager> Cache
		{
			get
			{
				return null;
			}
		}

		public float TotalMass { get; private set; }

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		public void OnDetachedHand(InteractableHost host, Hand hand)
		{
		}

		public void ForceDetachAll()
		{
		}

		public void EnableCollisonAll()
		{
		}

		public void DisableCollisionAll()
		{
		}

		public void EnableInteractionAll()
		{
		}

		public void DisableInteractionAll()
		{
		}

		public InteractableHostManager()
			: base()
		{
		}
	}
}
