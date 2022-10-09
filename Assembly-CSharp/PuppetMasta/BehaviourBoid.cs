using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourBoid : BehaviourBaseNav
	{
		public Transform target;

		public Action behaviourDead;

		public bool actionReady;

		public float[] incomingActions;

		public BehaviourBoidAgent_SlicedInference boidAgent;

		private int _armsLayer;

		private int _mSecAnim;

		private int _locoCycleAnim;

		private int _flinchAnim;

		private int _spinAttackAnim;

		private int _angryAnim;

		private int _awakeAnim;

		private int _unGroundedAnim;

		private int _emissColor;

		private int _attackAnim;

		private int _clipIntAnim;

		private int _gestureAnim;

		private int _deathAnim;

		private float _animationBlendWeight;

		private float _animationBlendWeightV;

		private float _blendToAnimationTime;

		public RigidBodyDamageDealer[] dmgDealers;

		public SubBehaviourIk ik;

		public GameObject throwVfx;

		public Spawnable despawnVFX;

		public bool findBehaviourBall;

		public float impulseDmgThresh;

		public float wayPointTime;

		public float wayPointCounter;

		public float bluntAttackTime;

		public float bluntAttackCounter;

		public GameObject[] wayPoints;

		private BehaviourBoidBall behaviourBall;

		public InteractableHost intHost;

		public Grip grip;

		public BarracudaModelManagerMono modelManager;

		public InferenceAgent agent;

		public MentalState[] start_state_list;

		public int start_state_ind;

		private int trigger_layer;

		[Tooltip("Number bettween 0 and 1 for whether boid will attack each attack (behaviour) tick")]
		[Range(0f, 1f)]
		public float attackProbability;

		[Tooltip("Maximum amount of time the boid spools up during attack")]
		public float maxSpoolTime;

		[Tooltip("Min amount of time the boid spools up during attack")]
		public float minSpoolTime;

		private float attackDecision;

		private float desiredSpoolTime;

		private float currentSpoolTime;

		public float agroTickRate;

		public float agroAttackDistanceThresh;

		public MentalState MState
		{
			get
			{
				return default(MentalState);
			}
			set
			{
			}
		}

		public static BehaviourBoidBall FindBall(GameObject childObject)
		{
			return null;
		}

		public void MlZoneCallbackResponse()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void TakeDelayedAction()
		{
		}

		public new void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		private IEnumerator BluntAttackStun(float damage)
		{
			return null;
		}

		public void DetatchGrip()
		{
		}


		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		private void SetAgentActive()
		{
		}

		private void SetAgentInactive()
		{
		}

		private void Awake()
		{
		}

		private IEnumerator SpoolCounter()
		{
			return null;
		}

		private void OnApplicationQuit()
		{
		}

		public BehaviourBoid()
			: base()
		{
		}

		public event Action OnNewTarget;
	}
}
