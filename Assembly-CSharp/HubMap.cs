using SLZ.Data.SaveData;
using TMPro;
using UnityEngine;

public class HubMap : MonoBehaviour
{
	public GameControl_Hub gcHub;

	[Header("GameState Notices")]
	public string text_gameState_Welcome;

	public string text_gameState_Need3Unlocks;

	public string text_gameState_Need3CoreKeys;

	public string text_gameState_SpecialProjectsArea;

	public string text_gameState_NeedBodyLog;

	public string text_gameState_Need6CoreKeys;

	public string text_gameState_EmergencyExitAuthorization;

	[Header("Recommended Notices")]
	public string[] text_recommend_Module;

	[Header("Lore Notices")]
	public string[] LabLoreNotice;

	[Header("TextMeshPros")]
	public TextMeshPro tmp_notice;

	private string _noticeToDisplay;

	public GameObject displayCanvas;

	public Transform sideFront;

	public Transform sideBack;

	private static PlayerProgression Progression
	{
		get
		{
			return null;
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void CheckGameState()
	{
	}

	private void DetermineNotice(int gameStateSwitch = 0)
	{
	}

	public void UpdateDisplayText()
	{
	}

	public void PICKSIDE(bool front = true)
	{
	}

	public void OFF()
	{
	}

	public HubMap()
		: base()
	{
	}
}
