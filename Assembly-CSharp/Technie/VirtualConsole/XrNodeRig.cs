using UnityEngine;
using UnityEngine.XR;

namespace Technie.VirtualConsole
{
	public class XrNodeRig : MonoBehaviour
	{
		public Transform headTransform;

		public Transform leftHandTransform;

		public Transform rightHandTransform;

		private CameraDetectionMode cameraDetectionMode;

		private Camera explicitVrCameraReference;

		private string explicitVrCameraName;

		private Camera vrCamera;

		private bool hasShowExplicitCameraWarning;

		public void SetCameraDetection(CameraDetectionMode mode, Camera explicitRef, string explicitName)
		{
		}

		private void Update()
		{
		}

		private void Sync(XRNodeState node, Transform destTransform)
		{
		}

		private bool IsVrCameraValid()
		{
			return default(bool);
		}

		private void FindVrCamera()
		{
		}

		public XrNodeRig()
			: base()
		{
		}
	}
}
