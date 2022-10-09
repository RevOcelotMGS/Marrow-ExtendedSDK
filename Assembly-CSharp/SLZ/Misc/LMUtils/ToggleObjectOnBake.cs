using UnityEngine;

namespace SLZ.Misc.LMUtils
{
	public class ToggleObjectOnBake : MonoBehaviour
	{
		[Header("This script turns on the object it is attached to during lightmap baking")]
		public bool ToggleOffOnBakeInstead;

		public ToggleObjectOnBake()
			: base()
		{
		}
	}
}
