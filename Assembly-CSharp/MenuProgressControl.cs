using SLZ.Data.SaveData;
using SLZ.Marrow.Warehouse;
using SLZ.UI;
using TMPro;
using UnityEngine;

public class MenuProgressControl : MonoBehaviour
{
	public bool continueMenu;

	public bool progressBars;

	public bool isOutroMenu;

	public GameObject newGameOption;

	public GameObject continueOption;

	public GameObject hubOption;

	public GameObject quickPlayOption;

	public TextMeshProUGUI currentLevel;

	public TextMeshProUGUI gameProgressNumber;

	public ProgressBar gameProgressBar;

	public ProgressBar tacTrialProgressBar;

	public ProgressBar arenaProgressBar;

	public ProgressBar sandboxProgressBar;

	public ProgressBar parkourProgressBar;

	public ProgressBar experimentalProgressBar;

	public ProgressBar unlocksProgressBar;

	public ProgressBar avatarsProgressBar;

	public ProgressBar easterEggsProgressBar;

	private int _progress;

	public LevelCrateReference hubCrate;

	public LevelCrateReference descentCrate;

	public LevelCrateReference longRunCrate;

	public LevelCrateReference mineDiveCrate;

	public LevelCrateReference bigAnomalyACrate;

	public LevelCrateReference streetPuncherCrate;

	public LevelCrateReference sprintBridgeCrate;

	public LevelCrateReference magmaGateCrate;

	public LevelCrateReference moonBaseCrate;

	public LevelCrateReference motorwayCrate;

	public LevelCrateReference pillarCrate;

	public LevelCrateReference bigAnomalyBCrate;

	public LevelCrateReference ascentCrate;

	public LevelCrateReference outroCrate;

	private static PlayerProgression Progression
	{
		get
		{
			return null;
		}
	}

	public void SetupDisplays()
	{
	}

	private void SetupOutroMenu()
	{
	}

	private void SetUpContinueMenu()
	{
	}

	private void SetProgressBar()
	{
	}

	private float SolveCompletePercent()
	{
		return default(float);
	}

	private float CalcCampaignComplete()
	{
		return default(float);
	}

	private float CalcHubComplete()
	{
		return default(float);
	}

	private float CalcTacTrials()
	{
		return default(float);
	}

	private float CalcArenas()
	{
		return default(float);
	}

	private float CalcParkours()
	{
		return default(float);
	}

	private float CalcSandbox()
	{
		return default(float);
	}

	private float CalcExperimentals()
	{
		return default(float);
	}

	private float CalcUnlocks()
	{
		return default(float);
	}

	private float CalcAvatars()
	{
		return default(float);
	}

	private float CalcEasterEggs()
	{
		return default(float);
	}

	public MenuProgressControl()
		: base()
	{
	}
}
