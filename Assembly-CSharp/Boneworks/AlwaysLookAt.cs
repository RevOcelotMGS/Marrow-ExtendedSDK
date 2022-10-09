using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Zones;
using UnityEngine;

namespace Boneworks
{
	public class AlwaysLookAt : ZoneItem
	{
		public Transform local;

		public Transform target;

		public bool isPhysics;

		public ConfigurableJoint jnt_Rotator;

		private void Start()
		{
		}

		private IEnumerator TickLook()
		{
			return null;
		}

		private void UpdateLookat()
		{
		}

		private void OnDisable()
		{
		}

		public AlwaysLookAt()
			: base()
		{
		}
	}
}
