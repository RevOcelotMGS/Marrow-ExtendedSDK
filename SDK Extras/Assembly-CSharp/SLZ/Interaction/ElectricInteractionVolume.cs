using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Interaction
{
	public class ElectricInteractionVolume : InteractionVolume
	{
		public Transform targetPos;

		public Collider[] recieverColliders;

		public AudioClip[] insertClips;

		public AudioClip[] removeClips;

		public AudioMixerGroup mixerGroup;

		public float volume;

		private bool m_isElectricInserted;

		[Tooltip("The type of electronic this object takes")]
		[Space(10f)]
		[SerializeField]
		private List<PowerSourceType> m_acceptedTypes;

		private PowerSocket m_powerSock;

		private PowerSource m_ps;

		private CylinderElectronicGrip m_cegHandle;

		private CylinderElectronicGrip m_cegBody;

		public static Action<ElectricInteractionVolume, IGrippable> OnVolumeChanged;

		public static HashSet<IGrippable> ClaimedHosts { get; private set; }

		public bool isElectricInserted
		{
			get
			{
				return default(bool);
			}
		}

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private bool M_CanInsert(PowerSourceType type)
		{
			return default(bool);
		}

		protected override void OnHoverStart(InteractableHost host)
		{
		}

		protected override void OnHoverEnd(InteractableHost host)
		{
		}

		protected override void OnHoverUpdate(InteractableHost host)
		{
		}

		private void M_InsertElectric(InteractableHost host)
		{
		}

		public void RemoveElectronic(IGrippable host, CylinderElectronicGrip grip)
		{
		}

		private void M_DestroyedPowerSource(InteractableHost host)
		{
		}

		private IEnumerator CoElectricInteractionCooldown(bool isInserted, IGrippable host)
		{
			return null;
		}

		private void DestroyedPSInteractionVolume()
		{
		}

		public void ExitInteractionVolume()
		{
		}

		public ElectricInteractionVolume()
			: base()
		{
		}
	}
}
