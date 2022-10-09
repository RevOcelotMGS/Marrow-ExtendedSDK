using UnityEngine;

namespace RootMotion
{
	public class CameraControllerFPS : MonoBehaviour
	{
		public float rotationSensitivity;

		public float yMinLimit;

		public float yMaxLimit;

		private float x;

		private float y;

		private void Awake()
		{
		}

		public void LateUpdate()
		{
		}

		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		public CameraControllerFPS()
			: base()
		{
		}
	}
}
