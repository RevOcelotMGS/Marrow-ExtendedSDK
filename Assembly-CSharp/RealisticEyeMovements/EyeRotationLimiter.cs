using System;
using UnityEngine;

namespace RealisticEyeMovements
{
	[Serializable]
	public class EyeRotationLimiter
	{
		[Serializable]
		public class EyeRotationLimiterForExport
		{
			public string transformPath;

			public SerializableQuaternion defaultQ;

			public SerializableQuaternion lookUpQ;

			public SerializableQuaternion lookDownQ;

			public bool isLookUpSet;

			public bool isLookDownSet;

			public EyeRotationLimiterForExport()
				: base()
			{
			}
		}

		[SerializeField]
		private Transform transform;

		[SerializeField]
		private Quaternion defaultQ;

		[SerializeField]
		private Quaternion lookUpQ;

		[SerializeField]
		private Quaternion lookDownQ;

		public float maxUpAngle;

		public float maxDownAngle;

		[SerializeField]
		private bool isLookUpSet;

		[SerializeField]
		private bool isLookDownSet;

		public bool CanImport(EyeRotationLimiterForExport import, Transform startXform)
		{
			return default(bool);
		}

		public float ClampAngle(float angle)
		{
			return default(float);
		}

		public EyeRotationLimiterForExport GetExport(Transform startXform)
		{
			return null;
		}

		public float GetEyeUp01(float angle)
		{
			return default(float);
		}

		public float GetEyeDown01(float angle)
		{
			return default(float);
		}

		public void Import(EyeRotationLimiterForExport import, Transform startXform)
		{
		}

		public void RestoreDefault()
		{
		}

		public void RestoreLookDown()
		{
		}

		public void RestoreLookUp()
		{
		}

		public void SaveDefault(Transform t)
		{
		}

		public void SaveLookDown()
		{
		}

		public void SaveLookUp()
		{
		}

		private void UpdateMaxAngles()
		{
		}

		public EyeRotationLimiter()
			: base()
		{
		}
	}
}
