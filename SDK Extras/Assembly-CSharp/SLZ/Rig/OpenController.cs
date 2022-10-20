using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ.Rig
{
	public class OpenController : BaseController
	{
		private const float grabThreshold = 0.99f;

		private const float releaseThreshold = 0.5f;

		private bool _runUpdates;

		private Vector3 _localTrackPos;

		private Quaternion _localTrackRot;

		private void DrawSkeletonHand(Vector3[] positions, Quaternion[] rotations)
		{
		}

		public override GesturePose GetGesturePose([Out] float poseIntensity, bool forceUpdate = false)
		{
			return default(GesturePose);
		}

		public override void OnUpdate()
		{
		}

		public override void OnVrFixedUpdate(Vector3 headPos)
		{
		}

		private void CacheInputs()
		{
		}

		private void ProcessFingers()
		{
		}

		private void SolveGrip()
		{
		}

		private void CheckMenuTap()
		{
		}

		public override void HapticAction(float secondsFromNow, float durationSeconds, float frequency, float amplitude)
		{
		}

		public override bool GetPrimaryInteractionButtonDown()
		{
			return default(bool);
		}

		public override bool GetPrimaryInteractionButtonUp()
		{
			return default(bool);
		}

		public override bool GetPrimaryInteractionButton()
		{
			return default(bool);
		}

		public override float GetPrimaryInteractionButtonAxis()
		{
			return default(float);
		}

		public override bool GetSecondaryInteractionButtonDown()
		{
			return default(bool);
		}

		public override float GetSecondaryInteractionButtonAxis()
		{
			return default(float);
		}

		public override float GetGripVelocity()
		{
			return default(float);
		}

		public override bool GetSecondaryInteractionButtonUp()
		{
			return default(bool);
		}

		public override bool GetSecondaryInteractionButton()
		{
			return default(bool);
		}

		public override bool GetAButtonDown()
		{
			return default(bool);
		}

		public override bool GetAButtonUp()
		{
			return default(bool);
		}

		public override bool GetAButton()
		{
			return default(bool);
		}

		public override bool GetBButtonDown()
		{
			return default(bool);
		}

		public override bool GetBButtonUp()
		{
			return default(bool);
		}

		public override bool GetBButton()
		{
			return default(bool);
		}

		public override Vector2 GetThumbStickAxis()
		{
			return default(Vector2);
		}

		public override bool GetThumbStickDown()
		{
			return default(bool);
		}

		public override bool GetThumbStickUp()
		{
			return default(bool);
		}

		public override bool GetThumbStick()
		{
			return default(bool);
		}

		public override Vector2 GetTouchPadAxis()
		{
			return default(Vector2);
		}

		public override bool GetTouchPadDown()
		{
			return default(bool);
		}

		public override bool GetTouchPadUp()
		{
			return default(bool);
		}

		public override bool GetTouchPad()
		{
			return default(bool);
		}

		public override float GetGripForce()
		{
			return default(float);
		}

		public override float GetIndexCurlAxis()
		{
			return default(float);
		}

		public override float GetMiddleCurlAxis()
		{
			return default(float);
		}

		public override float GetRingCurlAxis()
		{
			return default(float);
		}

		public override float GetPinkyCurlAxis()
		{
			return default(float);
		}

		public override float GetThumbCurlAxis()
		{
			return default(float);
		}

		public override bool HasBeenGrabbed()
		{
			return default(bool);
		}

		public override void ClearHasBeenGrabbed()
		{
		}

		public override bool IsGrabbed()
		{
			return default(bool);
		}

		public override bool IsReleased()
		{
			return default(bool);
		}

		public override bool GetGrabbedState()
		{
			return default(bool);
		}

		public override bool GetReleasedState()
		{
			return default(bool);
		}

		public override bool GetMenuButtonDown()
		{
			return default(bool);
		}

		public override bool GetMenuButtonUp()
		{
			return default(bool);
		}

		public override bool GetMenuButton()
		{
			return default(bool);
		}

		public override bool GetSecondaryMenuButtonDown()
		{
			return default(bool);
		}

		public override bool GetSecondaryMenuButtonUp()
		{
			return default(bool);
		}

		public override bool GetSecondaryMenuButton()
		{
			return default(bool);
		}

		public override bool GetMenuTap()
		{
			return default(bool);
		}

		public override bool GetAppMenuDown()
		{
			return default(bool);
		}

		public override bool GetAppMenuUp()
		{
			return default(bool);
		}

		public override bool GetAppMenu()
		{
			return default(bool);
		}

		public override bool GetThumbStickTouch()
		{
			return default(bool);
		}

		public override bool GetThumbTouch()
		{
			return default(bool);
		}

		public override Vector3 GetRelativeVelocityInWorld()
		{
			return default(Vector3);
		}

		public OpenController()
			: base()
		{
		}
	}
}
