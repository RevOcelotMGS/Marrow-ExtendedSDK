using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Bonelab
{
	public class GameControl_MoonBase : BonelabInternalGameControl
	{
		public AvatarCrateReference avatarOverride;

		private Vector3 _cachedGrav;

		private readonly Vector3 _moonGrav;

		public GameObject[] LoadButtons;

		[SerializeField]
		private GenericCrateReference unlockCrate;

		[FormerlySerializedAs("avatarGatcha")]
		[SerializeField]
		private GameObject avatarGacha;

		public void SwitchAvatar()
		{
		}

		private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
		{
			return default(UniTaskVoid);
		}

		private void OnDestroy()
		{
		}

		private void ButtonsSetup()
		{
		}

		public GameControl_MoonBase()
			: base()
		{
		}
	}
}
