using Assets.Marrow_ExtendedSDK.StubClasses;
using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.XR.OpenXR.Features.Interactions
{
	public class HTCViveTrackerProfile : OpenXRInteractionFeature
	{
		public static class TrackerUserPaths
		{
			public const string leftFoot = "/user/vive_tracker_htcx/role/left_foot";

			public const string rightFoot = "/user/vive_tracker_htcx/role/right_foot";

			public const string leftShoulder = "/user/vive_tracker_htcx/role/left_shoulder";

			public const string rightShoulder = "/user/vive_tracker_htcx/role/right_shoulder";

			public const string leftElbow = "/user/vive_tracker_htcx/role/left_elbow";

			public const string rightElbow = "/user/vive_tracker_htcx/role/right_elbow";

			public const string leftKnee = "/user/vive_tracker_htcx/role/left_knee";

			public const string rightKnee = "/user/vive_tracker_htcx/role/right_knee";

			public const string waist = "/user/vive_tracker_htcx/role/waist";

			public const string chest = "/user/vive_tracker_htcx/role/chest";

			public const string camera = "/user/vive_tracker_htcx/role/camera";

			public const string keyboard = "/user/vive_tracker_htcx/role/keyboard";
		}

		public static class TrackerComponentPaths
		{
			public const string grip = "/input/grip/pose";
		}

		[InputControlLayout(isGenericTypeOfDevice = true, displayName = "XR Tracker")]
		public class XRTracker : TrackedDevice
		{
			public XRTracker()
				: base()
			{
			}
		}

		[InputControlLayout(displayName = "HTC Vive Tracker (OpenXR)", commonUsages = new string[]
		{
			"Left Foot", "Right Foot", "Left Shoulder", "Right Shoulder", "Left Elbow", "Right Elbow", "Left Knee", "Right Knee", "Waist", "Chest",
			"Camera", "Keyboard"
		})]
		[Preserve]
		public class XRViveTracker : XRTracker
		{
			[InputControl(offset = 0u, aliases = new string[] { "device", "gripPose" }, usage = "Device", noisy = true)]
			[Preserve]
			public PoseControl devicePose { get; private set; }

			[InputControl(offset = 8u, alias = "gripPosition", noisy = true)]
			[Preserve]
			public new Vector3Control devicePosition { get; private set; }

			[InputControl(offset = 20u, alias = "gripOrientation", noisy = true)]
			[Preserve]
			public new QuaternionControl deviceRotation { get; private set; }

			[InputControl(offset = 60u)]
			[Preserve]
			public new ButtonControl isTracked { get; private set; }

			[InputControl(offset = 64u)]
			[Preserve]
			public new IntegerControl trackingState { get; private set; }

			public XRViveTracker()
				: base()
			{
			}
		}

		[Flags]
		public enum InputDeviceTrackerCharacteristics : uint
		{
			TrackerLeftFoot = 0x1000u,
			TrackerRightFoot = 0x2000u,
			TrackerLeftShoulder = 0x4000u,
			TrackerRightShoulder = 0x8000u,
			TrackerLeftElbow = 0x10000u,
			TrackerRightElbow = 0x20000u,
			TrackerLeftKnee = 0x40000u,
			TrackerRightKnee = 0x80000u,
			TrackerWaist = 0x100000u,
			TrackerChest = 0x200000u,
			TrackerCamera = 0x400000u,
			TrackerKeyboard = 0x800000u
		}

		public const string featureId = "com.slz.openxr.feature.input.htcvivetracker";

		public const string profile = "/interaction_profiles/htc/vive_tracker_htcx";

		public const string extensionName = "XR_HTCX_vive_tracker_interaction";

		private const string kDeviceLocalizedName = "HTC Vive Tracker OpenXR";

		public HTCViveTrackerProfile()
			: base()
		{
		}
	}
}
