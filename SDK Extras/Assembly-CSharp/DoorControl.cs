using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Combat;
using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class DoorControl : MonoBehaviour
{
	[Header("GENERAL")]
	public bool FreeDoor;

	public Vector3 axis_Link;

	public Vector3 axis_LinkSecondary;

	private Rigidbody rb_this;

	private Quaternion rot_initialize;

	private Quaternion offset_JointSpace;

	private bool DoorShut;

	[Space(10f)]
	[Header("DOOR")]
	public bool DoorIndestructible;

	public float health_Door;

	private float cur_health_Door;

	public float DoorDurability;

	[Space(5f)]
	public bool damageFromImpact;

	public float thr_Impact;

	public float mod_Impact;

	[Space(3f)]
	public bool damageFromAttack;

	public float mod_Attack;

	[Space(3f)]
	public int req_hit_count;

	private int cur_hit_count;

	private bool DoorHasShattered;

	[Space(10f)]
	[Header("LOCK")]
	public float[] LockAngleLimits;

	public bool LockIndestructible;

	public bool Lock_Locked;

	public bool Lock_Closed;

	public float health_Lock;

	private float cur_health_Lock;

	public float LockDurability;

	public bool hasKey;

	public GameObject PhysicalLock;

	private bool LockHasShattered;

	[Header("LINK")]
	[Space(10f)]
	public Rigidbody rb_parent;

	private ConfigurableJoint jnt_link;

	public Transform override_Anchor;

	[Space(3f)]
	public bool UsingThresholds;

	public int SpringLoc;

	public float[] SpringAngles;

	public float[] thr_SpringAngle_UP;

	public float[] thr_SpringAngle_DOWN;

	private Vector3 rot_target;

	public float SpringStrength;

	public float SpringDamper;

	public float SpringMaxForce;

	public bool LimitsOn;

	public float LimitMax;

	public float LimitMin;

	private float m_closedLimitMax;

	private float m_closedLimitMin;

	[Header("KNOB")]
	[Space(10f)]
	public bool FlipLatch;

	public GameObject DoorKnob;

	private Rigidbody rb_DoorKnob;

	private ConfigurableJoint jnt_knob;

	private bool KnobLocked;

	[Tooltip("This is the number added to the lowest x-angularThreshold and subtracted from the highest x-angularThreshold")]
	[SerializeField]
	private float KnobThreshOffset;

	public float[] knob_UnlockAngles;

	public float knob_LimitMax;

	public float knob_LimitMin;

	public bool bool_springOpen;

	public int tar_springLoc;

	[Header("REFERENCES")]
	[Space(10f)]
	public AudioClip[] clip_Knock;

	public AudioClip[] clip_DoorDamage;

	public AudioClip[] clip_DoorDestroyed;

	public AudioClip[] clip_Knob;

	[Space(3f)]
	public AudioClip[] clip_Unlock;

	public AudioClip[] clip_LockDestroyed;

	public AudioClip[] clip_IsLocked;

	public AudioClip[] clip_SetLock;

	[Space(5f)]
	public ParticleSystem KnockParticles;

	public ParticleSystem DamageParticles;

	public GameObject fx_LockShatter;

	public GameObject fx_DoorShatter;

	[Space(5f)]
	public DoorLightControl[] DoorLights;

	public OcclusionPortal occlusionPortal;

	private bool playedKnob;

	private bool m_Door_Broken
	{
		get
		{
			return default(bool);
		}
	}

	private bool m_Lock_Broken
	{
		get
		{
			return default(bool);
		}
	}

	private void Start()
	{
	}

	private void SETANGLES()
	{
	}

	private void IgnoreCollisions()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision impact)
	{
	}

	public void ReceiveAttack(Attack attack)
	{
	}

	private void SORTDAMAGE(float damage)
	{
	}

	private void DAMAGEDOOR(float dmg)
	{
	}

	public void SHATTERDOOR()
	{
	}

	private void DAMAGELOCK(float dmg)
	{
	}

	public void BREAKLOCK()
	{
	}

	public void KEYLOCKUNLOCK(bool isLocking)
	{
	}

	public void CloseCrate()
	{
	}

	public void SwingShutAndLock(float time)
	{
	}

	public IEnumerator SwingOverTime(float time = 1f, bool lockOnComplete = false)
	{
		return null;
	}

	private void SETLINK()
	{
	}

	private void ROTTARGET()
	{
	}

	private void SETLIMITS()
	{
	}

	public void CHECKTHRESHOLDS(float cur_angle)
	{
	}

	private void CheckPortal(float cur_angle)
	{
	}

	public void SPRINGTOTARGET()
	{
	}

	public void KNOBLOCK(bool locking = true)
	{
	}

	private void SETKNOBLIMITS(bool fullLimit)
	{
	}

	private void CHECKKNOBTHRESHOLDS()
	{
	}

	private void DOORLIGHTS()
	{
	}

	public void FXKnockDoor(float force, Vector3 pos)
	{
	}

	public void FXDamageDoor(float force, Vector3 pos)
	{
	}

	public void DEFAULTDATA()
	{
	}

	public DoorControl()
		: base()
	{
	}
}
