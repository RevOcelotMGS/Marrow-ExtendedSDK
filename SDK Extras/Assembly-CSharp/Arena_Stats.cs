using UnityEngine;
using UnityEngine.Events;

public class Arena_Stats : MonoBehaviour
{
	public bool visDebug;

	public bool createNew;

	[SerializeField]
	private Arena_GameController arenaGameController;

	public Arena_DataManager arena_DataManager;

	public ArenaMenuController arenaMenuController;

	public Arena_DataPlayer arenaDataPlayer;

	[SerializeField]
	private StatsDisplay statsDisplay;

	public UnityEvent OnArenaComplete;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	public void CreateArenaPlayerProfile(Arena_DataPlayer player)
	{
	}

	public void RoundAchieved()
	{
	}

	public bool CheckChallengeCompletion()
	{
		return default(bool);
	}

	private void CheckArenaCompletion()
	{
	}

	public void RefreshUI()
	{
	}

	private void PlayerDeathImmminent(bool isPlayerDying)
	{
	}

	private void OnNPCDamageDealt(float damage)
	{
	}

	private void PlayerDamage(float damageAmount)
	{
	}

	public void PlayerDeath()
	{
	}

	private void OnHeadshot()
	{
	}

	public Arena_Stats()
		: base()
	{
	}
}
