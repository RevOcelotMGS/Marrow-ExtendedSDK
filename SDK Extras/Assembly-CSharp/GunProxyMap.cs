using System;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Props.Weapons;
using UnityEngine;
using UnityEngine.Audio;

public class GunProxyMap : MonoBehaviour
{
	private enum GunType
	{
		HANDGUN = 0,
		RIFLE = 1
	}

	[Serializable]
	private class GunSounds
	{
		public AudioClip[] fire;

		public AudioClip[] dryFire;

		public AudioClip[] grab;

		public AudioClip[] slidePull;

		public AudioClip[] slideRelease;

		public AudioClip[] magazineInsert;

		public AudioClip[] magazineEject;

		public GunSounds()
			: base()
		{
		}
	}

	[Header("Fire Values")]
	[SerializeField]
	private GunType gunType;

	[SerializeField]
	private float roundsPerMinute;

	[SerializeField]
	private float muzzleVelocity;

	[SerializeField]
	private Gun.FireMode fireMode;

	[SerializeField]
	private CartridgeData defaultCartridge;

	[SerializeField]
	private MagazineData defaultMagazine;

	[Header("Gun References")]
	[SerializeField]
	private MeshRenderer chargingHandleHelper;

	[SerializeField]
	private MeshRenderer magazineHelper;

	[SerializeField]
	private Grip triggerGrip;

	[SerializeField]
	private Grip[] otherGrips;

	[SerializeField]
	private Grip[] slideGrips;

	[SerializeField]
	private GunSounds gunSounds;

	[SerializeField]
	private Spawnable muzzleFlareSpawnable;

	[SerializeField]
	private Transform firePoint;

	[SerializeField]
	private Transform shoulderPoint;

	[SerializeField]
	private Transform holsterPoint;

	[SerializeField]
	private Transform magInsertStart;

	[SerializeField]
	private Transform magInsertEnd;

	[SerializeField]
	private Grip magProxyGrip;

	[Tooltip("X forward for ejection")]
	[SerializeField]
	private Transform shellSpawn;

	[SerializeField]
	private GameObject chamberedCartridge;

	[SerializeField]
	private GameObject nextCartridge;

	[Header("Temp Vars to be Automated Later")]
	[SerializeField]
	private CurveData fireCurve;

	[SerializeField]
	private CurveData returnCurve;

	[SerializeField]
	private AudioMixerGroup shotMixer;

	[SerializeField]
	private AudioMixerGroup grabMixer;

	private InteractableHost host;

	private void Start()
	{
	}

	private void MapGun()
	{
	}

	private void SetVCSettings(VirtualControllerOverride virtualController, float lookRotWeight, float handTwistWeight, float handSwingWeight, float posWeight, float jointSwingLimit, float jointTwistLimit)
	{
	}

	public GunProxyMap()
		: base()
	{
	}
}
