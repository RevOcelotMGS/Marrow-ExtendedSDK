namespace SLZ.Marrow.Input.Oculus
{
	public class OculusHandActionMap : XRHand
	{
		private readonly bool _isLeft;

		private bool _hasSkeleton;

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
