using System;
using System.Runtime.CompilerServices;
using Oculus.Platform.Models;
using SLZ.Marrow.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardEntryLabel : MonoBehaviour
{
	private static ComponentCache<LeaderboardEntryLabel> _cache;

	public int rank;

	public User user;

	public string oculusID;

	public long score;

	public DateTime timeStamp;

	public TMP_Text IDText;

	public TMP_Text titleText;

	public TMP_Text rankText;

	public TMP_Text userIDText;

	public TMP_Text scoreText;

	public TMP_Text timeStampText;

	public Image panelImage;

	public Image highlightPanelImage;

	public Button button;

	public int itemIndex;

	public static ComponentCache<LeaderboardEntryLabel> Cache
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void PopulateText(LeaderboardEntry entry, bool displayPanel, bool isUser, LeaderboardData.ScoreType scoreType)
	{
	}

	public void PopulateUserText(LeaderboardEntry entry, string title, int index, LeaderboardDisplay display, LeaderboardData.ScoreType scoreType, bool displayPanel)
	{
	}

	public void PopulateBoneUserText(LeaderboardEntry entry, BoneLeaderData data, BoneLeaderManager manager, bool displayPanel)
	{
	}

	public void PopulateBoneText(LeaderboardEntry entry, bool displayPanel, bool isUser, BoneLeaderData.ScoreType scoreType)
	{
	}

	public void PopulateBlankUserBoneText(BoneLeaderData data, BoneLeaderManager manager, bool displayPanel)
	{
	}

	public void PopulateBlankBoneText(string userName, BoneLeaderData data, BoneLeaderManager manager, bool displayPanel)
	{
	}

	public void PopulateBlankUserText(string title, int index, LeaderboardDisplay display, LeaderboardData.ScoreType scoreType)
	{
	}

	public void OnDataComplete()
	{
	}

	public LeaderboardEntryLabel()
		: base()
	{
	}
}
