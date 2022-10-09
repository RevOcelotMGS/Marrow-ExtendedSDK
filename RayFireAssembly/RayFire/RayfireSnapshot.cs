using UnityEngine;

namespace RayFire
{
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-snapshot-component/")]
	[AddComponentMenu("RayFire/Rayfire Snapshot")]
	[DisallowMultipleComponent]
	[SelectionBase]
	public class RayfireSnapshot : MonoBehaviour
	{
		public string assetName;

		public bool compress;

		public Object snapshotAsset;

		public float sizeFilter;

		private void Reset()
		{
		}

		public RayfireSnapshot()
			: base()
		{
		}
	}
}
