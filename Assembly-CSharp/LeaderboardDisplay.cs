using System.Collections.Generic;
using Oculus.Platform;
using Oculus.Platform.Models;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LeaderboardDisplay : MonoBehaviour
{
	public enum DebugMode
	{
		VERBOSE = 0,
		MINIMAL = 1,
		NONE = 2
	}

	public DebugMode debugMode;

	public bool displayAllUserData;

	public string explicitTitle;

	public LeaderboardData currData;

	public int currIndex;

	[SerializeField]
	private GameObject leaderboardEntryParent;

	[SerializeField]
	private GameObject entryPrefab;

	[SerializeField]
	private GameObject userEntryPrefab;

	[SerializeField]
	private bool isAltHighPanel;

	[SerializeField]
	private int maxEntries;

	[SerializeField]
	private TMP_Text text_TitleBoard;

	[SerializeField]
	private TMP_Text text_TitleKey;

	[SerializeField]
	private TMP_Text text_ID_Rank_Key;

	[SerializeField]
	private TMP_Text text_ScoreKey;

	[SerializeField]
	private Button button_Filter;

	[SerializeField]
	private Text filterButtonText;

	[SerializeField]
	private Button button_StartAt;

	[SerializeField]
	private Text startAtButtonText;

	[SerializeField]
	private Button button_Exit;

	[SerializeField]
	private TMP_Text idText;

	[SerializeField]
	private GameObject swapPageButtonObj;

	[SerializeField]
	private GameObject pageButtonsObj;

	private int currPage;

	private int totalPages;

	[SerializeField]
	private TMP_Text currPageText;

	[SerializeField]
	private TMP_Text totalPageText;

	public UnityEvent onDataComplete;

	private bool isCurrentUser;

	private bool displayPanel;

	[SerializeField]
	private List<GameObject> entryObjectList;

	public Transform altLocation;

	public void InitializeDisplay(string ID)
	{
	}

	[ContextMenu("GetNextPageData")]
	public void GetNextPageData()
	{
	}

	public void PageUp()
	{
	}

	public void PageDown()
	{
	}

	public void GetUserLeaderboardData(int index)
	{
	}

	public void UserLeaderboardCallback(SortedDictionary<int, LeaderboardEntry> entries)
	{
	}

	private void CreateBlankUserEntry()
	{
	}

	public void FocusExplicitLeaderboard(int index, LeaderboardStartAt startAt)
	{
	}

	[ContextMenu("QueryCurrData")]
	public void QueryCurrentData()
	{
	}

	public void ToggleFilterType()
	{
	}

	private void SetStartAt(LeaderboardStartAt startAt)
	{
	}

	public void ToggleStartAt()
	{
	}

	public void ReturnToUserDisplay()
	{
	}

	public void ToggleGameObject(GameObject go, bool show)
	{
	}

	[ContextMenu("UpdateDisplayState")]
	public void UpdateDisplayState()
	{
	}

	public void ToggleAllButtons(bool isUser)
	{
	}

	[ContextMenu("DestroyCurrentEntries")]
	public void DestroyCurrentEntries()
	{
	}

	public void TeleportToAltLocation()
	{
	}

	public LeaderboardDisplay()
		: base()
	{
	}
}
