using System;
using System.Collections.Generic;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class BarrelGrip : TargetGrip
	{
		private class GrabConfiguration
		{
			public bool isZoneValid;

			public bool isSandwich;

			public bool isSideGrab;

			public bool isEdgeGrab;

			public bool isRingGrab;

			public bool isCapGrab;

			public float sqrDistanceFromSurface;

			public Vector3 normal;

			public Vector3 localPosition;

			public Quaternion localRotation;

			public GrabConfiguration()
				: base()
			{
			}
		}

		private struct HandToBarrelGripState
		{
			public float radius;

			public HandPose handPose;

			public float minBreakForce;

			public float maxBreakForce;
		}

		[Flags]
		public enum Caps
		{
			PositiveCap = 1,
			NegativeCap = 2
		}

		[SerializeField]
		[Header("Barrel Grip")]
		private CapsuleCollider _capsuleCollider;

		public float ringThickness;

		public HandPose ringHandPose;

		public float ringMinBreakForce;

		public float ringMaxBreakForce;

		public HandPose sideHandPose;

		public float sideMinBreakForce;

		public float sideMaxBreakForce;

		public HandPose edgeHandPose;

		public float edgeMinBreakForce;

		public float edgeMaxBreakForce;

		public HandPose capHandPose;

		public float capMinBreakForce;

		public float capMaxBreakForce;

		public bool isCurveOverride;

		public AnimationCurve heightAndRadiusCurve;

		private static float _grabDistance;

		private static float _maxCapHeight;

		private Dictionary<Hand, GrabConfiguration> _grabConfig;

		private Dictionary<Hand, HandToBarrelGripState> barrelHandStates;

		[SerializeField]
		[EnumFlags]
		public Caps enabledCaps;

		private static float _ringPadding;

		public CapsuleCollider CapsuleCollider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		public void UpdateForcePullTransform(Hand hand)
		{
		}

		public override float ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return default(float);
		}

		public override bool OnHandHoverUpdate(Hand hand, bool isOverride)
		{
			return default(bool);
		}

		public override void OnHandAttachedUpdate(Hand hand)
		{
		}

		protected override void UpdateJointConfiguration(Hand hand)
		{
		}

		public bool CheckZones(Hand hand)
		{
			return default(bool);
		}

		public BarrelGrip()
			: base()
		{
		}
	}
}
