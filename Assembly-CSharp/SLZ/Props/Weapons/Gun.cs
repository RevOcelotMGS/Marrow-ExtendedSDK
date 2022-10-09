using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.AI;
using SLZ.Combat;
using SLZ.Interaction;
using SLZ.MIA;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using SLZ.Player;
using SLZ.SFX;
using SLZ.Zones;
using UnityEngine;

namespace SLZ.Props.Weapons
{
	public class Gun : SpawnEvents
	{
		public enum FireMode
		{
			MANUAL = 0,
			SEMIAUTOMATIC = 1,
			AUTOMATIC = 2
		}

		public enum AnimationStates
		{
			NONE = 0,
			NEUTRAL = 1,
			SLIDEPULL = 2,
			SLIDEPULLREVERSED = 3,
			SLIDERETURN = 4,
			SLIDERETURNREVERSED = 5,
			SLIDELOCKED = 6,
			SLIDELOCKEDREVERSED = 7,
			FIRE = 8,
			FIRERETURN = 9
		}

		public enum SlideStates
		{
			RETURNING = 0,
			RETURNED = 1,
			PULLING = 2,
			PULLED = 3,
			LOCKED = 4
		}

		public enum HammerStates
		{
			UNCOCKED = 0,
			COCKED = 1
		}

		public enum CartridgeStates
		{
			NONE = 0,
			UNSPENT = 1,
			SPENT = 2
		}

		private static ComponentCache<Gun> _cache;

		private MagazineState _magState;

		private bool _hasMagState;

		[Header("Settings")]
		public bool isSilenced;

		public float roundsPerMinute;

		public float muzzleVelocity;

		public FireMode fireMode;

		public CurveData fireCurve;

		public CurveData returnCurve;

		public bool isSlideReleaseOnCollision;

		public bool allowFireOnSlideGrabbed;

		public bool isCharged;

		public bool isSlideLockedOnEmpty;

		public bool isLoaded;

		public bool isMagEjectOnEmpty;

		[Header("Spawn Dependencies")]
		public Spawnable muzzleFlareSpawnable;

		[Header("References")]
		public Animator animator;

		public InteractableHost host;

		public MagazineData internalMagazine;

		public MagazineData defaultMagazine;

		public CartridgeData defaultCartridge;

		public SlideVirtualController slideVirtualController;

		public Renderer chargingHandleHelperRenderer;

		public Renderer magazineHelperRenderer;

		public Grip triggerGrip;

		public Grip[] otherGrips;

		public GunSFX gunSFX;

		public TriggerRefProxy proxyOverride;

		public Transform shellSpawnTransform;

		public Transform shellOrientationTransform;

		public Transform firePointTransform;

		public GameObject nextCartridgeGameObject;

		public GameObject chamberedCaseGameObject;

		public GameObject chamberedCatridgeGameObject;

		public GameObject chamberedCartridgeSpentGameObject;

		private FirearmCartridge _chamberedCartridgeArt;

		private FirearmCartridge _chamberedCartridgeCaseArt;

		private FirearmCartridge _nextCartridgeArt;

		public Action onFireDelegate;

		public Action<float> OnSlideUpdate;

		public Action OnSlideGrabbed;

		public Action OnSlideReleased;

		public Action OnMagazineEjectDelegate;

		public Action<MagazineData> OnMagazineForceInsert;

		private float kickForce;

		private bool isTriggerPulledOnAttach;

		[HideInInspector]
		public bool isFiring;

		[HideInInspector]
		public bool isTriggerPulled;

		private bool isTriggerPressed;

		private bool hasFiredOnce;

		private int fireSpeedHash;

		private int neutralHash;

		private int slidePullHash;

		private int slideReturnHash;

		private int slideLockedHash;

		private float pullAnimationPerc;

		private float returnAnimationPerc;

		private float pullAnimationSpeed;

		private float returnAnimationSpeed;

