using Assets.Marrow_ExtendedSDK.StubClasses;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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

		public void OnLeftFoot(CallbackContext context)
		{
		}

		public void OnLeftFootTrackingState(CallbackContext context)
		{
		}

		public void OnRightFoot(CallbackContext context)
		{
		}

		public void OnRightFootTrackingState(CallbackContext context)
		{
		}

		public void OnLeftShoulder(CallbackContext context)
		{
		}

		public void OnLeftShoulderTrackingState(CallbackContext context)
		{
		}

		public void OnRightShoulder(CallbackContext context)
		{
		}

		public void OnRightShoulderTrackingState(CallbackContext context)
		{
		}

		public void OnLeftElbow(CallbackContext context)
		{
		}

		public void OnLeftElbowTrackingState(CallbackContext context)
		{
		}

		public void OnRightElbow(CallbackContext context)
		{
		}

		public void OnRightElbowTrackingState(CallbackContext context)
		{
		}

		public void OnLeftKnee(CallbackContext context)
		{
		}

		public void OnLeftKneeTrackingState(CallbackContext context)
		{
		}

		public void OnRightKnee(CallbackContext context)
		{
		}

		public void OnRightKneeTrackingState(CallbackContext context)
		{
		}

		public void OnWaist(CallbackContext context)
		{
		}

		public void OnWaistTrackingState(CallbackContext context)
		{
		}

		public void OnChest(CallbackContext context)
		{
		}

		public void OnChestTrackingState(CallbackContext context)
		{
		}

		public ViveTrackerActionMap()
			: base()
		{
		}
	}
}
