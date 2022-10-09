using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ;
using SLZ.AI;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourBaseTurret : BehaviourBaseNav
	{
		private static ComponentCache<BehaviourBaseNav> _cache;

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

		public SplineBody splineBody;

		public SplineJoint splineJoint;

		public MentalState[] start_state_list;

		public int start_state_ind;

		public new static ComponentCache<BehaviourBaseNav> Cache
		{
			get
			{
				return null;
			}
		}

		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		public new void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		private void TakeDelayedAction()
		{
		}

		private void Awake()
		{
		}

		private void OnApplicationQuit()
		{
		}

		public BehaviourBaseTurret()
			: base()
		{
		}

		public event Action OnNewTarget;
	}
}
