using System;
using System.Collections.Generic;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	[DisallowMultipleComponent]
	public class BoxGrip : TargetGrip
	{
		private class GrabConfiguration
		{
			public bool isZoneValid;

			public bool isSandwich;

			public bool isFace;

			public Faces face;

			public bool isEdge;

			public Edges edge;

			public bool isCorner;

			public Corners corner;

			public float sqrDistanceFromSurface;

			public Vector3 normal;

			public Vector3 localPosition;

			public Quaternion localRotation;

			public GrabConfiguration()
				: base()
			{
			}
		}

		[Flags]
		public enum Faces
		{
			PositiveX = 1,
			NegativeX = 2,
			PositiveY = 4,
			NegativeY = 8,
			PositiveZ = 0x10,
			NegativeZ = 0x20
		}

		[Flags]
		public enum Edges
		{
			PositiveXPositiveY = 1,
			NegativeXPositiveY = 2,
			PositiveXNegativeY = 4,
			NegativeXNegativeY = 8,
			PositiveXPositiveZ = 0x10,
			NegativeXPositiveZ = 0x20,
			PositiveXNegativeZ = 0x40,
			NegativeXNegativeZ = 0x80,
			PositiveYPositiveZ = 0x100,
			NegativeYPositiveZ = 0x200,
			PositiveYNegativeZ = 0x400,
			NegativeYNegativeZ = 0x800
		}

		[Flags]
		public enum Corners
		{
			PositiveXPositiveYPositiveZ = 1,
			NegativeXPositiveYPositiveZ = 2,
			PositiveXNegativeYPositiveZ = 4,
			NegativeXNegativeYPositiveZ = 8,
			PositiveXPositiveYNegativeZ = 0x10,
			NegativeXPositiveYNegativeZ = 0x20,
			PositiveXNegativeYNegativeZ = 0x40,
			NegativeXNegativeYNegativeZ = 0x80
		}

		private struct HandToBoxGripState
		{
			public float radius;

			public HandPose handPose;

			public float minBreakForce;

			public float maxBreakForce;
		}

		[Header("BoxGrip Options")]
		public float sandwitchSize;

		public float edgePadding;

		public float faceInsetdistance;

		public float faceDepth;

		public HandPose sandwichHandPose;

		public bool canBeSandwichedGrabbed;

		public float sandwhichMinBreakForce;

		public float sandwhichMaxBreakForce;

		public HandPose edgeHandPose;

		public float edgeHandPoseRadius;

		public bool canBeEdgeGrabbed;

		public float edgeMinBreakForce;

		public float edgeMaxBreakForce;

		public HandPose cornerHandPose;

		public float cornerHandPoseRadius;

		public bool canBeCornerGrabbed;

		public float cornerMinBreakForce;

		public float cornerMaxBreakForce;

		public HandPose faceHandPose;

		public float faceHandPoseRadius;

		public bool canBeFaceGrabbed;

		public float faceMinBreakForce;

		public float faceMaxBreakForce;

		private Dictionary<Hand, GrabConfiguration> _grabConfig;

		[EnumFlags]
		[SerializeField]
		[Header("BoxGrip Face Options")]
		public Faces enabledFaces;

		[SerializeField]
		[EnumFlags]
		public Edges enabledEdges;

		[SerializeField]
		[EnumFlags]
		public Corners enabledCorners;

		[SerializeField]
		[Tooltip("Defines the primary face for force grab orentation")]
		private Faces forceGrabFace;

		[Tooltip("Defines the secondary face for force grab orentation")]
		[SerializeField]
		private Faces forceGrabTop;

		[SerializeField]
		[Header("References")]
		public BoxCollider _boxCollider;

		private Dictionary<Hand, HandToBoxGripState> boxHandStates;

		private float _45DegSin;

		private Vector3 _boxCenter;

		private Vector3 _boxSize;

		private Vector3 _boxExtents;

		protected override void Awake()
		{
		}

		private float GetDistanceBetweenFace(Faces face)
		{
			return default(float);
		}

		private Vector3 FaceToVector(Faces face)
		{
			return default(Vector3);
		}

		public override SimpleTransform GetForcePullTransform(Hand hand)
		{
			return default(SimpleTransform);
		}

		public void UpdateForcePullTransform(Hand hand)
		{
		}

		public float GetEdgePadding()
		{
			return default(float);
		}

		public override void OnFarHandHoverBegin(Hand hand)
		{
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
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

		public override float ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return default(float);
		}

		private void OnDrawGizmosSelected()
		{
		}

		public bool CheckZones(Hand hand)
		{
			return default(bool);
		}

		public BoxGrip()
			: base()
		{
		}
	}
}
