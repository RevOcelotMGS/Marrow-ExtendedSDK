using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class RadioManager : MonoBehaviour
{
	[Serializable]
	public struct StationData
	{
		public RadioStation stationOJ;

		public RadioSong currentSong;

		public RadioSong alertOverride;

		public RadioSong queuedTrack;

		public int currentTrackIndex;

		public float currentRunningPosition;
	}

	[Serializable]
	public class OnRadioOverrideEvent : UnityEvent<RadioSong>
	{
		public OnRadioOverrideEvent()
			: base()
		{
		}
	}

	public bool radioOn;

	private static RadioManager _rmInstance;

	public List<RadioPlayer> radios;

	public List<RadioAnnouncement> radioAnnouncements;

	public RadioStation[] stations;

	[HideInInspector]
	public List<StationData> stationDatas;

	[HideInInspector]
	public List<RadioPlayer> radioPlayers;

	private StationData cur_stationData;

	[SerializeField]
	public OnRadioOverrideEvent onRadioOverrideEvent;

	public static RadioManager RadioManagerInstance
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

	public void Update()
	{
	}

	private void IterateStationTime()
	{
	}

	public void PlayOverride(RadioSong overrideClip)
	{
	}

	public void PlayAnnouncementOverride(RadioSong overrideClip, float delay)
	{
	}

	private IEnumerator AnnouncementOverride(RadioSong overrideClip, float delay)
	{
		return null;
	}

	public RadioManager()
		: base()
	{
	}
}
