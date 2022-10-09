using System.Collections.Generic;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourVoidWatcher : BehaviourBase
	{
		public enum VoidWatcherState
		{
			Emerge = 0,
			Watch = 1,
			Submerge = 2
		}

		public SubBehaviourSfx sfx;

		public VoidWatcherState watcherState;

		public float emergeTime;

		public float submergeTime;

		public Vector3 emergeLocalDisplace;

		public bool playAgroSound;

		public float loopVolume;

		private HashSet<Rigidbody> _selfRbs;

		private Quaternion _localAnimatedRoot;

		private float _blockCollisionsUntil;

		private int _flinchAnim;

		private int _clipIntAnim;

		private bool _disableOnUpdate;

		private Vector3 _currentVel;

		private Vector3 _initialConnectedAnchor;

		private Vector3 _targetConnectedAnchor;

		private Vector3 _animatedRoot;

		public void SubmergeVoidWatcher()
		{
		}

		private float ProcessImpulse(Collision c, Rigidbody thisRb)
		{
			return default(float);
		}

		private void ResetAnimator()
		{
		}

		private void OnTriggerEnter(Collider c)
		{
		}

		public void SwitchWatcherState(VoidWatcherState goToState)
		{
		}

		public BehaviourVoidWatcher()
			: base()
		{
		}
	}
}
