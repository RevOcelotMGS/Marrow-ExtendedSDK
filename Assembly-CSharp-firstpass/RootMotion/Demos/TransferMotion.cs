using UnityEngine;

namespace RootMotion.Demos
{
	public class TransferMotion : MonoBehaviour
	{
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Range(0f, 1f)]
		[Tooltip("The amount of motion to transfer.")]
		public float transferMotion;

		private Vector3 lastPosition;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public TransferMotion()
			: base()
		{
		}
	}
}
