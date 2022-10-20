using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.SFX;
using UnityEngine;

namespace SLZ
{
	public class TurretHeadController : SpawnEvents
	{
		public enum FireType
		{
			Cartridge = 0,
			GachaLauncher = 1
		}

		[Header("Settings")]
		public FireType fireType;

		public float rotationSpeed;

		[Header("References")]
		public Transform firePointTransform;

		public Spawnable muzzleFlareSpawnable;

		public GunSFX gunSfx;

		public Rigidbody rb;

		public ConfigurableJoint joint;

		public Transform pitchArtTransform;

		public Transform yawArtTransform;

		public Transform rollArtTransform;

		[Header("Projectile References")]
		public CartridgeData cartridge;

		[Header("Gacha Launcher Settings")]
		public float launchSpeed;

		public float launchAngularSpeed;

		public Spawnable gachaProjectileSpawnable;

		public Spawnable gachaSpawnable;

		private Quaternion _startRotation;

		private Quaternion _targetRotation;

		private Quaternion _initalTargetRotation;

		private Quaternion _initalRbRotation;

		private Vector3 _initalRbPosition;

		private bool _isReady;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void LookAt(Vector3 worldPos)
		{
		}

		public void Fire()
		{
		}

		private Quaternion GetLocalRotation()
		{
			return default(Quaternion);
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		public TurretHeadController()
			: base()
		{
		}
	}
}
