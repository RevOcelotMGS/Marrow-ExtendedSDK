using UnityEngine;

namespace SLZ.UI
{
	public class UI_SmoothFollow : MonoBehaviour
	{
		public Transform target;

		public float distance;

		public float height;

		public float damping;

		public bool smoothRotation;

		public bool followBehind;

		public float rotationDamping;

		private void Update()
		{
		}

		public UI_SmoothFollow()
			: base()
		{
		}
	}
}
