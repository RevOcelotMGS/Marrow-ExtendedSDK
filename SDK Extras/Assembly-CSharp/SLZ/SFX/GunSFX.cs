using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.SFX
{
	public class GunSFX : MonoBehaviour
	{
		public AudioMixerGroup gunshotOutputMixer;

		public AudioMixerGroup interactionOutputMixer;

		public AudioClip[] fire;

		public AudioClip[] fireSlow;

		public AudioClip[] grab;

		public AudioClip[] secondGrip;

		public AudioClip[] slidePull;

		public AudioClip[] slideRelease;

		public AudioClip[] magazineInsert;

		public AudioClip[] magazineDrop;

		public AudioClip[] dryFire;

		public AudioClip[] dryFireSlow;

		public AudioClip[] slideLockFire;

		public AudioClip[] slideLockFireSlow;

		private InteractableHost _host;

		private AudioPlayer _gunshotAp;

		private float _gunshotTimer;

		private void Start()
		{
		}

		public void GunError()
		{
		}

		public void GunShot()
		{
		}

		public void Grab()
		{
		}

		public void SecondGrip()
		{
		}

		public void SlidePull()
		{
		}

		public void SlideRelease()
		{
		}

		public void MagazineInsert()
		{
		}

		public void MagazineDrop()
		{
		}

		public void SlideLock()
		{
		}

		public void DryFire()
		{
		}

		public GunSFX()
			: base()
		{
		}
	}
}
