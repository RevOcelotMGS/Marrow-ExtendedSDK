using TMPro;
using UnityEngine;

public class TrackerDisplay : MonoBehaviour
{
	[SerializeField]
	private int score;

	[SerializeField]
	private TargetTracker[] targetTrackers;

	[SerializeField]
	private TMP_Text scoreText;

	private void OnEnable()
	{
	}

	public void UpdateScore(int targScore)
	{
	}

	[ContextMenu("ClearAllScores")]
	public void ClearAllScores()
	{
	}

	public TrackerDisplay()
		: base()
	{
	}
}
