using System;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorRadioAdaptor : MonoBehaviour
{
	[Serializable]
	public class AnimationRadioPair
	{
		public RadioSong radioSong;

		public int statemachineIndex;

		public int animationIndex;

		public AnimationRadioPair()
			: base()
		{
		}
	}

	public GenericAnimatorController animatorController;

	public RadioManager radioManager;

	public List<AnimationRadioPair> pairList;

	public bool doRadioOverrides;

	private Dictionary<RadioSong, AnimationRadioPair> animationRadioLookUp;

	private void Start()
	{
	}

	public void OverrideSongChange(RadioSong overrideSong)
	{
	}

	public void NUKERADIOS()
	{
	}

	public AnimatorRadioAdaptor()
		: base()
	{
	}
}
