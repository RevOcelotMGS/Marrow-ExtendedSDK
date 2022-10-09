using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.SceneStreaming;
using SLZ.Marrow.Warehouse;
using SLZ.SFX;
using SLZ.VFX;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_Outro : BonelabInternalGameControl
	{
		public GameObject[] disableTownItemsAirlock;

		public GameObject[] disableTownItemsWindmill;

		public Blip femMBlip;

		public Chunk TownfightChunk;

		public Chunk SkyTubeChunk;

		public Chunk TaxiStartChunk;

		public Chunk VoidFloorChunk;

		public Chunk VoidG114Chunk;

		public Chunk TaxiStartConfigChunk;

		public Chunk VoidFloorConfigChunk;

		public Chunk VoidG114ConfigChunk;

		public GameObject TopDummyChunkTrigger;

		public GameObject MenuDummyChunkTrigger;

		public GameObject TaxiSequence;

		public GameObject WindmillGate;

		public ArmFinale ArmFinale;

		public GameObject VoidMenu;

		public GameObject BlankFloor;

		public GameObject windmill;

		private IEnumerator WindmillAirlock;

		private Coroutine changeChunk;

		[Header("ArmCinematic")]
		public GameObject[] ceilingtiles;

		public GameObject JimmyArm;

		public float armDelay;

		private Coroutine _coArmDelay;

		public GameObject avatarTransform;

		public MeshFilter avatarMeshFilter;

		public TextMeshProUGUI avatarName;

		public float avatarMeshScaleTune;

		private AvatarCrate avatarCrate;

		public string buildTitle;

		public string buildState;

		private string buildDate;

		public TextMeshPro tmp_Title;

		public TextMeshPro tmp_BuildInfo;

		public ZoneMusic music_menu;

		public ZoneMusic music_keygen;

		public SpawnableCrateReference blueApollo;

		public void DespawnTownItemsAirlock()
		{
		}

		public void DespawnItemsWindmill()
		{
		}

		private IEnumerator CycleWindmillAirlock()
		{
			return null;
		}

		private void ReachWindmill()
		{
		}

		private void ReachedTaxi()
		{
		}

		private void ArmHide()
		{
		}

		private void VoidDriving()
		{
		}

		private void DrivingEnd()
		{
		}

		private void CompleteGame()
		{
		}

		[ContextMenu("SkipToTaxi")]
		public void SkipToTaxi()
		{
		}

		public void SequenceProgress(int progress)
		{
		}

		private IEnumerator ChangeChunk(Chunk targetChunk)
		{
			return null;
		}

		public void RemoveObjects()
		{
		}

		public void TweenFogDensity(float _endDensity = 0.05f, float _durration = 1f)
		{
		}

		public void UnityFogDensity(float _density)
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

		public UniTask LoadAvatarFromSaveDataAsync()
		{
			return default(UniTask);
		}

		private void SetPreviewMesh(AvatarCrate crate)
		{
		}

		public void PLAYMENUMUSIC(int song = 0)
		{
		}

		private void OnDestroy()
		{
		}

		public GameControl_Outro()
			: base()
		{
		}
	}
}
