using System;
using UnityEngine;

namespace PuppetMasta
{
	[CreateAssetMenu(fileName = "Base Enemy Config", menuName = "StressLevelZero/Base Enemy Config", order = 1)]
	public class BaseEnemyConfig : ScriptableObject
	{
		[Serializable]
		public class SensorSettings
		{
			[Header("Vision")]
			public LayerMask blockVisionRaycast;

			public float visionFov;

			public SensorSettings()
				: base()
			{
			}
		}

		[Serializable]
		public class HealthSettings
		{
			[Header("Health")]
			public float maxHitPoints;

			public float maxAppendageHp;

			public float stunRecovery;

			public float maxStunSeconds;

			public float minHeadImpact;

			public float minSpineImpact;

			public float minLimbImpact;

			[Range(0f, 1f)]
			[Header("Disposition")]
			public float aggression;

			[Range(0f, 10f)]
			public float irritability;

			[Range(0f, 10f)]
			public float placability;

			[Range(0f, 10f)]
			public float vengefulness;

			public HealthSettings()
				: base()
			{
			}
		}

		public enum MentalState
		{
			Rest = 0,
			Roam = 1,
			Investigate = 2,
			Agroed = 3,
			Engaged = 4
		}

		public enum LocoState
		{
			Standing = 0,
			Walking = 1,
			Fallen = 2,
			GetUp = 3,
			Jumping = 4,
			InAir = 5
		}

		public PuppetMaster.State puppetState;

		[Range(0f, 16f)]
		[Header("Resting State")]
		public float restingRange;

		public bool freezeWhileResting;

		public bool homeIsPost;

		[Header("Roam State")]
		[Range(1f, 16f)]
		public float activeRange;

		public float roamSpeed;

		public Vector2 roamRange;

		public float roamAngSpeed;

		[Range(0f, 1f)]
		public float roamFrequency;

		public bool roamWanders;

		[Header("Investigate State")]
		[Range(4f, 16f)]
		public float investigateRange;

		[Header("Agro State General")]
		public float breakAgroTargetDistance;

		public float breakAgroHomeDistance;

		public float agroedSpeed;

		public float agroedAngSpeed;

		public LayerMask meleeAttackMask;

		public bool enableThrowAttack;

		public float throwMaxRange;

		public float throwMinRange;

		public float throwCooldown;

		public float throwVelocity;

		public float gunRange;

		public float gunCooldown;

		[Range(0f, 10f)]
		public float accuracy;

		public float reloadTime;

		[Range(1f, 60f)]
		public int clipSize;

		[Range(1f, 20f)]
		public int burstSize;

		public float desiredGunDistance;

		[ColorUsage(true, true)]
		public Color baseColor;

		[ColorUsage(true, true)]
		public Color agroColor;

		public float fwdThresh;

		public bool forcePath;

		public SensorSettings sensorSettings;

		public HealthSettings healthSettings;

		public SubBehaviourHealth.UsageSettings restingUsage;

		public SubBehaviourHealth.UsageSettings roamUsage;

		public SubBehaviourHealth.UsageSettings investigateUsage;

		public SubBehaviourHealth.UsageSettings engagedUsage;

		public SubBehaviourHealth.UsageSettings agroedUsage;

		public BehaviourBaseNav.MentalState mentalState;

		public BehaviourBaseNav.LocoState locoState;

		public void ApplyTo(BehaviourBaseNav b)
		{
		}

		public BaseEnemyConfig()
			: base()
		{
		}
	}
}
