using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Utilities
{
	public class CraneControlBox : MonoBehaviour
	{
		public GameObject lineRenderers;

		public JoystickForwarder joystick;

		public Control_PowerLever zControls;

		public ButtonToggle button;

		public Powerable_Joint[] craneSegments;

		public Powerable[] craneGantry;

		public Material craneLightOn;

		public Material craneLightOff;

		public GameObject[] lightMeshes;

		public List<Renderer> lightRenderers;

		private IEnumerator coroutine;

		public bool isPowered;

		private bool craneDeactivating;

		private void Start()
		{
		}

		public void DeactivateCrane()
		{
		}

		private IEnumerator Deactivation()
		{
			return null;
		}

		public void ActivateCrane()
		{
		}

		private void Activation()
		{
		}

		public CraneControlBox()
			: base()
		{
		}
	}
}
