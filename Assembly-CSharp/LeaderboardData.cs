using System;
using System.Collections.Generic;
using Oculus.Platform;
using Oculus.Platform.Models;
using UnityEngine;

[Serializable]
public class LeaderboardData
{
	public enum ScoreType
	{
		POINT = 0,
		TIME_IN_SECONDS = 1,
		TIME = 2,
		DISTANCE_IN_FOOT = 3,
		DISTANCE_IN_METER = 4,
		PERCENTAGE = 5
	}

	public delegate void OnScoreLeaderboardUpdated(SortedDictionary<int, LeaderboardEntry> entries);

	public string leaderboardTitle;

	public string apiTitle;

	[HideInInspector]
	public int index;

	public ScoreType scoreType;

	public LeaderboardFilterType filterType;

	public LeaderboardStartAt startAt;

	[HideInInspector]
	public int TOP_N_COUNT;

	public SortedDictionary<int, LeaderboardEntry> m_Scores;

	[HideInInspector]
	public bool m_foundLocalUserEntry;

	private OnScoreLeaderboardUpdated m_ScoreCallback;

	public OnScoreLeaderboardUpdated ScoreLeaderboardUpdatedCallback
	{
		set
		{
		}
	}

	public void ScoreGetEntriesCallback(Message<LeaderboardEntryList> msg)
	{
	}

	public LeaderboardData()
		: base()
	{
	}
}
