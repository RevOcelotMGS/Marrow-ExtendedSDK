using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

public class RadioPlayer : MonoBehaviour
{
	private static ComponentCache<RadioPlayer> _cache;

	public RadioSong overrideClip;

	private int cur_station;

	private int cur_track;

	[HideInInspector]
	public RadioStation[] stations;

	public RadioStation selectedStation;

	public RadioManager radioManager;

	public AudioSource audioPlayer;

	public float desyncBufferTime;

	public WaitForSecondsRealtime checkTime;

	public bool playAnnouncement;

	private float _lastTimeScale;

	public static ComponentCache<RadioPlayer> Cache
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	public void PlayNextStation()
	{
	}

	public void BackupAudioPlay()
	{
	}

	private IEnumerator PlayRadioAudio()
	{
		return null;
	}

	public void PLAYANNOUNCEMENT()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void CHECKRADIOSTATION()
	{
	}

	public RadioPlayer()
		: base()
	{
	}
}
