using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Marrow_ExtendedSDK.StubClasses;
using SLZ.Interaction;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourBoidAgent_SlicedInference : InferenceAgent
	{
		private int fixed_counter;

		private float[] incomingActions;

		private Dictionary<string, float[]> lastActionDict;

		public BehaviourBoid behaviour;

		private InteractableHost host;

		public BoidController boidController;

		public BoidSensor boidSensor;

		public Rigidbody _rb;

		private float roll;

		private float pitch;

		private float yaw;

		public bool use_cohesion;

		public bool use_alignment;

		public bool use_neighbor;

		public bool ep_rndm_start;

		public bool useHitObservations;

		private float ray_val;

		public bool log_losses;

		public bool log_cum_reward;

		private EnvironmentParameters envParams;

		public bool override_track;

		public GameObject override_ref;

		public bool findBoidBall;

		public BehaviourBoidBall behaviourBoidBall;

		private void UpdateTarget()
		{
		}

		public override void Setup()
		{
		}

		public void Initialize()
		{
		}

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void ConnectToBallManager(BoidBallManager mngr)
		{
		}

		public void OnEpisodeBegin()
		{
		}

		public override void OnActionReceived(Dictionary<string, float[]> actionBuffers)
		{
		}

		private void FixedUpdate()
		{
		}

		public override void CollectObservations()
		{
		}

		public BehaviourBoidAgent_SlicedInference()
			: base()
		{
		}

		public event Action AgentInit;
	}
}
