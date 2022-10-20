using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

public class GeoManager : MonoBehaviour
{
	public enum GeoState
	{
		CLEARED = 0,
		MOVING = 1,
		UP = 2,
		MOVING_TO_CLEAR = 3
	}

	public GeoState geoState;

	public GeoMover activeGeoMover;

	[SerializeField]
	private AudioMixerGroup mixerGroup;

	[SerializeField]
	private AudioClip moveGeoClip;

	[SerializeField]
	private AudioPlayer _loopAudioPlayer;

	public List<GeoMover> geoMoverList;

	[SerializeField]
	private GeoMover deathPitGeoMover;

	[SerializeField]
	private GeoMover deathPitFloorMover;

	public GameObject geoMoverPrefab;

	private int _currMoverIndex;

	public int currGeoIndex;

	public static Action OnMoveUpComplete;

	public Dictionary<string, int> geoDict;

	public Dictionary<string, GeoMover> geoMoverDict;

	public int moverIndex
	{
		get
		{
			return default(int);
		}
	}

	public void Awake()
	{
	}

	[ContextMenu("IncrementAndToggleGeo")]
	public void IncrementAndToggleGeo()
	{
	}

	public void IncrementGeoIndex()
	{
	}

	public void SelectGeo(string geoTitle)
	{
	}

	public void ClearCurrentGeo()
	{
	}

	public void ToggleGeo(int index)
	{
	}

	public void ToggleAudio(bool startPlaying, bool pitchShift = false)
	{
	}

	public void MoveUpComplete(GeoMover geoMover)
	{
	}

	public void MoveDownComplete(GeoMover geoMover)
	{
	}

	private IEnumerator CoDelayedMoveNext(float timeDelay, int index)
	{
		return null;
	}

	public GeoManager()
		: base()
	{
	}
}
