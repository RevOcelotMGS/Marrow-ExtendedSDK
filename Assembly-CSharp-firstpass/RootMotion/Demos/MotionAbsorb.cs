using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		public enum Mode
		{
			Position = 0,
			PositionOffset = 1
		}

		[Serializable]
		public class Absorber
		{
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			private Vector3 position;

			private Quaternion rotation;

			private IKEffector e;

			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			public void UpdateEffectorWeights(float w)
			{
			}

			public void SetPosition(float w)
			{
			}

			public void SetRotation(float w)
			{
			}

			public Absorber()
				: base()
			{
			}
		}

		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		private float timer;

		private float w;

		private Mode initialMode;

		protected override void Start()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		protected override void OnModifyOffset()
		{
		}

		private void AfterIK()
		{
		}

		protected override void OnDestroy()
		{
		}

		public MotionAbsorb()
			: base()
		{
		}
	}
}
