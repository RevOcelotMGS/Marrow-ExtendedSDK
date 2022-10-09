using System.Runtime.InteropServices;
using UnityEngine;

namespace RealisticEyeMovements
{
	internal struct CritDampTweenQuaternion
	{
		[StructLayout(2)]
		private struct QVUnion
		{
			public Vector4 v;

			public Quaternion q;
		}

		private QVUnion _rotation;

		public Vector4 velocity;

		public float omega;

		private readonly float maxSpeed;

		public Quaternion rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		private static Vector4 q2v(Quaternion q)
		{
			return default(Vector4);
		}

		public CritDampTweenQuaternion(Quaternion rotation, float omega, float maxSpeed)
		{
			this.maxSpeed = default(float);
			this.omega = default(float);
			this.velocity = default(Vector4);
			this._rotation = default(QVUnion);
		}

		public void Step(Quaternion target)
		{
		}

		public static implicit operator Quaternion(CritDampTweenQuaternion m)
		{
			return default(Quaternion);
		}
	}
}
