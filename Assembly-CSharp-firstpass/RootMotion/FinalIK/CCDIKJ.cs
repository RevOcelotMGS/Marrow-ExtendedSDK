using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace RootMotion.FinalIK
{
	[RequireComponent(typeof(Animator))]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK Jobs/CCD IKJ")]
	public class CCDIKJ : MonoBehaviour
	{
		[Tooltip("The target Transform of this solver.")]
		public Transform target;

		[Range(0f, 1f)]
		[Tooltip("The master weight of this solver.")]
		public float weight;

		[Tooltip("Minimum offset from last reached position. Will stop solving if offset is less than tolerance.If tolerance is zero, will iterate until maxIterations.")]
		public float tolerance;

		[Tooltip("Max solver iterations per frame. If target position offset is less than 'Tolerance', will stop solving.")]
		public int maxIterations;

		[Tooltip("If true, rotation limits (if existing) will be applied on each iteration. Only RotationLimitAngle and RotationLimitHinge can be used with this solver.")]
		public bool useRotationLimits;

		[Tooltip("Useful for 2D games. If true, will solve only in the XY plane.")]
		public bool XY;

		[Tooltip("The list of bones used by the solver. Must be assigned in order of hierarchy. All bones must be in the same hierarchy branch.")]
		public Transform[] bones;

		private Animator animator;

		private PlayableGraph graph;

		private AnimationScriptPlayable IKPlayable;

		private CCDIKJob job;

		public bool initiated { get; private set; }

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		public CCDIKJ()
			: base()
		{
		}
	}
}
