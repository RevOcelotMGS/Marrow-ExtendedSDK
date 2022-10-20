using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;

namespace SLZ
{
	[RequireComponent(typeof(Rigidbody))]
	public class CaseEject : MonoBehaviour
	{
		private static ComponentCache<CaseEject> _cache;

		public Rigidbody rb;

		public ShellSFX shellSfx;

		public float startSpeed;

		public float startAxisSpeed;

		private WaitForSeconds _wfs;

		private Vector3 localScale;

		public static ComponentCache<CaseEject> Cache
		{
			get
			{
				return null;
			}
		}

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void ForceInDirection(Vector3 startDirection, Vector3 startRotationAxis, Rigidbody hostRigidbody)
		{
		}

		public void OnDisable()
		{
		}

		public void OnDestroy()
		{
		}

		private IEnumerator CoColiderEnable()
		{
			return null;
		}

		public CaseEject()
			: base()
		{
		}
	}
}
