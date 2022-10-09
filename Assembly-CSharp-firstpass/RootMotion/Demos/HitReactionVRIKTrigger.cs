using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[SerializeField]
		private float hitForce;

		private string colliderName;

		private void Update()
		{
		}

		private void OnGUI()
		{
		}

		public HitReactionVRIKTrigger()
			: base()
		{
		}
	}
}
