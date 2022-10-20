using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public struct TemporalTransform
	{
		public readonly SimpleTransform transform;

		public readonly Vector3 velocity;

		public readonly Vector3 angularVelocity;

		public readonly double time;

		public TemporalTransform(Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity, double time)
		{
			this.time = default(double);
			this.angularVelocity = default(Vector3);
			this.velocity = default(Vector3);
			this.transform = default(SimpleTransform);
		}

		public TemporalTransform(SimpleTransform transform, Vector3 velocity, Vector3 angularVelocity, [In] double time)
		{
			this.time = default(double);
			this.angularVelocity = default(Vector3);
			this.velocity = default(Vector3);
			this.transform = default(SimpleTransform);
		}
	}
}
