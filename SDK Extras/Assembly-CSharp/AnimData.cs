using System;
using UnityEngine;

[Serializable]
public class AnimData
{
	public int animIndex;

	public string animGrp;

	public string animTrigger;

	public AudioClip voiceClip;

	public AnimData()
		: base()
	{
	}
}
