using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Playables;

namespace SLZ.Bonelab
{
	public class TutorialElevator : MonoBehaviour
	{
		[SerializeField]
		private PlayableDirector director;

		[SerializeField]
		private float stage1Speed;

		[SerializeField]
		private float fallSpeed;

		private Vector3 gravityGoal;

		private Vector3 spikeGravGoal;

		public AnimationCurve xCurve;

		public AnimationCurve yCurve;

		public AnimationCurve zCurve;

		private float perc;

		private float xPos;

		private float yPos;

		private float zPos;

		private Coroutine vatorRoutine;

		private Coroutine moveUpRoutine;

		[Header("Audio")]
		[SerializeField]
		private AudioMixerGroup mixerGroup;

		[SerializeField]
		private AudioClip abortDoorClip;

		[SerializeField]
		private AudioClip doorCloseClip;

		public SpawnableCrateReference sparksCrate;

		[Header("Doors")]
		[SerializeField]
		public bool isClosing;

		[SerializeField]
		private float doorWaitDuration;

		[SerializeField]
		private Powerable_Joint[] powerableJoints;

		[SerializeField]
		private Rigidbody[] doorBodies;

		[SerializeField]
		private GameObject[] outerDoorObjs;

		[SerializeField]
		private Collider doorTrigCol;

		[SerializeField]
		private GameObject[] vatorColliders;

		public Coroutine doorRoutine;

		[SerializeField]
		private GameObject shaftColliderObj;

		public GameObject doorSeel;

		[Header("Shafts")]
		public TutorialShaft[] tutShafts;

		[SerializeField]
		private GameObject ogShaftObj;

		[SerializeField]
		private GameObject otherShaftObj;

		[SerializeField]
		private ConfigurableJoint vatorJoint;

		private Vector3 startGrav;

		private Player_Health pHealth;

		[SerializeField]
		private ElevatorDoorTrigger doorTrig;

		[SerializeField]
		private Rigidbody elevatorBody;

		[SerializeField]
		private ParticleSystem rightSparkler;

		[SerializeField]
		private ParticleSystem leftSparkler;

		private int hubSpawnLocation;

		[ContextMenu("StartElevator")]
		public void StartElevator()
		{
		}

		private IEnumerator CoDoorRoutine()
		{
			return null;
		}

		public void SealDoors()
		{
		}

		public void StartMoveUpward()
		{
		}

		public void SlowUpwardMovement()
		{
		}

		private IEnumerator CoInitialBreakRoutine()
		{
			return null;
		}

		public void ReleaseJointRot()
		{
		}

		private IEnumerator CoSwing()
		{
			return null;
		}

		public void SwingImpact()
		{
		}

		public void LimitJointRot()
		{
		}

		public void StartMoveDownward()
		{
		}

		private IEnumerator CoFallRoutine()
		{
			return null;
		}

		private IEnumerator CoFallingZeroG()
		{
			return null;
		}

		public void StartImpact()
		{
		}

		private IEnumerator CoComplete()
		{
			return null;
		}

		[ContextMenu("OpenDoors")]
		public void OpenDoors()
		{
		}

		[ContextMenu("CloseDoors")]
		public void CloseDoors()
		{
		}

		public void StopDoorRoutine()
		{
		}

		private void OnDestroy()
		{
		}

		public TutorialElevator()
			: base()
		{
		}
	}
}
