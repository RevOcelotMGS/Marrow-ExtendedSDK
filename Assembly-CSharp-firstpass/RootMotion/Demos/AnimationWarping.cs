using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		public struct Warp
		{
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		public enum EffectorMode
		{
			PositionOffset = 0,
			Position = 1
		}

		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		private EffectorMode lastMode;

		protected override void Start()
		{
		}

		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		protected override void OnModifyOffset()
		{
		}

		private void OnDisable()
		{
		}

		public AnimationWarping()
			: base()
		{
		}
	}
}
