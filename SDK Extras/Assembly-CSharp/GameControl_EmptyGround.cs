using SLZ.Rig;
using UnityEngine;
using UnityEngine.Video;

public class GameControl_EmptyGround : MonoBehaviour
{
	[Header("ValvePuzzle")]
	public ConfigurableJoint jpz_Valve;

	private Quaternion startRot_Valve;

	public ConfigurableJoint jpz_DumbWaiter;

	public ConfigurableJoint jpz_PlatHigh;

	public ConfigurableJoint jpz_PlatLow;

	public bool can_pzl_Valve;

	public ConfigurableJoint jpz_Balloon;

	[Header("Video Puzzle")]
	public VideoPlayer vidPlayer;

	[Header("Cage Puzzle")]
	public bool solved_CagePuzzle;

	public DoorControl ctrl_CageDoor;

	public TriggerSwitch[] toggler_SetLights;

	private int int_LightsChecked;

	public int count_SolveToggles;

	public GameObject obj_newCage;

	[Header("Light Control")]
	public GameObject obj_Light_Title;

	public GameObject obj_Light_Center;

	public GameObject obj_Light_Complex;

	public GameObject obj_Light_Warning;

	public GameObject obj_Flashlight;

	[Header("End Game")]
	public GameObject obj_FXParticleStars;

	public GameObject obj_BlockWall;

	[Header("Recursion")]
	public RigManager rm_player;

	public Transform recurPoint;

	private int count_teleports;

	public GameObject[] obj_firstRecursion;

	public GameObject[] obj_secondRecursion;

	public GameObject[] obj_thirdRecursion;

	private void Start()
	{
	}

	public void VALVEPUZZLE()
	{
	}

	public void PlayMeTheMovie()
	{
	}

	public void StopTheMovie()
	{
	}

	public void LockTheLights()
	{
	}

	public void TOGGLE(bool OnOff)
	{
	}

	public void TurnOffGameLights()
	{
	}

	public void TurnOnStars()
	{
	}

	public void WonPuzzle()
	{
	}

	public void SecondRound()
	{
	}

	public void TELEPORTPLAYER()
	{
	}

	private void SetRecurseObjects(bool objectsOn)
	{
	}

	public GameControl_EmptyGround()
		: base()
	{
	}
}
