using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

namespace SLZ.UI
{
	public class ControllerToolTip : ToolTip
	{
		public float timeToHighlight;

		private float cur_TimeToHighlight;

		[HideInInspector]
		public Sprite image_Sprite;

		public Sprite image_DefaultSprite;

		public SpriteRenderer spriteDisplay;

		public TextMeshPro text_ToolTip;

		public Transform lock_lineStart;

		public Transform lock_lineEnd;

		public LineRenderer line;

		[ColorUsage(true, true)]
		public Color max_text_color;

		[ColorUsage(true, true)]
		public Color min_text_color;

		[ColorUsage(true, true)]
		private Color target_text_color;

		[ColorUsage(true, true)]
		private Color cur_text_color;

		public Transform img_background;

		public AnimationCurve curve_bg;

		private Vector3 min_bg_scale;

		private Vector3 max_bg_scale;

		private Vector3 cur_bg_scale;

		private Vector3 target_bg_scale;

		[HideInInspector]
		public Transform offset_text;

		[HideInInspector]
		public bool isHoldingObject;

		[HideInInspector]
		public AudioClip clip_tutorial;

		public AudioClip clip_enable;

		public AudioClip clip_disable;

		public SimpleSFX src_Audio;

		private bool _isRunning;

		private Vector3 _lastHand;

		private Vector3 _handGimbalVel;

		private Vector3 _handGimbleAccel;

		private Vector3 _handGimbalOffset;

		private void Start()
		{
		}

		public void SETTEXT(string displaytext)
		{
		}

		public void SETLINE(bool lineActive = false, Transform lockLocation = default(Transform))
		{
		}

		public void FADETEXT(bool turnOn, bool useAudio = true)
		{
		}

		private void ClipDelay()
		{
		}

		private IEnumerator FXChange()
		{
			return null;
		}

		public void FOLLOWART(bool follow = true)
		{
		}

		private IEnumerator Following()
		{
			return null;
		}

		private Vector3 ClampDistance(Vector3 currentpos)
		{
			return default(Vector3);
		}

		protected Vector3 SmoothDamp2(Vector3 target, Vector3 lastTarget, Vector3 gimbaledVelocity, Vector3 gimbalAccel, Vector3 gimbleOffset, float lerpRate, float deltaTime, float maxOffset, float smoothTime = 0.1f)
		{
			return default(Vector3);
		}

		public ControllerToolTip()
			: base()
		{
		}
	}
}
