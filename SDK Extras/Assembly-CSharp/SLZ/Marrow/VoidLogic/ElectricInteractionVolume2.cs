using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.VoidLogic
{
	public class ElectricInteractionVolume2 : InteractionVolume
	{
		private static readonly HashSet<IGrippable> _claimedHosts;

		public Transform targetPos;

		public Collider[] recieverColliders;

		public AudioClip[] insertClips;

		public AudioClip[] removeClips;

		public AudioMixerGroup mixerGroup;

		private bool _isBatteryInserted;

		public PassthroughNode _powerPassthrough;

		private BaseNode _powerIn;

		private CylinderElectronicGrip2 _batteryHandleGrip;

		private CylinderElectronicGrip2 _batteryBodyGrip;

		public static HashSet<IGrippable> ClaimedHosts
		{
			get
			{
				return null;
			}
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

		private void HandAttached(IGrippable host, CylinderElectronicGrip2 grip)
		{
		}

		private void RemoveElectronic(IGrippable host, CylinderElectronicGrip2 grip)
		{
		}

		private UniTaskVoid ElectricInteractionCooldown(IGrippable host)
		{
			return default(UniTaskVoid);
		}

		public ElectricInteractionVolume2()
			: base()
		{
		}
	}
}
