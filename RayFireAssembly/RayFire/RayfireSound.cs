using UnityEngine;

namespace RayFire
{
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-sound-component/")]
	[SelectionBase]
	[AddComponentMenu("RayFire/Rayfire Sound")]
	public class RayfireSound : MonoBehaviour
	{
		public float baseVolume;

		public float sizeVolume;

		public RFSound initialization;

		public RFSound activation;

		public RFSound demolition;

		public float minimumSize;

		public float cameraDistance;

		public RayfireRigid rigid;

		public RayfireRigidRoot rigidRoot;

		private void Start()
		{
		}

		private void SetComponents()
		{
		}

		private void WarningCheck()
		{
		}

		public void CopyFrom(RayfireSound source)
		{
		}

		private void CreateSource(RayfireRigid scr)
		{
		}

		public RayfireSound()
			: base()
		{
		}
	}
}
