using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[AddComponentMenu("RayFire/Rayfire Recorder")]
	[SelectionBase]
	[DisallowMultipleComponent]
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-recorder-component/")]
	public class RayfireRecorder : MonoBehaviour
	{
		public enum AnimatorType
		{
			Disabled = 0,
			Record = 2,
			Play = 8
		}

		public AnimatorType mode;

		public bool recordOnStart;

		public string clipName;

		public float duration;

		public int rate;

		public bool reduceKeys;

		public float threshold;

		public bool playOnStart;

		public AnimationClip animationClip;

		public RuntimeAnimatorController controller;

		public bool setToKinematic;

		public bool recorder;

		public float recordedTime;

		private int stateNameHash;

		private string assetFolder;

		private string clipFolder;

		private float stepTime;

		private Animator animator;

		private List<Transform> tmList;

		private List<RFCache> cacheList;

		private List<float> timeList;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void SetRigid()
		{
		}

		private void SetVariables()
		{
		}

		private void SetModeRecord()
		{
		}

		private void SetModePlay()
		{
		}

		private void Reset()
		{
		}

		public void StartRecord()
		{
		}

		private IEnumerator RecordCor()
		{
			return null;
		}

		public void StopRecord()
		{
		}

		public void StartPlay()
		{
		}

		public RayfireRecorder()
			: base()
		{
		}
	}
}
