using UnityEngine;

namespace SLZ.Environment
{
	public class Nail : MonoBehaviour
	{
		public Rigidbody rb;

		public Rigidbody connectedRb;

		public ConfigurableJoint joint;

		public Transform nailTran;

		public float breakforce;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void SetJoint()
		{
		}

		public Nail()
			: base()
		{
		}
	}
}
