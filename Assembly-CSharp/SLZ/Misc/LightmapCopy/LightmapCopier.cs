using UnityEngine;

namespace SLZ.Misc.LightmapCopy
{
	[RequireComponent(typeof(MeshRenderer))]
	public class LightmapCopier : MonoBehaviour
	{
		public MeshRenderer referenceRenderer;

		public void Awake()
		{
		}

		public void CopyLightmaps()
		{
		}

		public LightmapCopier()
			: base()
		{
		}
	}
}
