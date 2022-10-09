using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourGunther : BehaviourBase
	{
		public SubBehaviourSensors sensors;

		public SubBehaviourHealth health;

		public SubBehaviourSfx sfx;

		private Quaternion _lastRotation;

		private Quaternion _localAnimatedRoot;

		private Powerable_Vehicle _powerVehicle;

		private float _blockCollisionsUntil;

		private bool _debugDrawHierarchy;

		private int _flinchAnim;

		private int _clipIntAnim;

		private float _time;

		private float _fixedTime;

		private float _currentRotVel;

		private float _currentRotDelta;

		private Vector3 _animatedRoot;

		private bool _playerInTrigger;

		private float ProcessImpulse(Collision c, Rigidbody thisRb)
		{
			return default(float);
		}

		private void UpdateStun()
		{
		}

		private void ResetAnimator()
		{
		}

		private void OnTriggerEnter(Collider c)
		{
		}

		private void OnTriggerExit(Collider c)
		{
		}

		public BehaviourGunther()
			: base()
		{
		}
	}
}
