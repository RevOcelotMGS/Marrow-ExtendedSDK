using UnityEngine;

namespace RootMotion.Demos
{
	public class MechSpider : MonoBehaviour
	{
		public LayerMask raycastLayers;

		public float scale;

		public Transform body;

		public MechSpiderLeg[] legs;

		public float legRotationWeight;

		public float rootPositionSpeed;

		public float rootRotationSpeed;

		public float breatheSpeed;

		public float breatheMagnitude;

		public float height;

		public float minHeight;

		public float raycastHeight;

		public float raycastDistance;

		private Vector3 lastPosition;

		private Vector3 defaultBodyLocalPosition;

		private float sine;

		private RaycastHit rootHit;

		private void Update()
		{
		}

		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		public MechSpider()
			: base()
		{
		}
	}
}
