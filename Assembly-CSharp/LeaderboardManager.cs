using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Oculus.Platform;
using Oculus.Platform.Models;
using UnityEngine;

public class LeaderboardManager : MonoBehaviour
{
	public enum DebugMode
	{
		VERBOSE = 0,
		MINIMAL = 1,
		NONE = 2
	}

	public static LeaderboardManager instance;

	public DebugMode debugMode;

	private ulong m_myID;

	private string m_myOculusID;

	public Dictionary<string, int> leaderboardDict;

	public List<LeaderboardData> leaderboardDataList;

	public LeaderboardDisplay leaderboardDisplay;

	public bool isEntitled;

	public static ulong MyID
	{
		get
		{
			return default(ulong);
		}
	}

	public static string MyOculusID
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

	public void CreateLeaderboardData()
	{
	}

	public int LookupLeaderboardIndex(string title)
	{
		return default(int);
	}

	public void AssignArenaLeaderboardByTitle(string profileTitle)
	{
	}

	public void AssignArenaLeaderboard(int index)
	{
	}

	private void PassedEntitlements()
	{
	}

	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	public static void TerminateWithError(Message msg)
	{
	}

	public void SubmitLeaderboardScore(LeaderboardData data, uint score)
	{
	}

	private IEnumerator CoWaitAndQuery(LeaderboardData data)
	{
		return null;
	}

	public void QueryLeaderboard(LeaderboardData data)
	{
	}

	public void QueryUserLeaderboard(LeaderboardData data)
	{
	}

	public LeaderboardManager()
		: base()
	{
	}
}
