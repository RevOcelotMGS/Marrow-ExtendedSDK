using System;
using SLZ.Rig;
using SLZ.UI.Radial;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.UI
{
	public class FantasyUIController : MonoBehaviour
	{
		[Serializable]
		public struct CursorRegion
		{
			public Transform center;

			public Bounds bounds;
		}

		protected bool m_isActive;

		private bool m_IsActiveThisFrame;

		private bool m_IsTriggeredDown;

		private bool m_IsTrigger;

		public PageElementView cursorStart;

		public PageElementView cursorEnd;

		public PageElementView cursorMid;

		public Transform menuTransform;

		public CursorRegion[] regions;

		private Vector3 m_StartCursorVel;

		private Vector3 m_EndCursorVel;

		private Vector3 m_MidCursorVel;

		private Vector3 m_RayLookDir;

		private Vector3 m_RayLookVel;

		private Vector3 m_CursorHeight;

		private VRStandaloneInputModule _module;

		private Controller[] controllers;

		private static Controller _activeController;

		private VRStandaloneInputModule module
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public virtual void Activate()
		{
		}

		public virtual void Deactivate()
		{
		}

		public virtual bool Trigger()
		{
			return default(bool);
		}

		public void UpdateCursor(Vector3 origin, Vector3 forward, bool isPressed)
		{
		}

		public void Clear()
		{
		}

		public void ShowCursor()
		{
		}

		public void HideCursor()
		{
		}

		public static Controller GetActiveController()
		{
			return null;
		}

		protected void Update()
		{
		}

		public FantasyUIController()
			: base()
		{
		}
	}
}
