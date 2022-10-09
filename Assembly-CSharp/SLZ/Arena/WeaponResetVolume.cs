using System.Collections.Generic;
using System.Runtime.InteropServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Arena
{
	public class WeaponResetVolume : MonoBehaviour
	{
		public static Dictionary<InteractableHost, WeaponPack> weaponDictionary;

		public bool resetOnEnter;

		public List<InteractableHost> hostList;

		[SerializeField]
		private AudioClip startTeleWepClip;

		public void OnTriggerEnter(Collider other)
		{
		}

		private void CheckPackDictionary(InteractableHost host)
		{
		}

		public void ResetVolumePacks()
		{
		}

		public static void RegisterPack(WeaponPack pack, InteractableHost weaponhost, InteractableHost maghost = default(InteractableHost))
		{
		}

		public static void UnregisterPack(WeaponPack pack, InteractableHost weaponHost, InteractableHost magHost = default(InteractableHost))
		{
		}

		public WeaponResetVolume()
			: base()
		{
		}
	}
}
