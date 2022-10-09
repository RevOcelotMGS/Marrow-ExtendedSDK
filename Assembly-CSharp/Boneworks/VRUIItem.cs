using UnityEngine;

namespace Boneworks
{
	[RequireComponent(typeof(RectTransform))]
	public class VRUIItem : MonoBehaviour
	{
		private Collider boxCollider;

		private RectTransform rectTransform;

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void ValidateCollider()
		{
		}

		public VRUIItem()
			: base()
		{
		}
	}
}
