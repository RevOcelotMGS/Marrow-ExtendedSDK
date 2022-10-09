using System;
using UnityEngine;

namespace SplineMesh
{
	[Serializable]
	public struct CurveSample
	{
		public readonly Vector3 location;

		public readonly Vector3 tangent;

		public readonly Vector3 up;

		public readonly Vector2 scale;

		public readonly float roll;

		public readonly float distanceInCurve;

		public readonly float timeInCurve;

		public readonly CubicBezierCurve curve;

		private Quaternion rotation;

		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		public CurveSample(Vector3 location, Vector3 tangent, Vector3 up, Vector2 scale, float roll, float distanceInCurve, float timeInCurve, CubicBezierCurve curve)
		{
			this.rotation = default(Quaternion);
			this.curve = default(CubicBezierCurve);
			this.timeInCurve = default(float);
			this.distanceInCurve = default(float);
			this.roll = default(float);
			this.scale = default(Vector2);
			this.up = default(Vector3);
			this.tangent = default(Vector3);
			this.location = default(Vector3);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public static bool operator ==(CurveSample cs1, CurveSample cs2)
		{
			return default(bool);
		}

		public static bool operator !=(CurveSample cs1, CurveSample cs2)
		{
			return default(bool);
		}

		public static CurveSample Lerp(CurveSample a, CurveSample b, float t)
		{
			return default(CurveSample);
		}

		public MeshVertex GetBent(MeshVertex vert)
		{
			return null;
		}
	}
}
