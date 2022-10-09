using System.Runtime.CompilerServices;
using SLZ;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Props.Weapons;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class Control_MonoMat : Powerable
{
	[SerializeField]
	private Rigidbody[] _loots;

	[SerializeField]
	private Control_PowerLever _doorLever;

	[SerializeField]
	private Powerable _doorMotor;

	[SerializeField]
	private int _multiplier;

	[SerializeField]
	private int _itemPrice;

	[SerializeField]
	private int _smallBullets;

	[SerializeField]
	private int _mediumBullets;

	[SerializeField]
	private bool _opened;

	[SerializeField]
	private bool _unlocked;

	[SerializeField]
	private TextMeshProUGUI _bulletBalanceTextmesh;

	[SerializeField]
	private TextMeshProUGUI _refundTextmesh;

	[SerializeField]
	private AmmoReciever reciever;

	[SerializeField]
	private Spawnable lightRefundSpawnable;

	[SerializeField]
	private Spawnable mediumRefundSpawnable;

	[SerializeField]
	private AudioClip _openedClip;

	[SerializeField]
	private AudioClip _unlockedClip;

	[SerializeField]
	private AudioClip _lockedClip;

	[SerializeField]
	private AudioMixerGroup _mixergroup;

	public Transform giveChangeTransform;

	private void Start()
	{
	}

	public void GiveChange()
	{
	}

	public void InsertMagazine(Magazine magazine)
	{
	}

	public void AddBullets(int addedBullets, bool isSmall = true)
	{
	}

	public Rigidbody[] GetLoots()
	{
		return null;
	}

	public void SetPrice(int price, int mult)
	{
	}

	public void SetLoots(Rigidbody[] loots)
	{
	}

	public Control_MonoMat()
		: base()
	{
	}
}
