using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Data.SaveData;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.UI.Radial
{
	public class PopUpMenuView : MonoBehaviour
	{
		[Header("References")]
		public PageView radialPageView;

		public ItemSlotsPanelView itemSlotsPanelView;

		public PreferencesPanelView preferencesPanelView;

		public SpawnablesPanelView spawnablesPanelView;

		public LevelsPanelView levelsPanelView;

		public AvatarsPanelView avatarsPanelView;

		public bool canFireGun;

		public PageElementView cursorStart;

		public PageElementView cursorEnd;

		public PageElementView cursorMid;

		private float dis_uiSpawn_Near;

		private float dis_uiSpawn_Far;

		private float uiDistanceFromPlayer;

		private UIControllerInput _lastCursor;

		[HideInInspector]
		public float cur_avatarArmScaleMult;

		private Dictionary<UIControllerInput, Action> _ejectActions;

		private Transform m_RootTransform;

		private SimpleTransform m_UITransform;

		private Vector3 m_StartUIDirection;

		private Plane m_StartUIPlane;

		private bool m_IsActivated;

		private bool m_IsCursorShown;

		private bool m_IsCursorHidden;

		private float m_CursorDampModifier;

		private Vector3 m_StartCursorVel;

		private Vector3 m_EndCursorVel;

		private Vector3 m_MidCursorVel;

		private Vector3 m_RayLookDir;

		private Vector3 m_RayLookVel;

		private Vector3 m_CursorHeight;

		private bool m_IsRadialMenu;

		private bool _hasPrimaryTriggeredThisFrame;

		private bool _hasSecondaryTriggeredThisFrame;

		private float m_TimeActive;

		private float m_DurationToBlend;

		private bool m_Triggered;

		public Vector3 testVector;

		[Header("DEV TOOLS")]
		public GenericCrateReference crate_Nimbus;

		public GenericCrateReference crate_SpawnGun;

		public static PopUpMenuView instance { get; private set; }

		public bool isActive
		{
			get
			{
				return default(bool);
			}
		}

		private Transform m_CursorTransform
		{
			get
			{
				return null;
			}
		}

		private static PlayerUnlocks u
		{
			get
			{
				return null;
			}
		}

		private static PlayerProgression Progression
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

		public void UpdateStartPosition()
		{
		}

		public void Trigger(bool isDown, bool isSecondaryDown = true, UIControllerInput controllerInput = default(UIControllerInput))
		{
		}

		private void Update()
		{
		}

		public void Activate(Transform headTransform, Transform rootTransform, UIControllerInput controllerInput, BaseController controller)
		{
		}

		public void Deactivate()
		{
		}

		public void BypassToPreferences()
		{
		}

		public void DefaultRadial()
		{
		}

		public void AddPreferencesMenu()
		{
		}

		public void AddInventoryMenu()
		{
		}

		public void AddDevMenu(Action spawnDelegate)
		{
		}

		public void RemoveDevMenu()
		{
		}

		public void AddSpawnMenu()
		{
		}

		public void RemoveSpawnMenu()
		{
		}

		public void AddMagEjectMenu(UIControllerInput uiInput, Action action)
		{
		}

		public void RemoveMagEjectMenu(UIControllerInput uiInput)
		{
		}

		public void AddScenesMenu()
		{
		}

		public void RemoveScenesMenu()
		{
		}

		public void AddAvatarsMenu()
		{
		}

		public void RemoveAvatarsMenu()
		{
		}

		public void ForceHideCursor()
		{
		}

		public void ShowCursor()
		{
		}

		public void HideCursor()
		{
		}

		private IEnumerator CoShowCursor(float duration)
		{
			return null;
		}

		private IEnumerator CoHideCursor(float duration)
		{
			return null;
		}

		public PopUpMenuView()
			: base()
		{
		}
	}
}
