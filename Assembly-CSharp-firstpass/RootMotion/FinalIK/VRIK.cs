using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		public class References
		{
			public Transform root;

			public Transform pelvis;

			public Transform spine;

			[Tooltip("Optional")]
			public Transform chest;

			[Tooltip("Optional")]
			public Transform neck;

			public Transform head;

			[Tooltip("Optional")]
			public Transform leftShoulder;

			public Transform leftUpperArm;

			public Transform leftForearm;

			public Transform leftHand;

			[Tooltip("Optional")]
			public Transform rightShoulder;

			public Transform rightUpperArm;

			public Transform rightForearm;

			public Transform rightHand;

			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Tooltip("Optional")]
			public Transform leftToes;

			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Tooltip("Optional")]
			public Transform rightToes;

			public bool isFilled
			{
				get
				{
					return default(bool);
				}
			}

			public bool isEmpty
			{
				get
				{
					return default(bool);
				}
			}

			public Transform[] GetTransforms()
			{
				return null;
			}

			public static bool AutoDetectReferences(Transform root, [Out] References references)
			{
				return default(bool);
			}

			public References()
				: base()
			{
			}
		}

		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public References references;

		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		public override IKSolver GetIKSolver()
		{
			return null;
		}

		protected override void InitiateSolver()
		{
		}

		protected override void UpdateSolver()
		{
		}

		public VRIK()
			: base()
		{
		}
	}
}
