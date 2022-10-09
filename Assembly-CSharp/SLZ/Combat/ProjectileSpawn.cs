using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Combat
{
	public class ProjectileSpawn : MonoBehaviour
	{
		[Header("Options")]
		public LayerMask collisionLayers;

		[Tooltip("Effective Range of Raycast")]
		public float effectiveRange;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private IEnumerator CoDelayFire(Vector3 position, Vector3 forward)
		{
			return null;
		}

		public ProjectileSpawn()
			: base()
		{
		}
	}
}
