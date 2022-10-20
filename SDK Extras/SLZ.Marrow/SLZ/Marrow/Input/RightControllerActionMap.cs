using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	public class RightControllerActionMap : ControllerActionMap, InputActions.IControllerRActions
	{
		public override InputDeviceCharacteristics Characteristics
		{
			get
			{
				return default(InputDeviceCharacteristics);
			}
		}

		public RightControllerActionMap()
			: base()
		{
		}
	}
}
