using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	public class LeftControllerActionMap : ControllerActionMap, InputActions.IControllerLActions
	{
		public override InputDeviceCharacteristics Characteristics
		{
			get
			{
				return default(InputDeviceCharacteristics);
			}
		}

		public LeftControllerActionMap()
			: base()
		{
		}
	}
}
