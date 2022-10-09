using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class Rig : MonoBehaviour
	{
		public RigManager manager;

		[Header("Rig")]
		public Transform m_head;

		public Transform m_jaw;

		public Transform m_neck;

		public Transform m_chest;

		public Transform m_spine;

		public Transform m_pelvis;

		public Transform m_shoulderLf;

		public Transform m_elbowLf;

		public Transform m_handLf;

		public Transform m_shoulderRt;

		public Transform m_elbowRt;

		public Transform m_handRt;

		public Transform m_hipLf;

		public Transform m_kneeLf;

		public Transform m_footLf;

		public Transform m_hipRt;

		public Transform m_kneeRt;

		public Transform m_footRt;

		public Transform centerOfPressure;

		public Vector4 eyeGaze;

		[HideInInspector]
		public int rigIndex;

		public virtual void Reset()
		{
		}

		public virtual void OnAwake()
		{
		}

		public virtual void OnRigEnable()
		{
		}

		public virtual void OnStart()
		{
		}

		public virtual void OnEarlyUpdate()
		{
		}

		public virtual void OnFirstFixedUpdate()
		{
		}

		public virtual void OnFixedUpdate(float deltaTime)
		{
		}

		public virtual void OnAfterFixedUpdate()
		{
		}

		public virtual void OnUpdate()
		{
		}

		public virtual void OnLateUpdate()
		{
		}

		public virtual void OnRigDisable()
		{
		}

		public virtual void Teleport(Vector3 displace, bool zeroVelocity = false)
		{
		}

		public virtual void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public Rig GetNextRig()
		{
			return null;
		}

		public Rig GetPreviousRig()
		{
			return null;
		}

		public Rig GetFirstRig()
		{
			return null;
		}

		public Rig GetLastRig()
		{
			return null;
		}

		public Rig GetRig(int i)
		{
			return null;
		}

		protected Vector3 Gimbal(Vector3 target, Vector3 lastTarget, Vector3 gimbaledVelocity, Vector3 gimbalAccel, Vector3 gimbleOffset, float lerpRate, float deltaTime, float maxOffset = float.MaxValue, float smoothTime = 0.1f)
		{
			return default(Vector3);
		}

		protected float Gimbal(float target, float lastTarget, float gimbaledVelocity, float gimbalAccel, float gimbleOffset, float lerpRate, float deltaTime, float maxOffset = float.MaxValue, float smoothTime = 0.1f)
		{
			return default(float);
		}

		public Rig()
			: base()
		{
		}
	}
}
