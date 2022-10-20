using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.VFX
{
	public class FadeMaterials : MonoBehaviour
	{
		private enum Fade
		{
			In = 0,
			Out = 1
		}

		[SerializeField]
		[Range(0f, 5f)]
		private float TimeToFullyFade;

		[SerializeField]
		private string TargetVariable;

		public Renderer[] MaterialsToFade;

		private float currentAlpha;

		private void Start()
		{
		}

		public void FadeIn()
		{
		}

		public void FadeOut()
		{
		}

		private IEnumerator Fader(Fade fadeType)
		{
			return null;
		}

		public FadeMaterials()
			: base()
		{
		}
	}
}
