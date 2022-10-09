using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
	[Serializable]
	public class MouseLook_custom
	{
		public float XSensitivity;

		public float YSensitivity;

		public bool clampVerticalRotation;

		public float MinimumX;

		public float MaximumX;

		public bool smooth;

		public float smoothTime;

		private Quaternion m_CharacterTargetRot;

		private Quaternion m_CameraTargetRot;

		public void Init(Transform character, Transform camera)
		{
		}

		public void LookRotation(Transform character, Transform camera)
		{
		}

		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		public MouseLook_custom()
			: base()
		{
		}
	}
}
