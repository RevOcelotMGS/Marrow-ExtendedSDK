using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.UI
{
	public class ProgressBar : MonoBehaviour
	{
		public RectTransform barTransform;

		public Gradient gradient;

		public Image img_percentBar;

		public Vector2 remapBar;

		private float _cur_completed;

		private float _tempCompleted;

		private bool _coroutineRunning;

		public float cur_completed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		public void DISPLAYFX()
		{
		}

		private IEnumerator FadeFX()
		{
			return null;
		}

		private void SendFX(float _targetVal = 0f)
		{
		}

		public ProgressBar()
			: base()
		{
		}
	}
}
