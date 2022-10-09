using UnityEngine;

namespace Technie.VirtualConsole
{
	public class VirtualConsole : MonoBehaviour
	{
		public bool onlyInDebugBuilds;

		[Header("Stylus Locations")]
		public StylusPosition leftStylusPosition;

		public StylusPosition rightStylusPosition;

		[Header("Custom Locations")]
		public Vector3 customLeftStylusPosition;

		public Vector3 customRightStylusPosition;

		[Header("Camera Detection")]
		public CameraDetectionMode cameraDetectionMode;

		public Camera explicitVrCameraReference;

		public string explicitVrCameraName;

		private static VirtualConsole instance;

		private HandAbstraction handAbstraction;

		private XrNodeRig xrNodeRig;

		public static VirtualConsole Instance
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public GameObject GetHand(HandType hand)
		{
			return null;
		}

		public bool HasTarget(HandType targetHand)
		{
			return default(bool);
		}

		public void TriggerInput(HandType targetHand)
		{
		}

		public VirtualConsole()
			: base()
		{
		}
	}
}
