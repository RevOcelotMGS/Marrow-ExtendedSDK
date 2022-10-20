using System;
using System.Runtime.InteropServices;
using SLZ.Data.SaveData;
using TMPro;
using UnityEngine;

namespace SLZ.UI
{
	public class SceneAmmoUI : MonoBehaviour
	{
		[Serializable]
		public struct SceneNames
		{
			public string prettyName;

			public string levelKey;

			public string levelTotalAmmo;
		}

		[Serializable]
		public struct TextFields
		{
			[SerializeField]
			public TextMeshProUGUI name;

			[SerializeField]
			public TextMeshProUGUI count;

			[SerializeField]
			public TextMeshProUGUI totalPossible;
		}

		public SceneNames[] scenesToList;

		public TextFields[] references;

		private Vector4[] ammoCounts;

		private bool[] displayLevel;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void updateBoard(PlayerProgression progression)
		{
		}

		private void updateAmmoCount(PlayerProgression progression, string _level, [Out] Vector4 _ammoValues, [Out] bool _isDisplayed)
		{
		}

		private void updateTextFields()
		{
		}

		public SceneAmmoUI()
			: base()
		{
		}
	}
}
