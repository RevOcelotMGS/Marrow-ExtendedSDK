using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Boneworks
{
	public class ChristmasTree : MonoBehaviour
	{
		public Control_GlobalTime ctrl_GlobalTime;

		private int timeScaleStep;

		private int maxTimeScaleStep;

		private bool tree_A;

		private bool tree_B;

		private bool tree_C;

		public ConfigurableJoint jnt_tree_A;

		public ConfigurableJoint jnt_tree_B;

		public ConfigurableJoint jnt_tree_C;

		private float targetRot_A;

		private float targetRot_B;

		private float targetRot_C;

		public AudioSource musicPlayer;

		private void Start()
		{
		}

		public IEnumerator PLAY_MUSIC()
		{
			return null;
		}

		public void SlowTime(int target)
		{
		}

		private void SetRotation()
		{
		}

		private void ToggleTimeScale()
		{
		}

		private void DecreaseTimeScale()
		{
		}

		private void IncreaseTimeScale()
		{
		}

		private void SetTimeScale(int step)
		{
		}

		private void AutoDecrease()
		{
		}

		public ChristmasTree()
			: base()
		{
		}
	}
}
