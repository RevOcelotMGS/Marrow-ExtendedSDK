using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		public abstract class Offset
		{
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			private float length;

			private float crossFadeSpeed;

			private float lastTime;

			protected float crossFader { get; private set; }

			protected float timer { get; private set; }

			protected Vector3 force { get; private set; }

			protected Vector3 point { get; private set; }

			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			protected abstract float GetLength(AnimationCurve[] curves);

			protected abstract void CrossFadeStart();

			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			public Offset()
				: base()
			{
			}
		}

		[Serializable]
		public class PositionOffset : Offset
		{
			[Serializable]
			public class PositionOffsetLink
			{
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				private Vector3 lastValue;

				private Vector3 current;

				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				public void CrossFadeStart()
				{
				}

				public PositionOffsetLink()
					: base()
				{
				}
			}

			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			protected override void CrossFadeStart()
			{
			}

			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			public PositionOffset()
				: base()
			{
			}
		}

		[Serializable]
		public class RotationOffset : Offset
		{
			[Serializable]
			public class RotationOffsetLink
			{
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				private Quaternion lastValue;

				private Quaternion current;

				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				public void CrossFadeStart()
				{
				}

				public RotationOffsetLink()
					: base()
				{
				}
			}

			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			private Rigidbody rigidbody;

			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			protected override void CrossFadeStart()
			{
			}

			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			public RotationOffset()
				: base()
			{
			}
		}

		public AnimationCurve[] offsetCurves;

		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		protected override void OnModifyOffset()
		{
		}

		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		public HitReactionVRIK()
			: base()
		{
		}
	}
}
