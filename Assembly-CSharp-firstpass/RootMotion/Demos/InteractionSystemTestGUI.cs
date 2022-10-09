using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(InteractionSystem))]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Tooltip("The object to interact to")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Tooltip("The effectors to interact with")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		private InteractionSystem interactionSystem;

		private void Awake()
		{
		}

		private void OnGUI()
		{
		}

		public InteractionSystemTestGUI()
			: base()
		{
		}
	}
}
