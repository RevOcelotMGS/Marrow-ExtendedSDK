using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ;
using SLZ.Marrow.Data;
using SLZ.Props.Weapons;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourOmniwheel : BehaviourBaseNav
	{
		[Flags]
		public enum CombatType
		{
			Charge = 1,
			JumpAttack = 2,
			ThrowLob = 4,
			GunFight = 8
		}

		public enum ChargeState
		{
			Windup = 0,
			Lockon = 1,
			Charge = 2
		}

		public enum GunfightState
		{
			Aim = 0,
			Fire = 1,
			Reload = 2,
			Reposition = 3
		}

		protected enum JumpType
		{
			Dash = 0,
			Attack = 1,
			FaceMount = 2,
			OffmeshLink = 3
		}

		public enum EngagedMode
		{
			Follow = 0,
			Stay = 1,
			Hide = 2
		}

		[Header("Omni Settings")]
		public float scaleFactor;

		[Header("Projection")]
		public bool hasCombatProjection;

		public Animator projectionAnimator;

		public Transform hipsProjTransform;

		public Transform chestProjTransform;

		public Transform headProjTransform;

		public Transform gunPropTransform;

		public AnimationCurve deathFlicker;

		public bool crumbleDeath;

		public float DeathExplosionForce;

		public float CrumbleDespawnTime;

		private float _animationBlendWeight;

		private float _animationBlendWeightV;

		private float _blendToAnimationTime;

		private bool _debugDrawHierarchy;

		private int _yLocoAnim;

		private int _xLocoAnim;

		private int _additiveAimNormalAnim;

		private int _xAimAddAnim;

		private int _yAimAddAnim;

		private int _crouchAnim;

		private int _atEaseAnim;

		private int _walkingAnim;

		private int _accuracyAnim;

		private Quaternion _gunDefaultQuat;

		private bool _joystickRecieved;

		private Vector3 _joystickVel;

		private Vector3 _joystickForwardWorld;

		[Header("Dependencies")]
		public Spawnable rigidbodyProjectileSpawnable;

		[EnumFlags]
		[Header("Agro State")]
		public CombatType combatProficiency;

		public CombatType agroState;

		public float chargePrepSpeed;

		public float chargeAttackSpeed;

		public float chargeWindupDistance;

		public float chargeCooldown;

		private ChargeState _chargeState;

		public Gun gun;

		private GunfightState _gunfightState;

		public float meleeRange;

		public float desiredMeleeDistance;

		public float meleeCooldown;

		public bool enableJumpAttack;

		private float _cooldownMelee;

		private float _cooldownGun;

		private float _meleeActiveUntilTime;

		private float _aimZeroOverTime;

		private bool _attackActive;

		private Vector3 _targetFromGunWorldDir;

		private Vector3 _desiredProjectileVel;

		private Quaternion _localAim1;

		private Quaternion _localAim2;

		private int _burstCount;

		protected JumpType jumpType;

		public float wheelRadius;

		[Range(0f, 16f)]
		public float restingActivateRange;

		public float jumpCooldown;

		public float jumpCharge;

		private Vector3 _lookDirectionWorld;

		private bool _chargeJump;

		private bool _blockAiTick;

		private bool _isCalculated;

		private float _dyingTime;

		private float _unbalancedTimer;

		private float _wheelCircumference;

		private Quaternion _worldFootBall;

		private Quaternion _lastWorldFootBall;

		[Header("Engaged State")]
		public EngagedMode engagedMode;

		public float followDistance;

		public float followSpeed;

		public float breakFollowTargetDistance;

		public float breakFollowHomeDistance;

		public float hideDistance;

		public float hideSpeed;

		public float breakHideTargetDistance;

		public float breakHideHomeDistance;

		private Vector3 _mirrorLeftDir;

		private Vector3 _mirrorRightDir;

		private Vector3 _lastMirrorLeftDir;

		private Vector3 _lastMirrorRightDir;

		private float _t;

		public void StartDeathFlicker()
		{
		}

		private IEnumerator CoFlickerDeath(float duration)
		{
			return null;
		}

		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		public void JOYSTICK(PropJoystick.JoystickData joyData)
		{
		}

		private void Awake()
		{
		}

		private void SwitchAgroState()
		{
		}

		private void UpdateAttack()
		{
		}

		private void TickAttack()
		{
		}

		public void UpdateEngagedFrame()
		{
		}

		public void UpdateEngagedTick()
		{
		}

		public void SwitchEngagedState()
		{
		}

		public BehaviourOmniwheel()
			: base()
		{
		}
	}
}
