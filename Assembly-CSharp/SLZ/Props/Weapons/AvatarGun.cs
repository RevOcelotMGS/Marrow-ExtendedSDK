using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Props.Weapons
{
	public class AvatarGun : MonoBehaviour
	{
		private RigManager rigManager;

		public Grip triggerGrip;

		public Transform firePoint;

		public GameObject selectorKnob;

		[Header("Avatars")]
		public AvatarCrateReference[] avatarCrates;

		private AvatarCrateReference initialAvatar;

		private AvatarCrateReference lastAvatar;

		private int avatarIndex;

		[Header("VFX")]
		[SerializeField]
		private Spawnable vfxBlasterSpawnable;

		[SerializeField]
		private Spawnable avatarBlaster;

		public GameObject laser;

		[Header("Audio")]
		public AudioMixerGroup outputMixer;

		public AudioClip[] fireSFX;

		public AudioClip[] misfireSFX;

		public AudioClip[] modeSFX;

		private AudioPlayer ap;

		private int choice;

		public LayerMask collisionLayers;

		public float effectiveRange;

		private List<string> defaultFavoriteAvatarsBarcodes;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTriggerGripAttached(Hand hand)
		{
		}

		private void OnTriggerGripDetached(Hand hand)
		{
		}

		private void OnTriggerGripUpdate(Hand hand)
		{
		}

		private UniTaskVoid LoadFavoriteAvatars()
		{
			return default(UniTaskVoid);
		}

		private UniTaskVoid SwapAvatar(AvatarCrateReference avatarCrate, RigManager targetRig)
		{
			return default(UniTaskVoid);
		}

		private void PlayParticles(SkinnedMeshRenderer[] meshs)
		{
		}

		private void PlaySFX(AudioClip[] audioClips, Vector3 position)
		{
		}

		private float GetVolumeSurface(Vector3 size)
		{
			return default(float);
		}

		public AvatarGun()
			: base()
		{
		}
	}
}
