using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Arena
{
	public class Arena_BellInteractable : MonoBehaviour
	{
		public enum BellState
		{
			UP = 0,
			DOWN = 1,
			MOVING = 2
		}

		[SerializeField]
		private Arena_GameController arenaGameController;

		public BellState bellState;

		public bool visDebug;

		public float timeToTop;

		public float timeToBottom;

		public BellBodies bellBods;

		public Rigidbody[] bellBodies;

		public CylinderGrip grip;

		public GameObject bellSwingObj;

		[HideInInspector]
		public Rigidbody hoverBody;

		private float bellPerc;

		public AnimationCurve upCurve;

		public ConfigurableJoint topJoint;

		private Vector3 bottomTargPos;

		private Vector3 topTargPos;

		private Coroutine bellMoveRoutine;

		private LineRenderer Liner;

		[SerializeField]
		public GameObject Point1;

		[SerializeField]
		public GameObject Point2;

		private void Awake()
		{
		}

		public void UpdateTargetPosition(float targetY)
		{
		}

		private void Update()
		{
		}

		[ContextMenu("MoveBellDown")]
		public void MoveBellDown()
		{
		}

		[ContextMenu("MoveBellUp")]
		public void MoveBellUp()
		{
		}

		public void MoveBell(bool moveUp)
		{
		}

		private IEnumerator MoveBell(bool up, float duration, Vector3 currentPosition)
		{
			return null;
		}

		public void ResetBell()
		{
		}

		private IEnumerator CoResetBell()
		{
			return null;
		}

		[ContextMenu("Get All Local Positions")]
		private void GetAllReferences()
		{
		}

		public Arena_BellInteractable()
			: base()
		{
		}
	}
}
