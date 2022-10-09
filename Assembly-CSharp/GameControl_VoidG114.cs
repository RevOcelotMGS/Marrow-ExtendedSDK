using System.Runtime.CompilerServices;
using SLZ.Data.SaveData;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using SLZ.VRMK;
using TMPro;
using UnityEngine;

public class GameControl_VoidG114 : MonoBehaviour
{
	[SerializeField]
	private RigManager rm;

	public BodyVitals ctrl_bodyVitals;

	public LevelCrateReference level_quickPlay;

	public LevelCrateReference descentLevelCrate;

	public LevelCrateReference hubLevelCrate;

	public LevelCrateReference longRunLevelCrate;

	public LevelCrateReference mineDiveLevelCrate;

	public LevelCrateReference jimmyLevelCrate;

	public LevelCrateReference ascentLevelCrate;

	public LevelCrateReference townFightLevelCrate;

	public LevelCrateReference voidG114LevelCrate;

	public LevelCrateReference loadScreenLevel;

	private LevelCrateReference _loadcrate;

	public Spawnable vfxFadeOutSpawnable;

	public string buildTitle;

	public string buildState;

	private string buildDate;

	public TextMeshPro tmp_Title;

	public TextMeshPro tmp_BuildInfo;

	private static PlayerProgression Progression
	{
		get
		{
			return null;
		}
	}

	private static PlayerProgression p
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	public void BUTTON_QUICKPLAY()
	{
	}

	public void BUTTON_PLAYNEWGAME()
	{
	}

	public void BUTTON_PLAYHUB()
	{
	}

	public void BUTTON_PLAYCONTINUE()
	{
	}

	private void LoadLevel()
	{
	}

	private LevelCrateReference ContinueDestination()
	{
		return null;
	}

	public GameControl_VoidG114()
		: base()
	{
	}
}
