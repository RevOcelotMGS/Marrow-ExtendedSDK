using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Props.Weapons;
using TMPro;
using UnityEngine;

namespace SLZ.Interaction
{
	public class GunOptionSelect : MonoBehaviour
	{
		private enum SelectOptions
		{
			NONE = 0,
			FIREMODE = 1,
			EJECT = 2
		}

		[Header("Options")]
		public bool displayUI;

		public bool canChangeFiremode;

		public bool canEjectMag;

		public Color uiColor;

		public Color uiHighlightColor;

		[Header("References")]
		public Grip grip;

		public Gun gun;

		public AmmoSocket reciever;

		public GameObject uiBorderObject;

		public GameObject uiCursorObject;

		public GameObject uiEjectText;

		public GameObject uiFireModeText;

		private Material m_UiBorderMat;

		private Material m_UiCursorMat;

		private TextMeshPro m_UiEjectTextMesh;

		private TextMeshPro m_UiFireModeTextMesh;

		private bool m_IsOptionsActive;

		private SelectOptions m_SelectOption;

		private Coroutine m_FireModeColorCoroutine;

		private Coroutine m_EjectColorCoroutine;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public IEnumerator CoFadeToColor(TextMeshPro text, Color targetColor, float duration)
		{
			return null;
		}

		public IEnumerator CoFade(TextMeshPro text, float targetOpac, float duration)
		{
			return null;
		}

		public IEnumerator CoFade(Material mat, float targetOpac, float duration)
		{
			return null;
		}

		public void OnOptionsActive()
		{
		}

		public void OnOptionsDeactive()
		{
		}

		public GunOptionSelect()
			: base()
		{
		}
	}
}
