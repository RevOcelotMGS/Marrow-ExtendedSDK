using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class HitReactionTrigger : MonoBehaviour
	{
		[SerializeField]
		private HitReaction hitReaction;

		[SerializeField]
		private float hitForce;

		private string colliderName;

		private void Update()
		{
		}

		private void OnGUI()
		{
		}

		public HitReactionTrigger()
			: base()
		{
		}
	}
}
