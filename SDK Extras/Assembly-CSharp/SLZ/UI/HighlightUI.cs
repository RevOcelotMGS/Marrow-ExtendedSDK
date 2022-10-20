using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.UI
{
	public class HighlightUI : MonoBehaviour
	{
		private static MaterialPropertyBlock m_PropertyBlock;

		private static int m_Color1ID;

		private static int m_Color2ID;

		private Renderer m_Renderer;

		[ColorUsage(true, true)]
		[Header("Options")]
		public Color color1;

		[ColorUsage(true, true)]
		public Color color2;

		private Coroutine fadeToColorsCoroutine;

		private void Awake()
		{
		}

		public void Start()
		{
		}

		public void DisableMesh()
		{
		}

		public void EnableMesh()
		{
		}

		public void SetColors(Color c1, Color c2)
		{
		}

		public void FadeToColors(Color c1, Color c2, float duration)
		{
		}

		public void FadeToColors(Color c1, Color c2)
		{
		}

		private IEnumerator CoFadeToColors(Color c1, Color c2, float duration = 0.15f)
		{
			return null;
		}

		public HighlightUI()
			: base()
		{
		}
	}
}
