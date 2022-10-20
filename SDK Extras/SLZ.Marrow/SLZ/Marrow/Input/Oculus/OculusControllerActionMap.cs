namespace SLZ.Marrow.Input.Oculus
{
	public sealed class OculusControllerActionMap : XRController
	{

		private readonly bool _isLeft;

		private float _simIndexTouch;

		private float _hapStart;

		private float _hapEnd;

		private float _hapFrequency;

		private float _hapAmplitude;

		private bool _isHapticPlaying;

		public override XRControllerType Type
		{
			get
			{
				return default(XRControllerType);
			}
		}

		public OculusControllerActionMap(bool isLeft)
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

		public override void SetHaptic(float secondsFromNow, float durationSeconds, float frequency, float amplitude)
		{
		}
	}
}
