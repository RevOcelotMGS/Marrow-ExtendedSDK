using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.UI
{
	public class UIControllerInput : MonoBehaviour
	{
		private static ComponentCache<UIControllerInput> _cache;

		private BaseController m_Controller;

		private RigManager m_Manager;

		[HideInInspector]
		private List<Transform> _cursorTargetOverrides;

		public Transform cursorTarget;

		private float m_levelReloadCounter;

		private float m_cur_levelReloadCounter;

		private bool m_appMenuButtonHeld;

		private IEnumerator reloadCoroutine;

		private bool m_canOpenMenu;

		public double initialActivateTime;

		private bool m_IsMenuActive;

		private bool _hasTriggeredThisFrame;

		public static ComponentCache<UIControllerInput> Cache
		{
			get
			{
				return null;
			}
		}

		public Spawnable VfxFadeOutSpawnable { get; protected set; }

		public Transform CursorTarget
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public void Start()
		{
		}

		private void Update()
		{
		}

		private IEnumerator SceneReloadCounter()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public void RemoveCursorTargetOverride(Transform transform)
		{
		}

		public void AddCursorTargetOverride(Transform transform)
		{
		}

		public void ResetLevel()
		{
		}

		public UIControllerInput()
			: base()
		{
		}
	}
}
