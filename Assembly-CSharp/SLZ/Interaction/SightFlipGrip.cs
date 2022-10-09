using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Interaction
{
	public class SightFlipGrip : TargetGrip
	{
		public Transform sight;

		public Transform openSight;

		public Transform closedSight;

		private bool isUp;

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		private IEnumerator CoFlipSight(Transform target)
		{
			return null;
		}

		public SightFlipGrip()
			: base()
		{
		}
	}
}
