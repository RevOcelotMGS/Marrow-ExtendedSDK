using System.Runtime.CompilerServices;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Props.Weapons
{
	public class CraneGravityController : MonoBehaviour
	{
		public GravityManipulatorJob gravityManipulator;

		public Transform uiGravityManipulator;

		private bool flop;

		public GameObject greenLight;

		public GameObject redLight;

		public AudioMixerGroup outputMixer;

		private AudioPlayer apSmall;

		private AudioPlayer apBig;

		public AudioClip[] gravityManipulatorSmallSounds;

		public AudioClip[] gravityManipulatorBigSounds;

		public PrismaticSFX[] prismaticSfx;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void EnablePrismatics()
		{
		}

		public void FlopCraneGravity(bool isStart = false)
		{
		}

		private void PlayAudioClip(AudioPlayer ap, AudioClip clip, float volume, Transform pos)
		{
		}

		public CraneGravityController()
			: base()
		{
		}
	}
}
