using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Props.Weapons
{
	public class PowerGlove : MonoBehaviour
	{
		public ConeCheck forceCone;

		public Grip triggerGrip;

		private bool _isTriggerDownOnGrab;

		private Rigidbody[] _playerRbs;

		private InteractableHost _host;

		private IEnumerator FunctionDelay(Action callback)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnTriggerHandAttached(Hand hand)
		{
		}

		private void OnTriggerGripUpdate(Hand hand)
		{
		}

		private void DisableNoClip()
		{
		}

		private void OnTriggerHandDetached(Hand hand)
		{
		}

		public PowerGlove()
			: base()
		{
		}
	}
}
