using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-restriction-component/")]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AddComponentMenu("RayFire/Rayfire Restriction")]
	public class RayfireRestriction : MonoBehaviour
	{
		public enum RFBoundActionType
		{
			Fade = 2,
			Reset = 4,
			PostDemolitionAction = 9
		}

		public enum RFDistanceType
		{
			InitializePosition = 0,
			TargetPosition = 2
		}

		public enum RFBoundTriggerType
		{
			Inside = 0,
			Outside = 2
		}

		public bool enable;

		public RFBoundActionType breakAction;

		public float actionDelay;

		public float checkInterval;

		public float distance;

		public RFDistanceType position;

		public Transform target;

		public Collider Collider;

		public RFBoundTriggerType region;

		public bool broke;

		public void CopyFrom(RayfireRestriction rest)
		{
		}

		public void Reset()
		{
		}

		private void Awake()
		{
		}

		public static void InitRestriction(RayfireRigid scr)
		{
		}

		private static void BrokeRestriction(RayfireRigid scr)
		{
		}

		private static IEnumerator RestrictionDistanceCor(RayfireRigid scr)
		{
			return null;
		}

		private static IEnumerator RestrictionTriggerCor(RayfireRigid scr)
		{
			return null;
		}

		public RayfireRestriction()
			: base()
		{
		}
	}
}
