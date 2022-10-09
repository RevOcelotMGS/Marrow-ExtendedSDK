using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public static class VRIKCalibrator
	{
		[Serializable]
		public class Settings
		{
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Tooltip("Local axis of the body tracker towards the player's forward direction.")]
			public Vector3 bodyTrackerForward;

			[Tooltip("Local axis of the body tracker towards the up direction.")]
			public Vector3 bodyTrackerUp;

			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Space(10f)]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			public Vector3 headOffset;

			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Range(-180f, 180f)]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			public float footHeadingOffset;

			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			public Settings()
				: base()
			{
			}
		}

		[Serializable]
		public class CalibrationData
		{
			[Serializable]
			public class Target
			{
				public bool used;

				public Vector3 localPosition;

				public Quaternion localRotation;

				public Target(Transform t)
					: base()
				{
				}

				public void SetTo(Transform t)
				{
				}
			}

			public float scale;

			public Target head;

			public Target leftHand;

			public Target rightHand;

			public Target pelvis;

			public Target leftFoot;

			public Target rightFoot;

			public Target leftLegGoal;

			public Target rightLegGoal;

			public Vector3 pelvisTargetRight;

			public float pelvisPositionWeight;

			public float pelvisRotationWeight;

			public CalibrationData()
				: base()
			{
			}
		}

		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, Transform bodyTracker = default(Transform), Transform leftHandTracker = default(Transform), Transform rightHandTracker = default(Transform), Transform leftFootTracker = default(Transform), Transform rightFootTracker = default(Transform))
		{
			return null;
		}

		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, Transform bodyTracker = default(Transform), Transform leftHandTracker = default(Transform), Transform rightHandTracker = default(Transform), Transform leftFootTracker = default(Transform), Transform rightFootTracker = default(Transform))
		{
		}

		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
}
