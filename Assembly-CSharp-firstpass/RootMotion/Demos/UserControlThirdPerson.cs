using UnityEngine;

namespace RootMotion.Demos
{
	public class UserControlThirdPerson : MonoBehaviour
	{
		public struct State
		{
			public Vector3 move;

			public Vector3 lookPos;

			public bool crouch;

			public bool jump;

			public int actionIndex;
		}

		public bool walkByDefault;

		public bool canCrouch;

		public bool canJump;

		public State state;

		protected Transform cam;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public UserControlThirdPerson()
			: base()
		{
		}
	}
}
