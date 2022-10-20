using System.Collections.Generic;
using SLZ.UI.Radial;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LabModule : MonoBehaviour
{
	[Header("Assign in Prefab")]
	public TextMeshProUGUI txt_title;

	public TextMeshProUGUI txt_description;

	public bool startActive;

	public GameObject menu;

	public LevelsPanelView lpv;

	public Image icon;

	[Header("Assign in Editor")]
	public Sprite sprite_Icon;

	public string title;

	public string description;

	public List<string> levelTags;

	private void OnEnable()
	{
	}

	public UI_LabModule()
		: base()
	{
	}
}
