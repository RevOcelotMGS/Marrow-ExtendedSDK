using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using SLZ.Player;
using SLZ.VRMK;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Rig
{
	[SelectionBase]
	public class RigManager : MonoBehaviour
	{
		private enum LeashType
		{
			Circle = 0,
			Rectangle = 1
		}

		private static ComponentCache<RigManager> _cache;

		[Header("Control")]
		public ControllerRig tempOverrideControl;

		public OpenControllerRig openControllerRig;

		public RealtimeSkeletonRig realHeptaRig;

		public RemapRig remapHeptaRig;

		[Header("Rigs")]
		public GameWorldSkeletonRig virtualHeptaRig;

		public PhysicsRig physicsRig;

		[FormerlySerializedAs("artRig")]
		public SkeletonRig animationRig;

		public ArtRig artOutputRig;

		[Header("Modules")]
		public Inventory inventory;

		public UIRig uiRig;

		public TutorialRig tutorialRig;

		[Header("Player Data")]
		public BodyVitals bodyVitals;

		public Health health;

		public AmmoInventory AmmoInventory;

		public Seat activeSeat;

		[Header("Avatar")]
		[SerializeField]
		[ReadOnly(false)]
		[Tooltip("Readonly field, to change which avatar is used in a scene, use \"Avatar Override\"")]
		private SLZ.VRMK.Avatar _avatar;

		private SLZ.VRMK.Avatar _avatarOnDeck;

		private bool _avatarDirty;

		private string _avatarID;

		[SerializeField]
		[Tooltip("Overrides the avatar for the scene (overrides the loaded avatar)")]
		private AvatarCrateReference _avatarCrate;

		public bool loadAvatarFromSaveData;

		[SerializeField]
		private SLZ.VRMK.Avatar _calibrationAvatar;

		private string calibrationAvatarBarcode;

		public BonelabSerializableDictionaries.StringAvatarDictionary _avatarCache;

		[HideInInspector]
		public WorldGrip worldGrip;

		public bool isWorldGripEnabled;

		public HandPose worldGripHandPose;

		private Rig[] rigs;

		private bool _fixedRan;

		private int _lastFrame;

		public Action onAvatarSwapped;

		public Action<string> onAvatarSwapped2;

		public Action OnPreAvatarEarlyUpdate;

		public Action OnPostLateUpdate;

		private SimpleTransform _queuedDestination;

		private bool _teleportQueued;

		private bool _leashed;

		private Vector3 _leashPositionWorld;

		private Quaternion _leashRotationWorld;

		private Vector2 _maxBounds;

		private Vector2 _minBounds;

		private ConfigurableJoint _leashJoint1;

		private ConfigurableJoint _leashJoint2;

		private LeashType _type;

		public static ComponentCache<RigManager> Cache
		{
			get
			{
				return null;
			}
		}

		public ControllerRig ControllerRig
		{
			get
			{
				return null;
			}
		}

		public SLZ.VRMK.Avatar avatar
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public string avatarID
		{
			get
			{
				return null;
			}
		}

		public AvatarCrateReference AvatarCrate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SLZ.VRMK.Avatar CalibrationAvatar
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isLeashed
		{
			get
			{
				return default(bool);
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void EarlyUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public Rig GetNextRig(int i)
		{
			return null;
		}

		public Rig GetPreviousRig(int i)
		{
			return null;
		}

		public Rig GetFirstRig()
		{
			return null;
		}

		public Rig GetLastRig()
		{
			return null;
		}

		public Rig GetRig(int i)
		{
			return null;
		}

		public void LoadAvatarFromSaveData()
		{
		}

		public UniTask LoadAvatarFromSaveDataAsync()
		{
			return default(UniTask);
		}

		public UniTask<bool> SwapAvatarCrate(string barcode, bool cache = false, Action<bool> callback = default(Action<bool>))
		{
			return default(UniTask<bool>);
		}

		public void SwapAvatar(SLZ.VRMK.Avatar newAvatar)
		{
		}

		private bool SwitchAvatar(SLZ.VRMK.Avatar newAvatar)
		{
			return default(bool);
		}

		public void TeleportEvent(Transform trans)
		{
		}

		public bool Teleport(Vector3 feetDestinationWorld, bool zeroVelocity = true)
		{
			return default(bool);
		}

		public bool Teleport(Vector3 feetDestinationWorld, Vector3 fwdSnap, bool zeroVelocity = true)
		{
			return default(bool);
		}

		public bool QueueTeleport(Transform destination)
		{
			return default(bool);
		}

		public void ReturnToHome()
		{
		}

		public void SetHome(Vector3 newHomeWorld)
		{
		}

		public bool LeashPlayerCircle(Vector3 positionWorld, float minRadius, float maxRadius)
		{
			return default(bool);
		}

		public Vector3 UpdateLeashCircle(Vector3 headDelta)
		{
			return default(Vector3);
		}

		public Vector2 UpdateLeashCircle(Vector2 headDelta)
		{
			return default(Vector2);
		}

		public void UnleashPlayer()
		{
		}

		public RigManager()
			: base()
		{
		}
	}
}
