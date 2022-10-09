using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(AnimatorController3rdPerson))]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[SerializeField]
		private CameraController cam;

		private AnimatorController3rdPerson animatorController;

		private static Vector3 inputVector
		{
			get
			{
				return default(Vector3);
			}
		}

		private static Vector3 inputVectorRaw
		{
			get
			{
				return default(Vector3);
			}
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public CharacterController3rdPerson()
			: base()
		{
		}
	}
}
