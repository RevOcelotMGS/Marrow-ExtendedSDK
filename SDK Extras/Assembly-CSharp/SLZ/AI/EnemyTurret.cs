using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Props.Weapons;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.AI
{
	public class EnemyTurret : MonoBehaviour
	{
		private enum TurretStates
		{
			NONE = 0,
			PATROL = 1,
			ALERT = 2,
			TIPPED = 3,
			DEAD = 4,
			PANIC = 5,
			SLEEP = 6
		}

		[Header("Settings")]
		public LayerMask raycastMask;

		public bool isRotateTowardsLastTargetOnJump;

		public float visionRadius;

		public float visionAngle;

		public int maxUnflipTries;

		public int _burstCount;

		public float _reloadDelay;

		public float _burstDelay;

		[ColorUsage(true, true)]
		public Color idleColor;

		[ColorUsage(true, true)]
		public Color alertColor;

		[Header("References")]
		public AITrigger trigger;

		public InteractableHost host;

		public Collider[] ignoreColliders;

		public GameObject laserPointer;

		public Transform visionPointTransform;

		public Gun gun;

		[Header("Joint References")]
		public ConfigurableJoint spineSlideJnt;

		public ConfigurableJoint legRearJnt;

		public ConfigurableJoint legHingeLeftJnt;

		public ConfigurableJoint legHingeRightJnt;

		public ConfigurableJoint legLeftJnt;

		public ConfigurableJoint legRightJnt;

		public ConfigurableJoint bodyJnt;

		public ConfigurableJoint gunJnt;

		[Header("Joint Rigidbody References")]
		public Rigidbody bodyRB;

		public Rigidbody barrelRB;

		public Rigidbody hingeLRB;

		public Rigidbody legLRB;

		public Rigidbody hingeRRB;

		public Rigidbody legRRB;

		public Rigidbody rearSliderRB;

		public Rigidbody rearLegRB;

		public Action OnDeath;

		public Action OnResurrection;

		private ConfigurableJoint _flipJoint;

		private bool _isPacked;

		private bool _isTipped;

		private bool _hasBeenTipped;

		private Collider[] _collectedColliders;

		private int _maxCollidersCollected;

		private Quaternion _gunJntStartRotation;

		private Quaternion _bodyJntStartRotation;

		private Transform _targetTransform;

		private RigidbodySettings _rigidbodySettings;

		private Rigidbody _rigidbody;

		private bool _immediateFlip;

		private GenericTurretSFX _sfx;

		private float _timeLastSleep;

		private HashSet<AITarget> _aiTargets;

		private Coroutine _flipSequenceCoroutine;

		private Coroutine _alertSequenceCoroutine;

		private Coroutine _searchCoroutine;

		private Coroutine _visionCheckCoroutine;

		private Coroutine _packLegsCoroutine;

		private Coroutine _setStateCoroutine;

		private Coroutine _panicSequenceCoroutine;

		private Coroutine _tippedCheckCoroutine;

		private SimpleTransform _bodyLocal;

		private SimpleTransform _barrelLocal;

		private SimpleTransform _hingeLLocal;

		private SimpleTransform _legLLocal;

		private SimpleTransform _hingeRLocal;

		private SimpleTransform _legRLocal;

		private SimpleTransform _rearSliderLocal;

		private SimpleTransform _rearLegLocal;

		private TurretStates state;

		private TurretStates bufferState;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnAITriggerEnter(AITarget target)
		{
		}

		public void OnAITriggerExit(AITarget target)
		{
		}

		public void TriggerFire()
		{
		}

		public void ToggleSleep()
		{
		}

		public void Kill()
		{
		}

		private void SetState(TurretStates nextState)
		{
		}

		private IEnumerator CoSetState(TurretStates nextState)
		{
			return null;
		}

		private void LookAtTarget()
		{
		}

		private void JointLookRotation(ConfigurableJoint joint, Quaternion startRotation, Quaternion lookRotation)
		{
		}

		private void StartPanicSequence()
		{
		}

		private void StopPanicSequence()
		{
		}

		private IEnumerator CoPanicSequence()
		{
			return null;
		}

		private void StartFlipSequence()
		{
		}

		private void StopFlipSequence()
		{
		}

		private IEnumerator CoFlipSequence()
		{
			return null;
		}

		private void StartAlertSequence()
		{
		}

		private void StopAlertSequence()
		{
		}

		private IEnumerator CoAlertSequence()
		{
			return null;
		}

		private void StartSearchAnimation()
		{
		}

		private void StopSearchAnimation()
		{
		}

		private IEnumerator CoSearchAnimation(float duration = 10f)
		{
			return null;
		}

		private void StartVisionCheck(bool raycastCheck = true, bool sleepCheck = true, Action<AITarget> callback = default(Action<AITarget>))
		{
		}

		private void StopVisionCheck()
		{
		}

		private IEnumerator CoVisionCheck(bool raycastCheck = true, bool sleepCheck = true, Action<AITarget> callback = default(Action<AITarget>))
		{
			return null;
		}

		private void StartTippedCheck(Action<bool> callback)
		{
		}

		private void StopTippedCheck()
		{
		}

		private IEnumerator CoTippedCheck(Action<bool> callback)
		{
			return null;
		}

		private void PackLegs(bool isPacking = true)
		{
		}

		private IEnumerator CoPackLegs()
		{
			return null;
		}

		private IEnumerator CoUnPackLegs()
		{
			return null;
		}

		public EnemyTurret()
			: base()
		{
		}
	}
}
