using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

namespace RootMotion.Demos
{
	[Serializable]
	public class Navigator
	{
		public enum State
		{
			Idle = 0,
			Seeking = 1,
			OnPath = 2
		}

		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		private Transform transform;

		private int cornerIndex;

		private Vector3[] corners;

		private NavMeshPath path;

		private Vector3 lastTargetPosition;

		private bool initiated;

		private float nextPathTime;

		public Vector3 normalizedDeltaPosition { get; private set; }

		public State state { get; private set; }

		public void Initiate(Transform transform)
		{
		}

		public void Update(Vector3 targetPosition)
		{
		}

		private void CalculatePath(Vector3 targetPosition)
		{
		}

		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		private void Stop()
		{
		}

		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		public void Visualize()
		{
		}

		public Navigator()
			: base()
		{
		}
	}
}
