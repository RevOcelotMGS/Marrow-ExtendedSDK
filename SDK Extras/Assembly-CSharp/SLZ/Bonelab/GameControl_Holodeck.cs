using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class GameControl_Holodeck : BonelabGameControl
	{
		public MusicAmbience2dSFX headSfx;

		public GameObject UI;

		public Renderer[] wallPanels;

		public GameObject doorHide;

		public Renderer doorHideRenderer;

		public Image doorCheckImage;

		public Material[] wallMaterials;

		public GameObject[] lights;

		public float maxPanelTicTime;

		public ReflectionProbe probe1;

		public ReflectionProbe probe2;

		public AudioReverbData hugeRoomReverb;

		public AudioReverbData outsideReverb;

		public AudioReverbData voidReverb;

		public AudioClip shipAmbience;

		public AudioClip spaceAmbience;

		public AudioClip desertAmbience;

		public AudioClip beachAmbience;

		public AudioClip cityAmbience;

		public AudioClip stadiumAmbience;

		public AudioClip meadowAmbience;

		public AudioClip voidAmbience;

		public ZoneAmbience zoneAmbience0;

		public ZoneAmbience zoneAmbience1;

		private int materialIndex;

		private IEnumerator matCycle;

		private new void Start()
		{
		}

		public void CYCLEMATERIAL()
		{
		}

		public void SELECTMATERIAL(int i)
		{
		}

		public void TOGGLEDOOR()
		{
		}

		private IEnumerator CycleMatOverTime()
		{
			return null;
		}

		private void CueAmbience(AudioClip clipMain)
		{
		}

		public GameControl_Holodeck()
			: base()
		{
		}
	}
}
