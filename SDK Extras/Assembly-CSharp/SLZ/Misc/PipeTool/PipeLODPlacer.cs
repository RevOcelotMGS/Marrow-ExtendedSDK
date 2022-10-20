using UnityEngine;

namespace SLZ.Misc.PipeTool
{
	public class PipeLODPlacer : MonoBehaviour
	{
		public PipeLODMap lodMap;

		public GameObject LOD0Root;

		[SerializeField]
		private GameObject LOD1Root;

		[SerializeField]
		private GameObject LOD2Root;

		public PipeLODPlacer()
			: base()
		{
		}
	}
}
