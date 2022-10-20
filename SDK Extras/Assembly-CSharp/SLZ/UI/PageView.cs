using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Rig;
using SLZ.UI.Radial;
using UnityEngine;

namespace SLZ.UI
{
	public class PageView : MonoBehaviour
	{
		[Header("References")]
		public GameObject audioPlacementOverride;

		public AudioClip clip_hover;

		public AudioClip clip_select;

		public AudioClip clip_closeDown;

		public AudioClip clip_summon;

		public PageItemView[] buttons;

		public PageElementView cancelButton;

		public Feedback_Audio feedback_audio;

		public Feedback_Tactile feedback_tactile;

		[HideInInspector]
		public BaseController controller;

		public GameObject TextCanvas;

		[ColorUsage(true, true)]
		public Color color1;

		[ColorUsage(true, true)]
		public Color color2;

		private bool m_IsActivated;

		private PageItemView m_SelectedButton;

		private Page m_HomePage;

		private bool clip_closeDownFirstPlay;

		private void Start()
		{
		}

		public void SetHomePage(Page page)
		{
		}

		public Page GetHomePage()
		{
			return null;
		}

		private void CheckRefs()
		{
		}

		public void ChangePage(Page page)
		{
		}

		private IEnumerator CoChangePage(Page page)
		{
			return null;
		}

		private IEnumerator CoCloseAnimation()
		{
			return null;
		}

		private IEnumerator CoSummonAnimation()
		{
			return null;
		}

		public void Render(Page page)
		{
		}

		public void UpdateCursor(Vector2 uiCursorPosition)
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		public void ShutOff()
		{
		}

		public void Clear()
		{
		}

		public bool Trigger()
		{
			return default(bool);
		}

		public void RadialText(bool activation)
		{
		}

		private void PlayAudioClip(AudioClip clipToPlay, Transform buttonTransform = default(Transform))
		{
		}

		private void PlayHaptic(int hapticAction = 0)
		{
		}

		public PageView()
			: base()
		{
		}
	}
}
