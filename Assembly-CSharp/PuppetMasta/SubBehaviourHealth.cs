using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Combat;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourHealth : SubBehaviourBase
	{
		public enum StunGroup
		{
			Spine = 0,
			ArmLf = 1,
			ArmRt = 2,
			LegLf = 3,
			LegRt = 4,
			Head = 5
		}

		public delegate void NPCDamageRecieved(float damageAmount);

		[Serializable]
		public struct UsageSettings
		{
			public float hips;

			public float spine;

			public float legLf;

			public float legRt;

			public float armLf;

			public float armRt;

			public static UsageSettings Default
			{
				get
				{
					return default(UsageSettings);
				}
			}

			public UsageSettings(float hips = 1f, float spine = 1f, float legLf = 1f, float legRt = 1f, float armLf = 1f, float armRt = 1f)
			{
				this.armRt = default(float);
				this.armLf = default(float);
				this.legRt = default(float);
				this.legLf = default(float);
				this.spine = default(float);
				this.hips = default(float);
			}
		}

		[Header("Health")]
		public float maxHitPoints;

		public float maxAppendageHp;

		public float stunRecovery;

		public float maxStunSeconds;

		public float minHeadImpact;

		public float minSpineImpact;

		public float minLimbImpact;

		public bool isOrganic;

		public bool stunActive;

		public float bluntMult;

		public float stabMult;

		public float pierceMult;

		public StunGroup[] muscles;

		[Range(0f, 1f)]
		public float cur_hp;

		[Range(0f, 1f)]
		public float cur_arm_lf;

		[Range(0f, 1f)]
		public float cur_arm_rt;

		[Range(0f, 1f)]
		public float cur_leg_lf;

		[Range(0f, 1f)]
		public float cur_leg_rt;

		public float stun_spine;

		public float stun_arm_lf;

		public float stun_arm_rt;

		public float stun_leg_lf;

		public float stun_leg_rt;

		public float usage_hips;

		public float usage_spine;

		public float usage_arm_lf;

		public float usage_arm_rt;

		public float usage_leg_lf;

		public float usage_leg_rt;

		[Header("Disposition")]
		[Range(0f, 1f)]
		[Tooltip("Current state of agro, will move up and down based on damage received / dealt")]
		public float aggression;

		[Range(0f, 10f)]
		[Tooltip("Nonfunctioning")]
		public float irritability;

		[Range(0f, 10f)]
		[Tooltip("Multiplier, Decreases aggression based on damage dealt")]
		public float placability;

		[Range(0f, 10f)]
		[Tooltip("Multiplier, Increases aggression based on damage received")]
		public float vengefulness;

		[HideInInspector]
		public int damageScore;

		public static Action OnHeadShot;

		public void Initiate(BehaviourBase b)
		{
		}

		public void Resurrect()
		{
		}

		public void Kill()
		{
		}

		public void SetUsage(float hips, float spine = 1f, float legLf = 1f, float legRt = 1f, float armLf = 1f, float armRt = 1f)
		{
		}

		public void SetUsage(UsageSettings s)
		{
		}

		public void UpdateMuscleStates(float footSupported)
		{
		}

		public float Stun(int m, float stun)
		{
			return default(float);
		}

		public float TakeDamage(int m, Attack attack)
		{
			return default(float);
		}

		private void DamageScore(int m, float damage)
		{
		}

		public bool UpdateStun()
		{
			return default(bool);
		}

		public float GetStun(int m, [Out] float health)
		{
			return default(float);
		}

		public SubBehaviourHealth()
			: base()
		{
		}

		public static event NPCDamageRecieved OnNPCDamage;
	}
}
