using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourArmWorm : BehaviourBaseNav
	{
		public Transform target;

		public GameObject target_GameObject;

		[Header("Arm Settings")]
		public SubBehaviourIk ik;

		public SubBehaviourHandPose handPoser;

		public GameObject throwVfx;

		public bool crumbleDeath;

		public RigidBodyDamageDealer[] dmgDealers;

		private int _armsLayer;

		private int _mSecAnim;

		private int _locoCycleAnim;

		private int _flinchAnim;

		private int _angryAnim;

		private int _awakeAnim;

		private int _unGroundedAnim;

		private int _emissColor;

		private int _attackAnim;

		private int _clipIntAnim;

		private int _gestureAnim;

		private int _deathAnim;

		private float _animationBlendWeight;

		private float _animationBlendWeightV;

		private float _blendToAnimationTime;

		public bool elbow_y_rot_heur;

		public bool wrist_x_rot_heur;

		public bool wrist_y_rot_heur;

		public bool wrist_z_rot_heur;

		public float sin_speed_mod;

		public float sin_range_mod;

		public float elbow_strength;

		public float wrist_strength;

		public float artSlerpDrive;

		public float max_elbow_strength;

		private float adjusted_elbow_strength;

		public float max_wrist_strength;

		private float adjusted_wrist_strength;

		public float[] incomingActions;

		public BehaviourDriveController m_JdController;

		public BoxCollider frictionCollider;

		public PhysicMaterial high_friction;

		public PhysicMaterial low_friction;

		public float last_friction_val;

		public bool actionReady;

		public float hand_impulse_threshold;

		public Action behaviourDead;

		public ObjectPool wayPointPool;

		public BarracudaModelManager modelManager;

		public InferenceAgent agent;

		public GameObject tempWayPoint;

		public MentalState[] start_state_list;

		public int start_state_ind;

		public new void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		public void SetArtTargetRotation(Transform transform, float x, float y, float z, float lowX, float highX, float lowY, float highY, float lowZ, float highZ)
		{
		}

		public void SetBodyPartStrength(float spineStrength, float legStrength)
		{
		}

		public void UpdateFriction(float decision)
		{
		}

		protected static float ScaleAction(float rawAction, float min, float max)
		{
			return default(float);
		}

		private void TakeDelayedAction()
		{
		}

		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		private void SetAgentActive()
		{
		}

		private void SetAgentInactive()
		{
		}

		private void Awake()
		{
		}

		private void SetTarget(Vector3 pos, Quaternion rot, bool updateTrans)
		{
		}

		private void OnApplicationQuit()
		{
		}

		public BehaviourArmWorm()
			: base()
		{
		}

		public event Action OnNewTarget;
	}
}
