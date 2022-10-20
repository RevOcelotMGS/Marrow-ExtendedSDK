using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

public class EarthquakeEvent : MonoBehaviour
{
	[Serializable]
	public class Events
	{
		public float time;

		public Rigidbody rb;

		public Transform atPosition;

		public float magnitude;

		public ConfigurableJoint joint;

		public Events()
			: base()
		{
		}
	}

	public List<Events> events;

	public AudioClip earthquakeStart;

	public AudioMixerGroup mixerGroup;

	private float _startTime;

	private int _index;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public EarthquakeEvent()
		: base()
	{
	}
}
