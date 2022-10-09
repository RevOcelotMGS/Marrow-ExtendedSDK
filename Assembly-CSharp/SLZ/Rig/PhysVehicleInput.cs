using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Vehicle;
using TMPro;
using UnityEngine;
using VehicleAI;

namespace SLZ.Rig
{
	public class PhysVehicleInput : MonoBehaviour
	{
		public bool isFadingInput;

		[SerializeField]
		private float fadeDuration;

		public bool leftControllerGas;

		public float steerVal;

		public float hBrakeVal;

		public BaseVehicleUtils baseVehicleUtils;

		public Seat driverSeat;

		public RigManager rigManager;

		public HingeVirtualController steerWheelVC;

		public InteractableHost steerHost;

		public ConfigurableJoint steerJoint;

		private Quaternion _steerInitialRotation;

		public ConfigurableJoint ejectJoint;

		public Grip ejectGrip;

		public InteractableHost ejectHost;

		public float ejectForce;

		public InteractableHost handBrakeHost;

		public ConfigurableJoint handBrakeJoint;

		private Quaternion _hbInitialRotation;

		private bool hbValid;

		public InferenceAgent agent;

		private float steerDeadZone;

		public float minSpringForce;

		public float maxSpringForce;

		private JointDrive steerAngDrive;

		private Coroutine fadeRoutine;

		public TMP_Text speedText;

		public TMP_Text springText;

		public TMP_Text hBrakeText;

		public TMP_Text sideStiffText;

		public bool invertSteering;

		public bool wasdOverride;

		private int horizontalInput;

		private int verticalInput;

		private bool w;

		private bool a;

		private bool s;

		private bool d;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEjectGripped(Hand hand)
		{
		}

		private IEnumerator CoEject()
		{
			return null;
		}

		protected void Start()
		{
		}

		private void OnDriverSeated()
		{
		}

		private void OnDriverUnseated()
		{
		}

		private IEnumerator CoFadeInput()
		{
			return null;
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		public PhysVehicleInput()
			: base()
		{
		}
	}
}
