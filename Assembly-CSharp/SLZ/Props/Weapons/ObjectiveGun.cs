using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Props.Weapons
{
	public class ObjectiveGun : Gun
	{
		[Header("Spawn Options")]
		public LayerMask collisionLayers;

		public float effectiveRange;

		public bool wackySpinWhenUpsideDown;

		public bool isDespawnMode;

		public GameObject laserPointerGameObject;

		private InferenceAgent _selectedAgent;

		private Transform trackedTransform;

		private GameObject placeHolder;

		private bool _isOptionsActive;

		private ObjetiveModes _selectedMode;

		private RaycastHit _hitInfo;

		private Hand currentHand;

		protected override void Awake()
		{
		}

		protected override void OnPostSpawn(GameObject go)
		{
		}

		private void OnSpawnHandAttached(Hand hand)
		{
		}

		private void OnSpawnHandDetached(Hand hand)
		{
		}

		public void Flash()
		{
		}

		private IEnumerator CoFireFlash()
		{
			return null;
		}

		protected void OnAgentSelected(InferenceAgent agent)
		{
		}

		protected void OnModeSelect(ObjetiveModes mode)
		{
		}

		public override void Fire()
		{
		}

		private void SetAgent()
		{
		}

		protected override void OnFire()
		{
		}

		protected override void OnTriggerGripAttached(Hand hand)
		{
		}

		protected override void OnTriggerGripDetached(Hand hand)
		{
		}

		public ObjectiveGun()
			: base()
		{
		}
	}
}
