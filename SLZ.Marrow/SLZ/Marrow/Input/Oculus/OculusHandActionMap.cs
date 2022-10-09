namespace SLZ.Marrow.Input.Oculus
{
	public class OculusHandActionMap : XRHand
	{
		private readonly bool _isLeft;

		private readonly OVRPlugin.Hand _hand;

		private OVRPlugin.HandState _handState;

		private bool _hasSkeleton;

		private OVRPlugin.Skeleton2 _skeleton;

		public OculusHandActionMap(bool isLeft)
			: base()
		{
		}

		public override void OnPreNewInputUpdate()
		{
		}

		public override void OnPostNewInputUpdate()
		{
		}

		public override void Refresh()
		{
		}
	}
}
