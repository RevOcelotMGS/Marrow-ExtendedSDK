using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Rig;
using SLZ.SFX;
using SLZ.VFX;
using UnityEngine;

namespace SLZ.Props.Weapons
{
	public class GravityGun : MonoBehaviour
	{
		public Grip triggerGrip;

		private Rigidbody m_GrabbedRigidbody;

		private Animator animator;

		private GravGunSFX sfx;

		private bool m_IsPulling;

		private bool m_IsGrabbed;

		[Header("References")]
		public Transform firePoint;

		public GravityManipulatorJob gravityManipulator;

		public QuadLine quadline;

		public GameObject blastVFXObject;

		private Coroutine blastConfirmCoroutine;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void StopBlastConfirm()
		{
		}

		private void StartBlastConfirm(BaseController controller, float duration = 0.25f)
		{
		}

		private IEnumerator CoBlastConfirm(BaseController controller, float duration = 0.25f)
		{
			return null;
		}

		private void Blast()
		{
		}

		private void OnTriggerGripAttached(Hand hand)
		{
		}

		private void OnTriggerGripDetached(Hand hand)
		{
		}

		public GravityGun()
			: base()
		{
		}
	}
}
