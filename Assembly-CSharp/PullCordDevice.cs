using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using SLZ.UI.Radial;
using SLZ.Utilities;
using SLZ.VRMK;
using UnityEngine;
using UnityEngine.Audio;

public class PullCordDevice : MonoBehaviour
{
	private static ComponentCache<PullCordDevice> _cache;

	public PullCordHandle pch;

	public AvatarsPanelView apv;

	[Header("Joint Stuff")]
	public ConfigurableJoint ballJoint;

	private ConfigurableJoint worldJoint;

	private Rigidbody ballRb;

	private HandJointConfiguration savedHandJointConfiguration;

	public Transform ballStartTrans;

	private SimpleTransform initialBallTransform;

	public InteractableHost ballHost;

	[Header("Grips")]
	public Grip ballGrip;

	public Collider ballGripCollider;

	public Collider ballGripCollider2;

	[Header("References")]
	public GameObject ballArt;

	public GameObject fxLineGroup;

	public GameObject ballLine;

	public LineRenderer lineRenderer;

	public GameObject[] tickLines;

	public GameObject[] dialGlyphs;

	[Header("VFX")]
	public ParticleSystem coreVFX;

	public ParticleSystem coreBlastVFX;

	public ParticleSystem blastVFX;

	public ParticleSystem miniBlastVFX;

	public Spawnable avatarBlaster;

	[Range(0f, 1f)]
	[SerializeField]
	[Header("Audio")]
	private float incrementVolume;

	[SerializeField]
	private AudioClip[] incrementOutTick;

	[SerializeField]
	private AudioClip[] incrementInTick;

	[SerializeField]
	[Range(0f, 1f)]
	private float gripVolume;

	[SerializeField]
	private AudioClip[] gripGrab;

	[SerializeField]
	private AudioClip[] gripRelease;

	[SerializeField]
	[Range(0f, 1f)]
	private float activateVolume;

	[SerializeField]
	private AudioClip[] activateBodyLog;

	[SerializeField]
	[Range(0f, 1f)]
	private float glyphVolume;

	[SerializeField]
	private AudioClip[] glyphActive;

	[SerializeField]
	[Range(0f, 1f)]
	private float lockVolume;

	[SerializeField]
	private AudioClip[] lockBodyLog;

	[SerializeField]
	[Range(0f, 1f)]
	private float switchVolume;

	[SerializeField]
	private AudioClip[] switchAvatar;

	[SerializeField]
	[Range(0f, 1f)]
	private float addAvatarVolume;

	[SerializeField]
	private AudioClip[] addAvatar;

	[SerializeField]
	[Range(0f, 1f)]
	private float retractVolume;

	[SerializeField]
	private AudioClip[] retractShort;

	[SerializeField]
	private AudioClip[] retractLong;

	[SerializeField]
	private AudioMixerGroup mixerGroup;

	private AudioPlayer ap0;

	private AudioPlayer ap1;

	private AudioPlayer ap2;

	private AudioPlayer ap3;

	private AudioPlayer ap4;

	[Header("Haptics")]
	public int hapticsPerIncrement;

	[Range(0f, 1f)]
	[SerializeField]
	private float incrementAmplitudeMin;

	[SerializeField]
	[Range(0f, 1f)]
	private float incrementAmplitudeMax;

	[SerializeField]
	[Range(0f, 2000f)]
	private float incrementFrequencyMin;

	[Range(0f, 2000f)]
	[SerializeField]
	private float incrementFrequencyMax;

	[SerializeField]
	[Range(0f, 1f)]
	private float incrementDurationMin;

	[SerializeField]
	[Range(0f, 1f)]
	private float incrementDurationMax;

	[Header("Avatars")]
	public AvatarCrateReference[] avatarCrateRefs;

	[Header("Preview Hologram")]
	public Transform preivewMeshRoot;

	public Transform previewMeshPosition;

	public Transform previewMeshSpin;

	public Transform previewMeshRock;

	public MeshFilter previewBounds;

	public MeshFilter previewMesh;

	public MeshRenderer previewMeshRenderer;

	public Transform previewPoint;

	public float previewMeshScaleTune;

	public float previewMeshSpinSpeed;

	public float previewMeshSpinAmp;

	public float previewMeshRockSpeed;

	public float previewMeshRockAmp;

	[Header("General Settings")]
	public bool lookMode;

	public bool leftHanded;

	[Range(-1f, 1f)]
	public float lookDot;

	[Range(0.05f, 1f)]
	public float handShowDist;

	public float armLengthMultiplier;

	public AnimationCurve hologramScaleCurve;

	public AnimationCurve hologramShaderCurve;

	public float hologramAnimLength;

	public Vector3 hologramAnimDisplacement;

	[Range(0f, 1f)]
	public float retractSpeed;

	[Header("Joint Settings")]
	public Vector3 jointLimitMin;

