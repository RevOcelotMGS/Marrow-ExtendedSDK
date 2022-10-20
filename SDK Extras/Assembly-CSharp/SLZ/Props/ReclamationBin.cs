using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace SLZ.Props
{
	public class ReclamationBin : MonoBehaviour
	{
		private HashSet<Rigidbody> claimedRBs;

		private Color m_despawnColor;

		[SerializeField]
		private Spawnable sandboxModuleSpawnable;

		[SerializeField]
		private Spawnable redactedModuleSpawnable;

		[SerializeField]
		private Spawnable handgunModuleSpawnable;

		[SerializeField]
		private Spawnable tuscanyModuleSpawnable;

		[SerializeField]
		private Spawnable hoverJunkersModuleSpawnable;

		[SerializeField]
		private Spawnable boardGun;

		[SerializeField]
		private Spawnable junkShip;

		private void Awake()
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		private void ACHIEVEMENTUNLOCKS()
		{
		}

		private IEnumerator CoDelayDespawn(AssetPoolee poolee, Rigidbody rb, bool hasHost, InteractableHost host)
		{
			return null;
		}

		public ReclamationBin()
			: base()
		{
		}
	}
}
