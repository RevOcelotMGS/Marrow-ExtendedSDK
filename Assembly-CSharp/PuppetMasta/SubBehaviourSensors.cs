using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.AI;
using SLZ.Rig;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourSensors : SubBehaviourBase
	{
		public struct TargetInfo
		{
			public float threat;

			public float timeAdded;

			public ulong id;

			public TargetInfo(float threat, float timeAdded, ulong id)
			{
				this.id = default(ulong);
				this.timeAdded = default(float);
				this.threat = default(float);
			}
		}

		[Header("Vision")]
		public LayerMask blockVisionRaycast;

		public float visionFov;

		[Header("Hearing")]
		public float hearingSensitivity;

		[Header("Touch")]
		public MuscleCollisionBroadcasterSensor[] forceSensorsFeet;

		public MuscleCollisionBroadcasterSensor[] forceSensorsHands;

		public MuscleCollisionBroadcasterSensor[] forceSensorsBody;

		public float additionalMass;

		public float footSupported;

		public float handSupported;

		public float bodySupported;

		[Header("Targets")]
		public TriggerRefProxy target;

		public TriggerRefProxy selfTrp;

		private float _totalMass;

		private SphereCollider _visionSphere;

		private Vector3 _hipsForward;

		private Vector3 _hipsUp;

		private List<TriggerRefProxy> _trpList;

		private Dictionary<TriggerRefProxy, TargetInfo> _trpTargets;

		private float _getVelocityDue;

		private Vector3 _storedComVel;

		private float _getCenterOfMassDue;

		private Vector3 _storedCom;

		private float _getFeetCentroidDue;

		private Vector3 _storedSum;

		public Vector3 GroundVelocity { get; private set; }

		public float totalSupported { get; private set; }

		public bool isGrounded { get; private set; }

		public float visionFovCos { get; private set; }

		public float TotalMass
		{
			get
			{
				return default(float);
			}
		}

		public BaseController.GesturePose targetPoseLf { get; private set; }

		public BaseController.GesturePose targetPoseRt { get; private set; }

		public List<TriggerRefProxy> TrpList
		{
			get
			{
				return null;
			}
		}

		public void Initiate(BehaviourBase b)
		{
		}

		public void Respawn()
		{
		}

		public bool AddThreat(TriggerRefProxy trp, float threat)
		{
			return default(bool);
		}

		public bool RemoveTarget(TriggerRefProxy trp)
		{
			return default(bool);
		}

		public void ClearTargets()
		{
		}

		public void CheckTarget()
		{
		}

		public void SetAgro(TriggerRefProxy trp)
		{
		}

		public void SetEngaged(TriggerRefProxy trp)
		{
		}

		private ulong GetId(TriggerRefProxy trp)
		{
			return default(ulong);
		}

		private float InitialThreat(TriggerRefProxy trp)
		{
			return default(float);
		}

		public void UpdateGrounded(float deltaT)
		{
		}

		public void ReadPoses()
		{
		}

		private BaseController.GesturePose ProcessGestures(bool rightHand = false)
		{
			return default(BaseController.GesturePose);
		}

		public void SetVisionSphere(float radius, bool enabled = true, bool noOffset = false)
		{
		}

		public void SetEnableAnimatorSphere(float radius, bool enabled = true)
		{
		}

		public Vector3 GetVelocity(bool forceUpdate = false)
		{
			return default(Vector3);
		}

		public Vector3 GetCenterOfMass(bool forceUpdate = false)
		{
			return default(Vector3);
		}

		public Vector3 GetFeetCentroid(bool forceUpdate = false)
		{
			return default(Vector3);
		}

		public float GetBalanceTangent()
		{
			return default(float);
		}

		public float GetBalanceTangent([Out] Vector3 worldDirection)
		{
			return default(float);
		}

		public bool IsProne()
		{
			return default(bool);
		}

		public float ProneFloat()
		{
			return default(float);
		}

		public Vector3 HipsUpWorld()
		{
			return default(Vector3);
		}

		public Vector3 HipsForwardWorld()
		{
			return default(Vector3);
		}

		public SubBehaviourSensors()
			: base()
		{
		}
	}
}
