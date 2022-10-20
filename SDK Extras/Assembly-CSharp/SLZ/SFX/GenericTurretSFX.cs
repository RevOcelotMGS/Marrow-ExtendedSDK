using System.Runtime.CompilerServices;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.SFX
{
	public class GenericTurretSFX : MonoBehaviour
	{
		public AudioMixerGroup outputMixer;

		public AudioMixerGroup loopOutputMixer;

		public AudioClip[] idleClips;

		public AudioClip[] alertClips;

		public AudioClip[] patrolClips;

		public AudioClip[] unPackClips;

		public AudioClip[] packClips;

		public AudioClip[] speakClips;

		public AudioClip[] deathClips;

		public AudioClip[] impactClips;

		public AudioClip[] alarmClips;

		public AudioClip[] jumpClips;

		private float volume;

		private float minDist;

		private AudioPlayer _loopAudioPlayer;

		public void StopAll()
		{
		}

		public void PlayIdleLoop()
		{
		}

		public void StopIdleLoop()
		{
		}

		public void PlayAlarm()
		{
		}

		public void PlayJump()
		{
		}

		public void PlayAlert()
		{
		}

		public void PlayPatrol()
		{
		}

		public void PlayUnpack()
		{
		}

		public void PlayPack()
		{
		}

		public void PlaySpeak()
		{
		}

		public void PlayDeath()
		{
		}

		public void PlayImpact()
		{
		}

		public GenericTurretSFX()
			: base()
		{
		}
	}
}
