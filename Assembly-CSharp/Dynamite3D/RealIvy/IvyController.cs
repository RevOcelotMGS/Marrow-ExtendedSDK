using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class IvyController : MonoBehaviour
	{
		public enum State
		{
			GROWTH_NOT_STARTED = 0,
			WAITING_FOR_DELAY = 1,
			PAUSED = 2,
			GROWING = 3,
			GROWTH_FINISHED = 4
		}

		private float currentTimer;

		public RTIvy rtIvy;

		public IvyContainer ivyContainer;

		public IvyParameters ivyParameters;

		public RuntimeGrowthParameters growthParameters;

		private State state;

		private void Awake()
		{
		}

		[ContextMenu("Start Growth")]
		public void StartGrowth()
		{
		}

		[ContextMenu("Pause Growth")]
		public void PauseGrowth()
		{
		}

		[ContextMenu("Resume Growth")]
		public void ResumeGrowth()
		{
		}

		public State GetState()
		{
			return default(State);
		}

		private void Update()
		{
		}

		private void UpdateWaitingForDelayState(float deltaTime)
		{
		}

		private void UpdateGrowingState(float deltaTime)
		{
		}

		public IvyController()
			: base()
		{
		}

		public event Action OnGrowthStarted;

		public event Action OnGrowthPaused;

		public event Action OnGrowthFinished;
	}
}
