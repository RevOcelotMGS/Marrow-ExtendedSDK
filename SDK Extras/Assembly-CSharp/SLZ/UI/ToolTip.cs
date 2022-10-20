using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.UI
{
	public class ToolTip : MonoBehaviour
	{
		public float popupTime;

		public float popdownTime;

		public bool isEditorOnly;

		public int numberOfPopups;

		public AudioClip popupClip;

		public AudioClip popdownClip;

		public UnityEvent OnFocus;

		public UnityEvent OnBlur;

		protected Action OnFocusDelegate;

		protected Action OnBlurDelegate;

		private int _popupCount;

		private bool _isPopup;

		private Coroutine _popupCoroutine;

		private Coroutine _hidePopupCoroutine;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnToolFocus()
		{
		}

		public void OnToolBlur()
		{
		}

		private IEnumerator CoShowPopup()
		{
			return null;
		}

		private IEnumerator CoHidePopup()
		{
			return null;
		}

		public ToolTip()
			: base()
		{
		}
	}
}
