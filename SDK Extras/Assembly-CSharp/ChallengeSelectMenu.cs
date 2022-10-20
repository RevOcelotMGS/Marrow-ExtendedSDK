using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ChallengeSelectMenu : MonoBehaviour
{
	[SerializeField]
	private Arena_GameController arenaGameController;

	[SerializeField]
	private Transform buttonParentObj;

	[SerializeField]
	private List<GameObject> buttonObjList;

	[SerializeField]
	private GameObject buttonPrefab;

	[SerializeField]
	private TMP_Text[] chalDescriptionTexts;

	[SerializeField]
	private TMP_Text difficultyDescText;

	[SerializeField]
	private TMP_Text activeChallengeText;

	public UnityEvent OnChallengeSelected;

	public UnityEvent OnChallengeCanceled;

	public UnityEvent[] OnChallengeStarted;

	private int challengeID;

	private string[] diffDescriptions;

	public void SelectChallenge(int idx)
	{
	}

	public void OnChallengeSelect()
	{
	}

	public void ChallengeStarted()
	{
	}

	public void CancelCurrentChallenge()
	{
	}

	public void UpdateDiffText()
	{
	}

	public ChallengeSelectMenu()
		: base()
	{
	}
}
