using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourSecurityCam : BehaviourBaseNav
	{
		public Transform target;

		public Action behaviourDead;

		public bool actionReady;

		public float[] incomingActions;

		private int _deathAnim;

		private float _animationBlendWeight;

		private float _animationBlendWeightV;

		private float _blendToAnimationTime;

		public SubBehaviourIk ik;

		public GameObject throwVfx;

		public float artSlerpDrive;

		private JointDrive old;

		private bool damagedJoint;

		public MentalState[] start_state_list;

		public int start_state_ind;

		protected override void OnInitiate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		public new void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		public override void KillStart()
		{
		}

		public override void KillEnd()
		{
		}

		private void TakeDelayedAction()
		{
		}

		public void SetArtTargetRotation(Transform transform, float x, float y, float z, float lowX, float highX, float lowY, float highY, float lowZ, float highZ)
		{
		}

		protected override void OnReadBehaviour()
		{
		}

		protected override void OnWriteBehaviour()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		protected override void ResetAnimator()
		{
		}

		public override void Freeze()
		{
		}

		public override void Unfreeze()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void Awake()
		{
		}

		protected override void AiUpdate()
		{
		}

		protected override void AiTick()
		{
		}

		protected override void SwitchMentalState(MentalState mState)
		{
		}

		protected override void SwitchLocoState(LocoState lState, float coolDown = 0f, bool forceSwitch = false)
		{
		}

		protected override void ReturnToPreAgro()
		{
		}

		private void OnApplicationQuit()
		{
		}

		public BehaviourSecurityCam()
			: base()
		{
		}

		public event Action OnNewTarget;
	}
}
