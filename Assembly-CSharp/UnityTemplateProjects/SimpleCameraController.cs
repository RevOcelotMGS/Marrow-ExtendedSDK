using UnityEngine;

namespace UnityTemplateProjects
{
	public class SimpleCameraController : MonoBehaviour
	{
		private class CameraState
		{
			public float yaw;

			public float pitch;

			public float roll;

			public float x;

			public float y;

			public float z;

			public void SetFromTransform(Transform t)
			{
			}

			public void Translate(Vector3 translation)
			{
			}

			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			public void UpdateTransform(Transform t)
			{
			}

			public CameraState()
				: base()
			{
			}
		}

		private CameraState m_TargetCameraState;

		private CameraState m_InterpolatingCameraState;

		[Header("Movement Settings")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		public float boost;

		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float positionLerpTime;

		[Header("Rotation Settings")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		public AnimationCurve mouseSensitivityCurve;

		[Range(0.001f, 1f)]
		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		public float rotationLerpTime;

		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		private void OnEnable()
		{
		}

		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		private void Update()
		{
		}

		public SimpleCameraController()
			: base()
		{
		}
	}
}
