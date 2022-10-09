namespace SLZ.Rig
{
	public class MirrorControllerRig : ControllerRig
	{
		public RigManager mirrorTarget;

		public bool mirrorTrackedInput;

		public override void OnAwake()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
		{
		}

		public MirrorControllerRig()
			: base()
		{
		}
	}
}
