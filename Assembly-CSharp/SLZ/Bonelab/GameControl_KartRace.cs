using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using SLZ.SFX;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Bonelab
{
	public class GameControl_KartRace : BonelabInternalGameControl
	{
		public RigManager rm;

		private MusicAmbience2dSFX mA2d;

		public AvatarCrateReference avatarOverride;

		[Header("WORLD SETTINGS")]
		public Transform sunLight;

		public ZoneMusic zoneMusic;

		public AudioClip raceMusic;

		public AudioClip exploreMusic;

		public GameObject coreKey;

		private float _elapsedLapTime;

		private float _elapsedSumOfLapTimesTotal;

		[Header("LAPS")]
		public int totalLaps;

		public TextMeshPro[] txt_CurrentLap;

		public TextMeshPro[] txt_CurrentLapTime;

		public TextMeshPro[] txt_lapTimes;

		public TextMeshPro[] txt_totalTime;

		public float[] lapTimes;

		private int _lapIndex;

		private float _sumOfLaps_Current;

		[Header("CHECKPOINTS")]
		public bool[] trackCheckPoint;

		public GameObject trigger_StartRace;

		public GameObject trigger_NewLap;

		private bool finishedRace;

		[Header("BESTS")]
		private float _sumOfLaps_SessionBest;

		private float _sumOfLaps_PersonalBest;

		public TextMeshPro[] txt_totalTime_SessionBest;

		public TextMeshPro[] txt_totalTime_PersonalBest;

		[Header("AFFIRMATIONS")]
		public GameObject aff_Start;

		public GameObject aff_Finish;

		public ParticleSystem confettiFinish;

		public ParticleSystem confettiLap;

		public ParticleSystem confettiStart;

		private SimpleSFX confettiFinish_sfx;

		private SimpleSFX confettiLap_sfx;

		private SimpleSFX confettiStart_sfx;

		public GameObject[] LoadButtons;

		public GameObject[] LoadButtonsForComplete;

		[SerializeField]
		private GenericCrateReference unlockCrate;

		[FormerlySerializedAs("avatarGatcha")]
		[SerializeField]
		private GameObject avatarGacha;

		private CancellationTokenSource lapTimerCTS;

		public void STARTRACE()
		{
		}

		public void NEWLAP()
		{
		}

		public void RESETRACE()
		{
		}

		public void ENDRACE()
		{
		}

		public void TRACKCHECKPOINT(int checkpoint)
		{
		}

		private UniTaskVoid StartTimer()
		{
			return default(UniTaskVoid);
		}

		public void WIPE_PB()
		{
		}

		private void UI_DisplayLaps()
		{
		}

		private void UI_DisplayLapTime()
		{
		}

		private void UI_DisplayBests()
		{
		}

		public void SwitchAvatar()
		{
		}

		private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
		{
			return default(UniTaskVoid);
		}

		private void ButtonsSetup()
		{
		}

		public void ObjectiveCompleteSetup()
		{
		}

		public GameControl_KartRace()
			: base()
		{
		}
	}
}
