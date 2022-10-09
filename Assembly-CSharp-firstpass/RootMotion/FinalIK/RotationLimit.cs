using System.Runtime.InteropServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public abstract class RotationLimit : MonoBehaviour
	{
		public Vector3 axis;

		[HideInInspector]
		public Quaternion defaultLocalRotation;

		private bool initiated;

		private bool applicationQuit;

		private bool defaultLocalRotationSet;

		public Vector3 secondaryAxis
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 crossAxis
		{
			get
			{
				return default(Vector3);
			}
		}

		public void SetDefaultLocalRotation()
		{
		}

		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, [Out] bool changed)
		{
			return default(Quaternion);
		}

		public bool Apply()
		{
			return default(bool);
		}

		public void Disable()
		{
		}

		protected abstract Quaternion LimitRotation(Quaternion rotation);

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void LogWarning(string message)
		{
		}

		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		public RotationLimit()
			: base()
		{
		}
	}
}
