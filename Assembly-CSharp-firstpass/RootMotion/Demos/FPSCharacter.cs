using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(FPSAiming))]
	public class FPSCharacter : MonoBehaviour
	{
		[Range(0f, 1f)]
		public float walkSpeed;

		private float sVel;

		private Animator animator;

		private FPSAiming FPSAiming;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnGUI()
		{
		}

		public FPSCharacter()
			: base()
		{
		}
	}
}
