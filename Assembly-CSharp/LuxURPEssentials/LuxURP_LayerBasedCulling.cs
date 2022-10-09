using UnityEngine;

namespace LuxURPEssentials
{
	public class LuxURP_LayerBasedCulling : MonoBehaviour
	{
		[Space(5f, order = 1)]
		[LuxURP_HelpBtn("h.2uxuzzrgrwpo", order = 0)]
		public LayerMask SmallDetailsLayer;

		public float SmallDetailsDistance;

		public LayerMask MediumDetailsLayer;

		public float MediumDetailsDistance;

		private int GetLayerNumber(int LayerValue)
		{
			return default(int);
		}

		private void OnEnable()
		{
		}

		public LuxURP_LayerBasedCulling()
			: base()
		{
		}
	}
}
