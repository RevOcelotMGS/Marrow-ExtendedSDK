using UnityEngine;

namespace Boneworks
{
	[RequireComponent(typeof(TrailRenderer))]
	public class TrailTimescale : MonoBehaviour
	{
		[HideInInspector]
		[SerializeField]
		private TrailRenderer TR;

		[Tooltip("Number of frames the trail will appear")]
		[SerializeField]
		private float TrailSize;

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		public TrailTimescale()
			: base()
		{
		}
	}
}
