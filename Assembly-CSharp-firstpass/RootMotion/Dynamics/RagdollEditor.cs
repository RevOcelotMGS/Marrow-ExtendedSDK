using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Ragdoll Editor")]
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		public enum Mode
		{
			Colliders = 0,
			Joints = 1
		}

		[HideInInspector]
		public Rigidbody selectedRigidbody;

		[HideInInspector]
		public Collider selectedCollider;

		[HideInInspector]
		public bool symmetry;

		[HideInInspector]
		public Mode mode;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		public RagdollEditor()
			: base()
		{
		}
	}
}
