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

		public new void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		private void TakeDelayedAction()
		{
		}

		public void SetArtTargetRotation(Transform transform, float x, float y, float z, float lowX, float highX, float lowY, float highY, float lowZ, float highZ)
		{
		}

		private void Awake()
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
