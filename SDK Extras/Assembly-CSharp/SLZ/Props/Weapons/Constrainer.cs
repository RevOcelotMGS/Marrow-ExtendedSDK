using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.SFX;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Props.Weapons
{
	public class Constrainer : MonoBehaviour
	{
		public enum ConstraintMode
		{
			Tether = 0,
			Weld = 1,
			BallSocket = 2,
			Elastic = 3,
			EntangleRotation = 4,
			EntagleVelocity = 5,
			Remove = 6
		}

		public ConstraintMode mode;

		public Grip triggerGrip;

		public Transform firePoint;

		public Transform firePoint2;

		public float maxRange;

		public LayerMask layerMask;

		public GravGunSFX sfx;

		public GameObject laser;

		public GameObject laser2;

		public GameObject icon;

		[SerializeField]
		private Material LineMaterial;

		private bool _raycastMissedOnDown;

		private Vector3 _point1;

		private Vector3 _point2;

		private Vector3 _normal1;

		private Vector3 _normal2;

		private Rigidbody _rb1;

		private Rigidbody _rb2;

		private GameObject _gO1;

		private GameObject _gO2;

		public AudioMixerGroup outputMixer;

		public AudioClip[] modeSFX;

		private AudioPlayer ap;

		private Material iconMat;

		private float breakforce;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void OnTriggerGripUpdate(Hand hand)
		{
		}

		private void OnTriggerGripAttached(Hand hand)
		{
		}

		private void OnTriggerGripDetached(Hand hand)
		{
		}

		private void PrimaryButtonDown()
		{
		}

		private void PrimaryButtonUp()
		{
		}

		private void PrimaryButtonHold()
		{
		}

		private void Swap1and2()
		{
		}

		private ConfigurableJoint JointTether(Rigidbody main, Rigidbody cb, Vector3 anchor, Vector3 connectedA)
		{
			return null;
		}

		private ConfigurableJoint JointWeld(Rigidbody main, Rigidbody cb, Vector3 anchor, Vector3 connectedA)
		{
			return null;
		}

		private ConfigurableJoint JointBallSocket(Rigidbody main, Rigidbody cb, Vector3 anchor, Vector3 connectedA, bool swapped)
		{
			return null;
		}

		private ConfigurableJoint JointElastic(Rigidbody main, Rigidbody cb, Vector3 anchor, Vector3 connectedA)
		{
			return null;
		}

		private ConfigurableJoint JointEntangleRotation(Rigidbody main, Rigidbody cb, Vector3 anchor, Vector3 connectedA)
		{
			return null;
		}

		private ConfigurableJoint JointEntangleVelocity(Rigidbody main, Rigidbody cb, Vector3 anchor, Vector3 connectedA)
		{
			return null;
		}

		private ConstraintTracker SelectConstraint(GameObject gO)
		{
			return null;
		}

		private void PlaySFX(AudioClip[] audioClips, Vector3 position)
		{
		}

		public Constrainer()
			: base()
		{
		}
	}
}
