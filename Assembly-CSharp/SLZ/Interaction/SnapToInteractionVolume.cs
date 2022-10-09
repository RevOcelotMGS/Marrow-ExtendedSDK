using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Interaction
{
	public class SnapToInteractionVolume : InteractionVolume
	{
		private Transform targetTransform;

		public Transform exitTransform;

		private InteractableHost attachedHost;

		private bool isAttached;

		private Coroutine detachGrabCoroutine;

		protected override void OnHoverEnd(InteractableHost host)
		{
		}

		protected override void OnHoverStart(InteractableHost host)
		{
		}

		protected override void OnHoverUpdate(InteractableHost host)
		{
		}

		private void AttachInteractable(InteractableHost host)
		{
		}

		private void DetachInteractable()
		{
		}

		private void FixedUpdate()
		{
		}

		private void DetachGrab()
		{
		}

		private IEnumerator CoDetatchGrab()
		{
			return null;
		}

		public SnapToInteractionVolume()
			: base()
		{
		}
	}
}
