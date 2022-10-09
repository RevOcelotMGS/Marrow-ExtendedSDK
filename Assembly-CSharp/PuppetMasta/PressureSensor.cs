using System.Runtime.CompilerServices;
using UnityEngine;

namespace PuppetMasta
{
	public class PressureSensor : MonoBehaviour
	{
		public bool visualize;

		public LayerMask layers;

		private bool fixedFrame;

		private Vector3 P;

		private int count;

		public Vector3 center { get; private set; }

		public bool inContact { get; private set; }

		public Vector3 bottom { get; private set; }

		public Rigidbody r { get; private set; }

		private void Awake()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		private void OnCollisionStay(Collision c)
		{
		}

		private void OnCollisionExit(Collision c)
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void ProcessCollision(Collision c)
		{
		}

		private void OnDrawGizmos()
		{
		}

		public PressureSensor()
			: base()
		{
		}
	}
}
