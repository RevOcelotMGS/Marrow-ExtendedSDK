using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class RagdollUtilityDemo : MonoBehaviour
	{
		public RagdollUtility ragdollUtility;

		public Transform root;

		public Rigidbody pelvis;

		private void OnGUI()
		{
		}

		public RagdollUtilityDemo()
			: base()
		{
		}
	}
}
