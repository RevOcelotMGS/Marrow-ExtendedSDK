using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Warehouse;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Props.Weapons
{
	public class SpawnGun : Gun
	{
		[Header("Spawn Options")]
		public LayerMask collisionLayers;

		public float effectiveRange;

		public bool wackySpinWhenUpsideDown;

		public bool isDespawnMode;

		public GameObject laserPointerGameObject;

		public Transform previewMeshPosition;

		public Transform previewMeshSpin;

		public Transform previewMeshRock;

		public MeshFilter previewBounds;

		public MeshFilter previewMesh;

		public Transform previewPoint;

		public float previewMeshScaleTune;

		public float previewMeshSpinSpeed;

		public float previewMeshRockSpeed;

		public float previewMeshRockAmp;

		public float xenCrystalSpinSpeed;

		public Transform fanBladesTransform;

		public Transform xenCrystalTransform;

		public AudioMixerGroup outputMixer;

		public AudioClip[] chargeSFX;

		public AudioClip[] misfireSFX;

		public AudioClip[] modeSFX;

		[ColorUsage(true, true)]
		public Color screenPlacerColor;

		[ColorUsage(true, true)]
		public Color screenRemoveerColor;

		public MeshRenderer[] gunBodyRenderers;

		[ColorUsage(true, true)]
		public Color placerValidColor;

		[ColorUsage(true, true)]
		public Color placerInvalidColor;

		public Transform placerRoot;

		public GameObject placerPreview;

		public GameObject placerPreview2;

		public MeshFilter placerPreviewMesh;

		public MeshFilter placerPreviewMesh2;

		public MeshRenderer placerPreivewRenderer;

		public BoxCollider placerPreviewBoxCollider;

		public GameObject placerPreviewBoundsArt;

		public LineRenderer[] placerPreviewBoundsLines;

		public Transform[] boundPoints;

		public float dampTimePos;

		public float dampTimeRot;

		[Header("Audio")]
		[SerializeField]
		private AudioMixerGroup mixerGroup;

		[SerializeField]
		private AudioClip[] blip;

		public float blipIncrement;

		private float _fanRPS;

		private SpawnableCrate _selectedCrate;

		private SpawnableCrate _lastSelectedCrate;

		private bool _isOptionsActive;

		private UtilityModes _selectedMode;

		private RaycastHit _hitInfo;

		private Hand currentHand;

		private float time;

		private Color startColor;

		private AudioPlayer ap;

		private AudioPlayer ap2;

		private bool canFireGunDown;

		private bool placerValid;

		private float colorLerpTime;

		private float screenColorLerpTime;

		private Color targetColor;

		private Color targetScreenColor;

		private Color boundColor;

		private Vector3 lastKneePos;

		private Vector3 kneeOffsetPos;

		private bool wallMode;

		private Vector3 truePlacePosition;

		private Quaternion truePlaceRotation;

		private Vector3 posVelocity;

		private Vector3 lastHitPoint;

		private float accumulatedDist;

		private static readonly int EmissionColor;

		private static readonly int ColorTint;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnHandAttachedUpdate(Hand hand)
		{
		}

		public void SetFanRPM(float rpm)
		{
		}

		protected override void OnPostSpawn(GameObject go)
		{
		}

		private UniTaskVoid SpawnCrate(Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Action<GameObject> callback = default(Action<GameObject>))
		{
			return default(UniTaskVoid);
		}

		private void OnSpawnHandAttached(Hand hand)
		{
		}

		private void OnSpawnHandDetached(Hand hand)
		{
		}

		public void Flash()
		{
		}

		private IEnumerator CoFireFlash()
		{
			return null;
		}

		protected void OnSpawnableSelected(SpawnableCrate crate)
		{
		}

		protected void OnModeSelect(UtilityModes mode)
		{
		}

		public override void Fire()
		{
		}

		protected override void OnFire()
		{
		}

		protected override void OnTriggerGripAttached(Hand hand)
		{
		}

		protected override void OnTriggerGripDetached(Hand hand)
		{
		}

		private void SetPreviewMesh()
		{
		}

		public Vector3 FindNearestPointOnLine(Vector3 origin, Vector3 vector, Vector3 point)
		{
			return default(Vector3);
		}

		private void PlaySFX(AudioClip[] audioClips, Vector3 position)
		{
		}

		public SpawnGun()
			: base()
		{
		}
	}
}
