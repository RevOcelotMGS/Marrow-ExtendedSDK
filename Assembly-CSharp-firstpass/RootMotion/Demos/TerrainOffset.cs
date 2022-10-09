using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class TerrainOffset : MonoBehaviour
	{
		public AimIK aimIK;

		public Vector3 raycastOffset;

		public LayerMask raycastLayers;

		public float min;

		public float max;

		public float lerpSpeed;

		private RaycastHit hit;

		private Vector3 offset;

		private void LateUpdate()
		{
		}

		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		public TerrainOffset()
			: base()
		{
		}
	}
}
