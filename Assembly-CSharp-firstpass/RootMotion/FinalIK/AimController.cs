using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class AimController : MonoBehaviour
	{
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Range(0f, 1f)]
		[Tooltip("Master weight of the IK solver.")]
		public float weight;

		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target;

		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
		public bool smoothTurnTowardsTarget;

		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Range(0f, 180f)]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		public float maxRootAngle;

		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Header("Mode")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		public bool useAnimatedAimDirection;

		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		private Transform lastTarget;

		private float switchWeight;

		private float switchWeightV;

		private float weightV;

		private Vector3 lastPosition;

		private Vector3 dir;

		private bool lastSmoothTowardsTarget;

		private bool turningToTarget;

		private float turnToTargetMlp;

		private float turnToTargetMlpV;

		private Vector3 pivot
		{
			get
			{
				return default(Vector3);
			}
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void ApplyMinDistance()
		{
		}

		private void RootRotation()
		{
		}

		private IEnumerator TurnToTarget()
		{
			return null;
		}

		public AimController()
			: base()
		{
		}
	}
}
