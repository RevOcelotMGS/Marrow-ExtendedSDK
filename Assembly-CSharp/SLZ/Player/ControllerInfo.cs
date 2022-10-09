using System;
using UnityEngine;

namespace SLZ.Player
{
	[Serializable]
	public class ControllerInfo
	{
		public enum Type
		{
			Undefined = -1,
			OculusTouch = 0,
			Index = 1,
			ViveWands = 2,
			Holographic = 3
		}

		public Type type;

		public Vector3 palmPosition;

		public Quaternion palmRotation;

		public Quaternion wristRotation;

		public Vector3 wristDirection;

		public ControllerInfo(Type t)
			: base()
		{
		}
	}
}
