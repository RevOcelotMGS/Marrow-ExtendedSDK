using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Interaction
{
	public class InteractableIcon : MonoBehaviour
	{
		private enum Flip
		{
			On = 0,
			Off = 1
		}

		private Grip m_Grip;

		public Transform targetCenter;

		public GripIconType gripIconType;

		[HideInInspector]
		[SerializeField]
		private GameObject iconObj;

		private Renderer iconRenderer;

		[HideInInspector]
		public int hoverCount;

		[HideInInspector]
		public int farHoverCount;

		[SerializeField]
		[Header("Overrides default settings")]
		private bool LocalOverride;

		[Tooltip("Override default icon")]
		[SerializeField]
		private Texture IconTex;

		[SerializeField]
		private float IconSize;

		[SerializeField]
		private float AnimationDuration;

		private float scaledIconSize;

		private MaterialPropertyBlock Mblock;

		private int _sizeHash;

		private Coroutine iconBlendCoroutine;

		public void Awake()
		{
		}

		public void MyHandHoverBegin(Hand hand)
		{
		}

		public void MyHandHoverEnd(Hand hand)
		{
		}

		public void MyHandHoverUpdate(Hand hand)
		{
		}

		public void MyFarHandHoverBegin(Hand hand)
		{
		}

		public void MyFarHandHoverEnd(Hand hand)
		{
		}

		public void MyFarHandHoverUpdate(Hand hand)
		{
		}

		private void Reset()
		{
		}

		private void BlendIcondScaleFromTo(float targetScale)
		{
		}

		private IEnumerator CoBlendIconScaleFromTo(float from, float to)
		{
			return null;
		}

		private IEnumerator Switch(Flip flip)
		{
			return null;
		}

		private void AddIcon()
		{
		}

		private Mesh GetQuad()
		{
			return null;
		}

		private static Mesh BuildQuad(float width, float height)
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RemoveIcon()
		{
		}

		public InteractableIcon()
			: base()
		{
		}
	}
}
