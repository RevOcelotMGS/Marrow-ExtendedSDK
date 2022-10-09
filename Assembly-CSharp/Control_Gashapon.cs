using System.Runtime.CompilerServices;
using SLZ;
using SLZ.Data.SaveData;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Props.Weapons;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class Control_Gashapon : MonoBehaviour
{
	public Servo servo;

	public Rigidbody leverRigidBody;

	public ConfigurableJoint leverConfigurableJoint;

	[SerializeField]
	private int _itemPrice;

	[SerializeField]
	private int _lightBullets;

	[SerializeField]
	private int _mediumBullets;

	[SerializeField]
	private int _heavyBullets;

	[SerializeField]
	private bool _opened;

	[SerializeField]
	private bool _unlocked;

	[SerializeField]
	private TextMeshPro _bulletBalanceTextmesh;

	[SerializeField]
	private TextMeshPro _refundTextmesh;

	[SerializeField]
	private AmmoReciever reciever;

	[SerializeField]
	private Spawnable gachaSpawnable;

	[SerializeField]
	private Spawnable lightRefundSpawnable;

	[SerializeField]
	private Spawnable mediumRefundSpawnable;

	[SerializeField]
	private Spawnable heavyRefundSpawnable;

	[SerializeField]
	private AudioClip despenceClip;

	[SerializeField]
	private AudioClip emptyClip;

	[SerializeField]
	private AudioClip lowFundsClip;

	[SerializeField]
	private AudioMixerGroup _mixergroup;

	public Transform giveChangeTransform;

	public Transform gachaSpawnTransform;

	private bool leverCycle;

	private static PlayerUnlocks u
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void CheckLever()
	{
	}

	public void GiveChange()
	{
	}

	public void InsertMagazine(Magazine magazine)
	{
	}

	public void AddBullets(int addedBullets, int type)
	{
	}

	public void CheckGacha()
	{
	}

	private void SpawnGacha(string barcode)
	{
	}

	public Control_Gashapon()
		: base()
	{
	}
}
