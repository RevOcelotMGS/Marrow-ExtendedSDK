using Assets.Marrow_ExtendedSDK.StubClasses;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehicleAI
{
	public class BaseVehicle : MonoBehaviour
	{
		[Tooltip("Scriptable object used to pre-initialize vehicle parameters")]
		public VehicleConfig config_file;

		[Tooltip("Mono Class that has all auxiliary functions/methods for a base vehicle to operate")]
		public BaseVehicleUtils vehicleUtils;

		[Tooltip("Component that collects and sends data to AI brain")]
		public BaseVehicleSensors vehicleSensor;

		[Tooltip("Object reference for task based ai to operate correctly")]
		public GameObject currentObjective;

		[Tooltip("Reference value for normalizing mass observations of rigidbodies")]
		public float max_weight;

		[HideInInspector]
		[SerializeField]
		public Rigidbody _rb;

		[Tooltip("Master variable for all other scripts to know if vehicle is currently colliding")]
		public int is_colliding;

		[Tooltip("Control variable for blocking locomotion on vehicle spawn")]
		public bool startBlockedLoco;

		[Tooltip("Control variable for blocking locomotion on vehicle spawn")]
		public bool blockLoco;

		public StatsRecorder statsRecorder;

		public bool RestSwtich
		{
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void CarActions(float motorInput, float steerInput, float handBrake, bool reverseEyes = false)
		{
		}

		public void Init()
		{
		}

		private void OnCollisionEnter(Collision other)
		{
		}

		private void OnCollisionStay(Collision other)
		{
		}

		private void OnCollisionExit(Collision other)
		{
		}

		public BaseVehicle()
			: base()
		{
		}

		public event Action<string> CollisionEnterEvent;

		public event Action<string> CollisionExitEvent;

		public event Action<string> CollisionStayEvent;

		public event Action ForceRestAction;
	}
}
