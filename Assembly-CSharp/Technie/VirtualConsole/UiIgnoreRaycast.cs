using UnityEngine;

namespace Technie.VirtualConsole
{
	public class UiIgnoreRaycast : MonoBehaviour, ICanvasRaycastFilter
	{
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		public UiIgnoreRaycast()
			: base()
		{
		}
	}
}