		private float roundsPerSecond;

		private float fireDuration;

		private float slideLockDuration;

		private CartridgeData chamberedCartridge;

		private bool _hasFiredSinceLastBroadcast;

		private float _lastTimeEventWasBroadcasted;

		private bool _wasInstaLoaded;

		private AmmoInventory _AmmoInventory;

		[HideInInspector]
		public AnimationStates animationState;

		[HideInInspector]
		public SlideStates slideState;

		[HideInInspector]
		public HammerStates hammerState;

		[HideInInspector]
		public CartridgeStates cartridgeState;

		private Vector3 cachedVelocity;

		private Coroutine blinkHighlightCoroutine;

		private MIASimulationEventBroker _simulationEventBroker;

		private float overridePerc;

		private bool isSlideOverride;

		private bool _isSlideGrabbed;

		[HideInInspector]
		public AnimationStates lastCompletedAnimation;

		private float leftOverTime;

		private Coroutine playAnimationStateCoroutine;

		public static ComponentCache<Gun> Cache
		{
			get
			{
				return null;
			}
		}

		[HideInInspector]
		public MagazineState MagazineState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected MIASimulationEventBroker SimulationEventBroker
		{
			get
			{
				return null;
			}
		}

		protected virtual void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void Update()
		{
		}

		public void InstantLoad()
		{
		}

		protected override void OnPostSpawn(GameObject go)
		{
		}

		protected override void OnDespawn(GameObject go)
		{
		}

		public void OnMagazineInserted()
		{
		}

		private void UpdateMagazineArt()
		{
		}

		private void Charge()
		{
		}

		public void OnMagazineRemoved()
		{
		}

		private FirearmCartridge ApplyBulletArt(GameObject go, Transform parent)
		{
			return null;
		}

		private IEnumerator CoBlinkHighlight(Renderer renderer)
		{
			return null;
		}

		protected virtual int AmmoCount()
		{
			return default(int);
		}

		public void CheckGunRequirements()
		{
		}

		public bool RequiresChargingHandle()
		{
			return default(bool);
		}

		private void AggroItem(TriggerRefProxy proxy, SceneZone zone, bool isSubZone)
		{
		}

		private void BroadcastGunFiredEvent()
		{
		}

		public void SlideOverride()
		{
		}

		public void SlideOverrideReleased()
		{
		}

		public void SlideGrabbed()
		{
		}

		public void SlideGrabbedReleased()
		{
		}

		public void UpdateSlidePercentage(float perc)
		{
		}

		public void SlidePull()
		{
		}

		private void SlideLocked()
		{
		}

		public void SlideRelease()
		{
		}

		protected virtual void OnFire()
		{
		}

		public virtual void Fire()
		{
		}

		public void CeaseFire()
		{
		}

		public void SetAnimationState(AnimationStates state, float perc)
		{
		}

		private IEnumerator CoOnAnimationComplete(AnimationStates completedAnimation)
		{
			return null;
		}

		private void OnAnimationComplete(AnimationStates completedAnimation)
		{
		}

		public void PlayAnimationState(AnimationStates state, float startPerc = 0f)
		{
		}

		private IEnumerator CoPlayAnimation(AnimationStates state, bool isReversed = false, float startPerc = 0f, float duration = 1f, AnimationCurve curve = default(AnimationCurve))
		{
			return null;
		}

		private void PullCartridge()
		{
		}

		private void EjectCartridge()
		{
		}

		private void UpdateArt()
		{
		}

		private void CompleteSlidePull()
		{
		}

		private void CompleteSlideReturn()
		{
		}

		protected virtual void OnTriggerGripAttached(Hand hand)
		{
		}

		protected virtual void OnTriggerGripDetached(Hand hand)
		{
		}

		public virtual bool HasMagazine()
		{
			return default(bool);
		}

		public Gun()
			: base()
		{
		}
	}
}
