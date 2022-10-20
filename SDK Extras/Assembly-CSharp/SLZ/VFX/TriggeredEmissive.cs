using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.VFX
{
	public class TriggeredEmissive : MonoBehaviour
	{
		[ColorUsage(true, true)]
		public Color startColor;

		[ColorUsage(true, true)]
		public Color endColor;

		public Renderer ren;

		public CurveData curve;

		public float blendTime;

		private int emmisiveID;

		private Color _curColor;

		private Coroutine _endColorCoroutine;

		private void Awake()
		{
		}

		private void BlendColor(Color targetColor)
		{
		}

		public void BlendToStartColor()
		{
		}

		public void BlendToEndColor()
		{
		}

		private IEnumerator CoBlendColor(Color startC, Color endC)
		{
			return null;
		}

		public TriggeredEmissive()
			: base()
		{
		}
	}
}
