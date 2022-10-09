using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

namespace SLZ.Marrow.Input
{
	public class ViveTrackerActionMap : ActionMap, InputActions.ITrackersActions
	{
		private HashSet<XRTracker> _trackerHash;

		public XRTracker LeftFoot { get; private set; }

		public XRTracker RightFoot { get; private set; }

		public XRTracker LeftShoulder { get; private set; }

		public XRTracker RightShoulder { get; private set; }

		public XRTracker LeftElbow { get; private set; }

		public XRTracker RightElbow { get; private set; }

		public XRTracker LeftKnee { get; private set; }

		public XRTracker RightKnee { get; private set; }

		public XRTracker Waist { get; private set; }

		public XRTracker Chest { get; private set; }

		public List<XRTracker> Collection { get; private set; }

		public void Refresh()
		{
		}

		public void OnLeftFoot(InputAction.CallbackContext context)
		{
		}

		public void OnLeftFootTrackingState(InputAction.CallbackContext context)
		{
		}

		public void OnRightFoot(InputAction.CallbackContext context)
		{
		}

		public void OnRightFootTrackingState(InputAction.CallbackContext context)
		{
		}

		public void OnLeftShoulder(InputAction.CallbackContext context)
		{
		}

		public void OnLeftShoulderTrackingState(InputAction.CallbackContext context)
		{
		}

		public void OnRightShoulder(InputAction.CallbackContext context)
		{
		}

		public void OnRightShoulderTrackingState(InputAction.CallbackContext context)
		{
		}

		public void OnLeftElbow(InputAction.CallbackContext context)
		{
		}

		public void OnLeftElbowTrackingState(InputAction.CallbackContext context)
		{
		}

		public void OnRightElbow(InputAction.CallbackContext context)
		{
		}

		public void OnRightElbowTrackingState(InputAction.CallbackContext context)
		{
		}

		public void OnLeftKnee(InputAction.CallbackContext context)
		{
		}

		public void OnLeftKneeTrackingState(InputAction.CallbackContext context)
		{
		}

		public void OnRightKnee(InputAction.CallbackContext context)
		{
		}

		public void OnRightKneeTrackingState(InputAction.CallbackContext context)
		{
		}

		public void OnWaist(InputAction.CallbackContext context)
		{
		}

		public void OnWaistTrackingState(InputAction.CallbackContext context)
		{
		}

		public void OnChest(InputAction.CallbackContext context)
		{
		}

		public void OnChestTrackingState(InputAction.CallbackContext context)
		{
		}

		public ViveTrackerActionMap()
			: base()
		{
		}
	}
}
