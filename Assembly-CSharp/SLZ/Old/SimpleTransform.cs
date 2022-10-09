using System;
using UnityEngine;

namespace SLZ.Old
{
	[Serializable]
	public struct SimpleTransform
	{
		public Vector3 position;

		public Quaternion rotation;

		public Vector3 forward
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 up
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 right
		{
			get
			{
				return default(Vector3);
			}
		}

		public SimpleTransform inverse
		{
			get
			{
				return default(SimpleTransform);
			}
		}

		public static SimpleTransform Create(Vector3 p, Quaternion r)
		{
			return default(SimpleTransform);
		}

		public static SimpleTransform Create(SimpleTransform st)
		{
			return default(SimpleTransform);
		}

		public static SimpleTransform Inverse(Transform t)
		{
			return default(SimpleTransform);
		}

		public static SimpleTransform Create(Transform t)
		{
			return default(SimpleTransform);
		}

		public static SimpleTransform Inverse(SimpleTransform st)
		{
			return default(SimpleTransform);
		}

		public static SimpleTransform Inverse(Vector3 p, Quaternion r)
		{
			return default(SimpleTransform);
		}

		public static SimpleTransform Transform(Transform transformA, SimpleTransform transformB)
		{
			return default(SimpleTransform);
		}

		public static SimpleTransform Transform(Transform transformA, Transform transformB)
		{
			return default(SimpleTransform);
		}

		public static SimpleTransform InverseTransform(Transform transformA, SimpleTransform transformB)
		{
			return default(SimpleTransform);
		}

		public static SimpleTransform InverseTransform(Transform transformA, Transform transformB)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform(Vector3 p, Quaternion r)
		{
			this.rotation = default(Quaternion);
			this.position = default(Vector3);
		}

		public SimpleTransform(Transform t)
		{
			this.rotation = default(Quaternion);
			this.position = default(Vector3);
		}

		public SimpleTransform(SimpleTransform st)
		{
			this.rotation = default(Quaternion);
			this.position = default(Vector3);
		}

		public void Copy(SimpleTransform st)
		{
		}

		public void Copy(Transform t)
		{
		}

		public void CopyLocal(Transform t)
		{
		}

		public void CopyToLocal(Transform t)
		{
		}

		public void CopyTo(Transform t)
		{
		}

		public SimpleTransform InverseTransform(Transform t)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform InverseTransform(SimpleTransform st)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform InverseTransform(Vector3 p, Quaternion r)
		{
			return default(SimpleTransform);
		}

		public Vector3 InverseTransformPoint(Vector3 p)
		{
			return default(Vector3);
		}

		public Vector3 InverseTransformDirection(Vector3 d)
		{
			return default(Vector3);
		}

		public Quaternion InverseTransformRotation(Quaternion r)
		{
			return default(Quaternion);
		}

		public SimpleTransform RotateFrom(Quaternion r)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform Transform(Transform t)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform Transform(SimpleTransform st)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform Transform(Vector3 p, Quaternion r)
		{
			return default(SimpleTransform);
		}

		public Vector3 TransformPoint(Vector3 p)
		{
			return default(Vector3);
		}

		public Vector3 TransformDirection(Vector3 d)
		{
			return default(Vector3);
		}

		public Quaternion TransformRotation(Quaternion r)
		{
			return default(Quaternion);
		}

		public Vector3 DirectionTo(Vector3 p)
		{
			return default(Vector3);
		}

		public Vector3 DirectionTo(SimpleTransform st)
		{
			return default(Vector3);
		}

		public Vector3 DirectionTo(Transform t)
		{
			return default(Vector3);
		}

		public Vector3 DirectionFrom(Vector3 p)
		{
			return default(Vector3);
		}

		public Vector3 DirectionFrom(SimpleTransform st)
		{
			return default(Vector3);
		}

		public Vector3 DirectionFrom(Transform t)
		{
			return default(Vector3);
		}

		public static SimpleTransform Lerp(SimpleTransform fromST, SimpleTransform toST, float perc)
		{
			return default(SimpleTransform);
		}
	}
}
