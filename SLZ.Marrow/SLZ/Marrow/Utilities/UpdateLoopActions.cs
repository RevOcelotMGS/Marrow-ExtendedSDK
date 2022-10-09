namespace SLZ.Marrow.Utilities
{
	public enum UpdateLoopActions
	{
		StartFrame = 0,
		PreNewInputUpdate = 1,
		PostNewInputUpdate = 2,
		EarlyUpdate = 3,
		PreFixedUpdate = 4,
		PostFixedUpdate = 5,
		Update = 6,
		EndFrame = 7
	}
}