	public Vector3 jointLimitMax;

	public Vector3 jointMinDrive;

	public Vector3 jointMaxDrive;

	public Vector3 jointReturnDrive;

	public AnimationCurve jointDetentCurve;

	[Header("Avatar Add Setting")]
	public AnimationCurve addAvatarCurve;

	public AnimationCurve addAvatarOffCurve;

	public AnimationCurve addAvatarFlickerCurve;

	public RigManager rm;

	public BodyVitals bv;

	public bool isHandleInReceiver;

	public bool isBallInReceiver;

	public Transform receiverTransform;

	public bool bodyLogFirstUse;

	private SlotContainer _slotContainer;

	private bool _bodyLogEnabled;

	private bool ballShown;

	private bool ballHeld;

	private float dist;

	private float remap;

	private float detent;

	private float resistance;

	private float subRemap;

	private float subDetent;

	private int avatarIndex;

	private int lastAvatarIndex;

	private int detentIndex;

	private int lastDetentIndex;

	private JointDrive drive;

	private Vector3 jointDriverTarget;

	private SoftJointLimit jointLimit;

	private Vector3 deviceScale;

	private bool hasIncrementedDetent;

	private bool hasIncrementedSegment;

	private IEnumerator anchorCoroutine;

	private bool anchorLerp;

	private float cashedResistance;

	private int lastTickNumber;

	private float lastDist;

	private Vector3 jointDriver;

	private Vector3 driveVel;

	private IEnumerator hologramCoroutine;

	private float scanLineSize;

	private float depthFade;

	private Color hologramTint;

	private float spinTime;

	private float rockTime;

	private SpawnableCrate[] previewMeshCrates;

	private static readonly int EmissionColor;

	private static readonly int DepthFader;

	private static readonly int ScanlineSize;

	private Transform cameraRef;

	private float ballMass;

	private IEnumerator ballRetraction;

	private bool canShowBall;

	private IEnumerator addAnimation;

	private SpawnableCrate avatarAddPreviewMeshCrate;

	private Vector3 avatarAddLocation;

	private IEnumerator avatarTransformationSequence;

	private List<string> defaultFavoriteAvatarsBarcodes;

	public static ComponentCache<PullCordDevice> Cache
	{
		get
		{
			return null;
		}
	}

	public bool bodyLogEnabled
	{
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void SetBodySegment()
	{
	}

	private void Update()
	{
	}

	private void OnBallGripAttached(Hand hand)
	{
	}

	private void OnBallGripDetached(Hand hand)
	{
	}

	private void OnBallGripUpdate(Hand hand)
	{
	}

	private void PlayClip(AudioClip[] clip, AudioPlayer ap, float volume, float minDistance = 1f, bool varyPitch = false)
	{
	}

	public void BodyVitalsUpdateEvent()
	{
	}

	private void StartAvatarUpdateEvent()
	{
	}

	private IEnumerator AvatarUpdateEvent()
	{
		return null;
	}

	private IEnumerator HologramAnimation()
	{
		return null;
	}

	public void ForceAvatarChange(AvatarCrateReference avatarRef, int stopIndex = -1)
	{
	}

	private IEnumerator AvatarTransformationSequence(AvatarCrateReference avatarRef, int stopIndex = -1)
	{
		return null;
	}

	public void AddAvatarToPCD(GachaCapsule gacha)
	{
	}

	private IEnumerator AddAvatarAnimation(GachaCapsule gacha)
	{
		return null;
	}

	public void EnableBall()
	{
	}

	private void DisableBall()
	{
	}

	private void ResetBall()
	{
	}

	private IEnumerator RetractBall()
	{
		return null;
	}

	private void JointToWorld()
	{
	}

	public void BreakWorldJoint()
	{
	}

	public void BreakWorldJointHand()
	{
	}

	private void SetJointDrives(Vector3 settings)
	{
	}

	private void SetJointLimits(Vector3 settings)
	{
	}

	public Vector3 FindNearestPointOnLine(Vector3 origin, Vector3 vector, Vector3 point)
	{
		return default(Vector3);
	}

	private IEnumerator LerpAnchor(float lerpTime)
	{
		return null;
	}

	private void HapticEvent(float driver)
	{
	}

	public void BodyMallUpdate()
	{
	}

	private void LoadFavoriteAvatars()
	{
	}

	private UniTaskVoid UpdateAllPreviewMeshes()
	{
		return default(UniTaskVoid);
	}

	private void SetPreviewMesh(int crateIndex)
	{
	}

	private UniTaskVoid SwapAvatar(AvatarCrateReference avatarCrateRef)
	{
		return default(UniTaskVoid);
	}

	private void PlayAvatarParticleEffects()
	{
	}

	private float GetVolumeSurface(Vector3 size)
	{
		return default(float);
	}

	public PullCordDevice()
		: base()
	{
	}
}
