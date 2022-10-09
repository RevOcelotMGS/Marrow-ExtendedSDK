using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class UserControlInteractions : UserControlThirdPerson
	{
		[SerializeField]
		private CharacterThirdPerson character;

		[SerializeField]
		private InteractionSystem interactionSystem;

		[SerializeField]
		private bool disableInputInInteraction;

		public float enableInputAtProgress;

		protected override void Update()
		{
		}

		private void OnGUI()
		{
		}

		public UserControlInteractions()
			: base()
		{
		}
	}
}
