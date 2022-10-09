using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class FPSAiming : MonoBehaviour
	{
		[Range(0f, 1f)]
		public float aimWeight;

		[Range(0f, 1f)]
		public float sightWeight;

		[Range(0f, 180f)]
		public float maxAngle;

		public Vector3 aimOffset;

		[SerializeField]
		private bool animatePhysics;

		[SerializeField]
		private Transform gun;

		[SerializeField]
		private Transform gunTarget;

		[SerializeField]
		private FullBodyBipedIK ik;

		[SerializeField]
		private AimIK gunAim;

		[SerializeField]
		private CameraControllerFPS cam;

		[SerializeField]
		private Recoil recoil;

		[Range(0f, 1f)]
		[SerializeField]
		private float cameraRecoilWeight;

		private Vector3 gunTargetDefaultLocalPosition;

		private Quaternion gunTargetDefaultLocalRotation;

		private Vector3 camDefaultLocalPosition;

		private Vector3 camRelativeToGunTarget;

		private bool updateFrame;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void Aiming()
		{
		}

		private void LookDownTheSight()
		{
		}

		private void RotateCharacter()
		{
		}

		public FPSAiming()
			: base()
		{
		}
	}
}
