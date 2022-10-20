using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using TMPro;
using UnityEngine;

namespace SLZ.VFX
{
	public class GachaPopFX : MonoBehaviour
	{
		private static ComponentCache<GachaPopFX> _cache;

		public TextMeshPro text_unlockedItemType;

		public TextMeshPro text_unlockedItemName;

		public string unlockedItemType;

		public string unlockedItemName;

		public AnimationCurve curve_colorSize;

		public float holdTime;

		private float stopTime;

		private WaitForSeconds wait;

		public GameObject particlers;

		public Vector3 scale_target;

		private Vector3 scale_start_uit;

		private Vector3 scale_start_uin;

		private Vector3 scale_cur_uit;

		private Vector3 scale_cur_uin;

		public Color32 color_transparent;

		private Color32 color_start_uit;

		private Color32 color_start_uin;

		private Color32 color_cur_uit;

		private Color32 color_cur_uin;

		public SimpleSFX sfx_gacha;

		public static ComponentCache<GachaPopFX> Cache
		{
			get
			{
				return null;
			}
		}

		public void Awake()
		{
		}

		public void Start()
		{
		}

		public void PLAYFX(string itemType = "", string itemName = "")
		{
		}

		private IEnumerator FXChange()
		{
			return null;
		}

		public GachaPopFX()
			: base()
		{
		}
	}
}
