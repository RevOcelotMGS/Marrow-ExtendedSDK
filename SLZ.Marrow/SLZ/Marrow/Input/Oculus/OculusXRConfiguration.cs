using UnityEngine;

namespace SLZ.Marrow.Input.Oculus
{
	[CreateAssetMenu(fileName = "OculusXRConfiguration", menuName = "Marrow/Config/OculusXRConfiguration")]
	public class OculusXRConfiguration : ScriptableObject
	{
		public enum TrackingOrigin
		{
			EyeLevel = 0,
			FloorLevel = 0,
			Stage = 0
		}

		public enum DisplayFrequencies
		{
			F72 = 72,
			F80 = 80,
			F90 = 90,
			F120 = 120
		}

		[Tooltip("Defines the current tracking origin type.")]
		[Header("Tracking")]
		public TrackingOrigin trackingOriginType;

		[Tooltip("If true, the distance between the user's eyes will affect the position of each OVRCameraRig's cameras.")]
		public bool useIPDInPositionTracking;

		[Tooltip("If true, each scene load will cause the head pose to reset. This function only works on Rift.")]
		public bool resetTrackerOnLoad;

		[Tooltip("If true, the Reset View in the universal menu will cause the pose to be reset in PC VR. This should generally be enabled for applications with a stationary position in the virtual world and will allow the View Reset command to place the person back to a predefined location (such as a cockpit seat). Set this to false if you have a locomotion system because resetting the view would effectively teleport the player to potentially invalid locations.")]
		public bool allowRecenter;

		[Tooltip("Late latching is a feature that can reduce rendered head/controller latency by a substantial amount. Before enabling, be sure to go over the documentation to ensure that the feature is used correctly. This feature must also be enabled through the Oculus XR Plugin settings.")]
		public bool lateLatching;

		[Header("Display")]
		[Tooltip("The target display frequency to set")]
		public DisplayFrequencies targetDisplayFrequency;

		public OculusXRConfiguration()
			: base()
		{
		}
	}
}
