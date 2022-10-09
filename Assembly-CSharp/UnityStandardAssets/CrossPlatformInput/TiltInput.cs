using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	public class TiltInput : MonoBehaviour
	{
		public enum AxisOptions
		{
			ForwardAxis = 0,
			SidewaysAxis = 1
		}

		[Serializable]
		public class AxisMapping
		{
			public enum MappingType
			{
				NamedAxis = 0,
				MousePositionX = 1,
				MousePositionY = 2,
				MousePositionZ = 3
			}

			public MappingType type;

			public string axisName;

			public AxisMapping()
				: base()
			{
			}
		}

		public AxisMapping mapping;

		public AxisOptions tiltAroundAxis;

		public float fullTiltAngle;

		public float centreAngleOffset;

		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		public TiltInput()
			: base()
		{
		}
	}
}
