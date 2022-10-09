using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace SLZ.Props
{
	internal class Fizzler : MonoBehaviour
	{
		private HashSet<Rigidbody> claimedRBs;

		[SerializeField]
		private Color m_despawnColor;

		private void Awake()
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		private IEnumerator CoDelayDespawn(AssetPoolee poolee, Rigidbody rb)
		{
			return null;
		}

		public Fizzler()
			: base()
		{
		}
	}
}
