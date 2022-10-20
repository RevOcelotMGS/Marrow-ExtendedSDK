using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Player;
using SLZ.Props.Weapons;
using TMPro;
using UnityEngine;

namespace SLZ.UI
{
	public class UI_HUD : MonoBehaviour
	{
		public enum AmmoDisplayLocation
		{
			None = 0,
			Belt = 1,
			Head = 2,
			Inventory = 3
		}

		[Header("GENERAL")]
		public Transform target_HEADFOLLOWER;

		public float offset_HeadDistance;

		private Transform _playerHead;

		private Vector3 _offset_headPlacement;

		private Vector3 _offset_headDirection;

		private Vector3 _lastHead;

		private Vector3 _headGimbalVel;

		private Vector3 _headGimbleAccel;

		private Vector3 _headGimbalOffset;

		private IEnumerator _co_follow_head;

		private bool _followingHead;

		[HideInInspector]
		[Header("MODULE - UI AMMO")]
		public bool showLowAmmoPopup;

		[HideInInspector]
		public bool lowAmmoPopupRight;

		public string emptyNote;

		public TextMeshPro text_ammo_light;

		public TextMeshPro text_ammo_medium;

		public TextMeshPro text_ammo_heavy;

		public GameObject hud_AMMO;

		public Transform target_ammo_inventory;

		public Transform target_ammo_head_left;

		public Transform target_ammo_head_right;

		public Transform target_ammo_belt;

		public int lowAmmoLight;

		public int lowAmmoMedium;

		public int lowAmmoHeavy;

		[HideInInspector]
		public AmmoInventory AmmoInventory;

		private IEnumerator _co_ammo_follow;

		public AmmoDisplayLocation ammo_displayLocation;

		private Transform _cur_ammo_displayLocation;

		[Header("MODULE - RESET")]
		public GameObject hud_RESETLEVEL;

		public MeshRenderer hud_ResetProgressBar;

		public AudioClip clip_resetLevel_cancel;

		public AudioClip clip_resetLevel_hold;

		public AudioSource sfx_resetLevel;

		public Transform target_resetLevel_head;

		public AnimationCurve curve_scale;

		public float timeToScale;

		private IEnumerator _co_resetLevel_follow;

		private IEnumerator _co_progressBar;

		private float _resetLevel_timeToScale;

		private float _cur_resetLevel_timeToScale;

		private Vector3 _cur_resetLevel_scale;

		private Vector3 _tar_resetLevel_scale;

		private bool _resetting;

		private static readonly int Float0;

		private WeaponSlot rightGun;

		private WeaponSlot leftGun;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UIHudSetup()
		{
		}

		public void UpdateUI()
		{
		}

		private void DisplayAmmo()
		{
		}

		private void DisplayReloadLevel()
		{
		}

		private void OnHandItemSlotRight(InventorySlot slot)
		{
		}

		public void OnHandItemSlotRemovedRight(InventorySlot slot)
		{
		}

		private void OnHandItemSlotLeft(InventorySlot slot)
		{
		}

		public void OnHandItemSlotRemovedLeft(InventorySlot slot)
		{
		}

		private void GetWeaponFromSlot(InventorySlot slot, bool rightHand, bool grab)
		{
		}

		private void CheckAmmoForHeldGuns()
		{
		}

		private bool IsAmmoLowByCartridge(CartridgeData cartridge)
		{
			return default(bool);
		}

		public void SHOWAMMO(AmmoDisplayLocation ammoLocation = AmmoDisplayLocation.None)
		{
		}

		private IEnumerator AmmoFollow_Coroutine()
		{
			return null;
		}

		public void POPUPRELOADSCENE(bool display = false)
		{
		}

		private IEnumerator ResetLevel(bool opening)
		{
			return null;
		}

		private IEnumerator ProgressBar()
		{
			return null;
		}

		public void INVENTORYOPEN(bool opened)
		{
		}

		public void HEADHUDFOLLOW(bool followHead = false)
		{
		}

		private IEnumerator HUD_SoftFollow()
		{
			return null;
		}

		protected Vector3 SmoothDamp2(Vector3 target, Vector3 lastTarget, Vector3 gimbaledVelocity, Vector3 gimbalAccel, Vector3 gimbleOffset, float lerpRate, float deltaTime, float maxOffset, float smoothTime = 0.1f)
		{
			return default(Vector3);
		}

		public UI_HUD()
			: base()
		{
		}
	}
}
