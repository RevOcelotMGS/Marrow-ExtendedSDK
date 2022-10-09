using UnityEngine;

namespace RootMotion.Demos
{
	public class MechSpiderController : MonoBehaviour
	{
		public MechSpider mechSpider;

		public Transform cameraTransform;

		public float speed;

		public float turnSpeed;

		public Vector3 inputVector
		{
			get
			{
				return default(Vector3);
			}
		}

		private void Update()
		{
		}

		public MechSpiderController()
			: base()
		{
		}
	}
}
