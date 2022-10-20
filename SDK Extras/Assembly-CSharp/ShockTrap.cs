using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.Events;

public class ShockTrap : MonoBehaviour
{
	public KeyReciever keyReciever;

	[SerializeField]
	private DoorLightControl[] doorLightControls;

	public ObjectiveBattery battery;

	private int minCharge;

	[SerializeField]
	public Spawnable blasterLightning;

	public GameObject[] shockPoints;

	public List<TriggerRefProxy> npcList;

	public List<TriggerRefProxy> deadProxyList;

	public HashSet<TriggerRefProxy> npcProxyHash;

	public GenGameControl_Trigger shockFieldTrigger;

	private Coroutine shockRoutine;

	[SerializeField]
	private GameObject batteryObj;

	[SerializeField]
	private bool isShockReady;

	[SerializeField]
	private int shockCost;

	[Header("Audio")]
	[SerializeField]
	private AudioClip shockClip;

	[SerializeField]
	private AudioClip hitClip;

	[SerializeField]
	private AudioClip denyClip;

	[SerializeField]
	private AudioClip chargeClip;

	[SerializeField]
	private AudioClip fullChargeClip;

	[SerializeField]
	[Header("FX")]
	private GameObject lightningBoltObj;

	[SerializeField]
	private MeshRenderer lightningRend;

	[SerializeField]
	private GameObject lightingHitParticles;

	[SerializeField]
	private GameObject lightingPathParticles;

	[SerializeField]
	private GameObject[] shockPointPartObjs;

	[SerializeField]
	private ParticleSystem[] shockPointParticles;

	public GameObject[] tankScalerObjs;

	private int currTank;

	private Vector3 maxTankScale;

	private Vector3 startBar;

	private Vector3 endBar;

	private float currTankEnergy;

	public GameObject voidHoleObj;

	public float initScaleDuration;

	[SerializeField]
	private DoorLightControl chargeLightControl;

	[SerializeField]
	private GameObject chargeIndicator;

	private Vector3 startScale;

	private Vector3 endScale;

	private Coroutine chargeRoutine;

	public UnityEvent OnBatteryAccepted;

	[SerializeField]
	private NPC_Objective[] chargers;

	[SerializeField]
	private DoorLightControl[] tankLights;

	[SerializeField]
	private AudioSource aSource;

	[SerializeField]
	private GameObject padlockObj;

	private void Start()
	{
	}

	private void OnChargerKeyed(NPC_Objective charger)
	{
	}

	public void KeyRecieved(Key key)
	{
	}

	private void BlinkChargeLight()
	{
	}

	private IEnumerator CoBlinkCharge()
	{
		return null;
	}

	private IEnumerator CoChargeShock()
	{
		return null;
	}

	private void ResetShockCharge()
	{
	}

	public void OnNPCEnter(TriggerRefProxy proxy)
	{
	}

	public void OnNPCExit(TriggerRefProxy proxy)
	{
	}

	private void SetShockReadiness(bool ready)
	{
	}

	public void ToggleShockField()
	{
	}

	private IEnumerator CoShock()
	{
		return null;
	}

	[ContextMenu("ShockTest")]
	public void TestShock()
	{
	}

	public void ToggleShockPointFX()
	{
	}

	public void TargetLightning(Vector3 target)
	{
	}

	private IEnumerator CoLightningFX(Vector3 target)
	{
		return null;
	}

	public void ToggleBattery()
	{
	}

	private void SetTankCompletion()
	{
	}

	private void FillTank(int energy = 100)
	{
	}

	[ContextMenu("OPEN_THE_PORTAL")]
	public void OPEN_THE_PORTAL()
	{
	}

	private IEnumerator CoPortalPlay()
	{
		return null;
	}

	public ShockTrap()
		: base()
	{
	}
}
