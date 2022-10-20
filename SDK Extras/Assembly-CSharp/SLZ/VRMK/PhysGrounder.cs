using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Rig;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.VRMK
{
	public class PhysGrounder : MonoBehaviour
	{
		public PhysicsRig physRig;

		public bool isGrounded;

		public bool ungroundedThisFrame;

		public bool ladderCheck;

		public Vector3 groundNormal;

		public Vector3 _totalImpulse;

		public AudioClip feetSkidSlime;

		public AudioClip[] highFallClips;

		public AudioMixerGroup mixerGroup;

		public float highFallVolumeMult;

		public PhysicMaterial[] slimeMats;

		private Vector3 _deltaVel;

		private Vector3 _groundVel;

		private Vector3 _lastGroundVel;

		private float _groundMultSum;

		private float _groundAngVel;

		private float _highestImpulse;

		private Collider _groundedCollider;

		private int _count;

		private Rigidbody _rb;

		private AudioPlayer _skidAp;

		private bool _hasSkidAp;

		private int collisionLayer;

		public void OnAwake(PhysicsRig phys)
		{
		}

		private void OnDisable()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		private void OnCollisionStay(Collision c)
		{
		}

		private void ProcessCollision(Collision c, bool isEnter = false)
		{
		}

		private void HighFallClipSpawn(float volume, float pitch, float minDistance)
		{
		}

		private void UpdateSkid(float skidMag)
		{
		}

		private bool CheckMat()
		{
			return default(bool);
		}

		public void FeetGrounded(float footballRadius, [Out] Vector3 groundVelocity, [Out] float groundAngVel, [Out] Vector3 skidVelocity, [Out] float skidMag, [Out] Vector3 impulse)
		{
		}

		public PhysGrounder()
			: base()
		{
		}
	}
}
