using System.Runtime.CompilerServices;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.SFX
{
	public class MotorSFX : MonoBehaviour
	{
		[Header("One Offs")]
		public AudioClip startMotor;

		public float startVolume;

		public float startMinDistance;

		public AudioClip stopMotor;

		public float stopVolume;

		public float stopMinDistance;

		[Header("Loop Clips")]
		public AudioClip idleLoop;

		public AudioClip velocityLoopStandardLoad;

		public AudioClip velocityLoopUnloaded;

		public AudioClip accelerationLoop;

		public AudioClip decelerationLoop;

		public float idleVolume;

		public float idleMinDistance;

		public float minVelocityVolume;

		public float minVelocityMinDistance;

		public float minVelocityPitch;

		public float maxVelocityVolume;

		public float maxVelocityMinDistance;

		public float maxVelocityPitch;

		public AudioMixerGroup outputMixer;

		private AudioPlayer _apVelocity;

		private AudioPlayer _apAcceleration;

		private bool _hasApVel;

		private bool _hasApAccel;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void StartMotor()
		{
		}

		public void StopMotor()
		{
		}

		public void UpdateMotor(float velocity, float acceleration, float loadPercent)
		{
		}

		private void UpdateAccel(float velocity, float acceleration)
		{
		}

		private void StopAccel()
		{
		}

		public MotorSFX()
			: base()
		{
		}
	}
}
