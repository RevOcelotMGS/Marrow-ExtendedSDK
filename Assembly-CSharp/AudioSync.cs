using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;

public class AudioSync : StateMachineBehaviour
{
	public enum SubtitlePlacement
	{
		Middle = 0,
		Top = 1,
		Bottom = 2
	}

	public AudioClip audioClip;

	public bool randomOffset;

	public bool looping;

	private AudioSource audioSource;

	private int hash;

	private float audioOffset;

	[Tooltip("The key used to look up the line you want to show")]
	public string key;

	[Tooltip("The delay time until a subtitle disappears")]
	public float SubtitleBufferTime;

	[Tooltip("The placement of the subtitles in the bottom screen")]
	public SubtitlePlacement SubPlacement;

	public static event Action<string, float, SubtitlePlacement> AddSubtitles;
}
