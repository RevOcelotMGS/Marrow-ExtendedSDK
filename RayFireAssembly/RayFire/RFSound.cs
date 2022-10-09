using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace RayFire
{
	[Serializable]
	public class RFSound
	{
		public bool enable;

		public bool once;

		public float multiplier;

		public AudioClip clip;

		public List<AudioClip> clips;

		public AudioMixerGroup outputGroup;

		public bool played;

		public bool HasClips
		{
			get
			{
				return default(bool);
			}
		}

		public RFSound()
			: base()
		{
		}

		public RFSound(RFSound source)
			: this()
		{
		}

		public static void CopySound(RayfireSound source, RayfireRigid target)
		{
		}

		public static void CopySound(RayfireSound source, List<RayfireRigid> targets)
		{
		}

		public static void Play(RayfireSound scr, AudioClip clip, AudioMixerGroup group, float volume)
		{
		}

		public static void InitializationSound(RayfireSound scr, float size)
		{
		}

		public static void ActivationSound(RayfireSound scr, float size)
		{
		}

		public static void DemolitionSound(RayfireSound scr, float size)
		{
		}

		public static float GeVolume(RayfireSound scr, float size)
		{
			return default(float);
		}

		private static bool FilterCheck(RayfireSound scr, float size)
		{
			return default(bool);
		}
	}
}
