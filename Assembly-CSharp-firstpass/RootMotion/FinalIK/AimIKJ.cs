using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK Jobs/Aim IKJ")]
	[RequireComponent(typeof(Animator))]
	public class AimIKJ : MonoBehaviour
	{
		[Tooltip("The target Transform of this solver.")]
		public Transform target;

		[Tooltip("Optional secondary target for another axis of the 'Aim Transform'. Needs 'Pole Weight' to be greater than 0 to have any effect.")]
		public Transform poleTarget;

		[Tooltip("The transform that you want to be aimed at the target. Needs to be a lineal descendant of the bone hierarchy. For example, if you wish to aim a gun, it should be the gun, one of it's children or the hand bone.")]
		public Transform aimTransform;

		[Space(5f)]
		[Tooltip("The X value of the local axis of the 'Aim Transform' that you want to be aimed at IKPosition.")]
		public float axisX;

		[Tooltip("The Y value of the local axis of the 'Aim Transform' that you want to be aimed at IKPosition.")]
		public float axisY;

		[Tooltip("The Z value of the local axis of the 'Aim Transform' that you want to be aimed at IKPosition.")]
		public float axisZ;

		[Space(5f)]
		[Tooltip("The X value of the local axis of the 'Aim Transform' that you want oriented towards the 'Pole Target'.")]
		public float poleAxisX;

		[Tooltip("The Y value of the local axis of the 'Aim Transform' that you want oriented towards the 'Pole Target'.")]
		public float poleAxisY;

		[Tooltip("The Z value of the local axis of the 'Aim Transform' that you want oriented towards the 'Pole Target'.")]
		public float poleAxisZ;

		[Range(0f, 1f)]
		[Space(5f)]
		[Tooltip("The master weight of this solver.")]
		public float weight;

		[Tooltip("The weight of the 'Pole Target'")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Tooltip("Minimum angular offset from last reached angle. Will stop solving if offset is less than tolerance.If tolerance is zero, will iterate until maxIterations.")]
		public float tolerance;

		[Tooltip("Max solver iterations per frame. If target position offset is less than 'Tolerance', will stop solving.")]
		public int maxIterations;

		[Tooltip("Clamping rotation of the solver. 0 is free rotation, 1 is completely clamped to animated rotation.")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Tooltip("Number of sine smoothing iterations applied on clamping to make the clamping point smoother.")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Tooltip("If true, rotation limits (if existing) will be applied on each iteration. Only RotationLimitAngle and RotationLimitHinge can be used with this solver.")]
		public bool useRotationLimits;

		[Tooltip("Useful for 2D games. If true, will solve only in the XY plane.")]
		public bool XY;

		[Tooltip("The list of bones used by the solver. Must be assigned in order of hierarchy. All bones must be in the same hierarchy branch.")]
		[Space(5f)]
		public Transform[] bones;

		private Animator animator;

		private PlayableGraph graph;

		private AnimationScriptPlayable IKPlayable;

		private AimIKJob job;

		public bool initiated { get; private set; }

		public Vector3 axis
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 poleAxis
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		public AimIKJ()
			: base()
		{
		}
	}
}
