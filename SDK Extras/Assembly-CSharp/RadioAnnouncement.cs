using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

public class RadioAnnouncement : MonoBehaviour
{
	private static ComponentCache<RadioAnnouncement> _cache;

	public RadioManager radioManager;

	public AudioSource baseAudioPlayer;

	public AudioSource announcementAudioPlayer;

	public bool playAnnouncement;

	public RadioSong overrideClip;

	public AnimationCurve duckCurve;

	[Range(0f, 4f)]
	public float duckTime;

	private IEnumerator playOverride;

	private float cashedBaseVolume;

	public static ComponentCache<RadioAnnouncement> Cache
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	public void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void PLAYANNOUNCEMENT()
	{
	}

	public void RemotePlayAnnouncement(RadioSong overrideSong)
	{
	}

	private IEnumerator OverrideCoroutine(RadioSong overrideSong)
	{
		return null;
	}

	public RadioAnnouncement()
		: base()
	{
	}
}
