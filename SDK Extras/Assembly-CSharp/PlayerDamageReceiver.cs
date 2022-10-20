using System;
using SLZ.Combat;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerDamageReceiver : MonoBehaviour, IAttackReceiver, IEventSystemHandler
{
	[Flags]
	public enum BodyPart
	{
		Head = 1,
		Chest = 2,
		Pelvis = 4,
		LeftArm = 8,
		LeftLeg = 0x10,
		RightArm = 0x20,
		RightLeg = 0x40
	}

	private static ComponentCache<PlayerDamageReceiver> _cache;

	public BodyPart bodyPart;

	[HideInInspector]
	public Health health;

	public static ComponentCache<PlayerDamageReceiver> Cache
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void ReceiveAttack(Attack attack)
	{
	}

	public PlayerDamageReceiver()
		: base()
	{
	}
}
