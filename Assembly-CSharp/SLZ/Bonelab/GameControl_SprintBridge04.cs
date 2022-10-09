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
	public class GameControl_SprintBridge04 : BonelabInternalGameControl
	{
		public AvatarCrateReference avatarOverride;

		public GameObject[] LoadButtons;

		[SerializeField]
		private GenericCrateReference unlockCrate;

		[FormerlySerializedAs("avatarGatcha")]
		[SerializeField]
		private GameObject avatarGacha;

		private new void Start()
		{
		}

		public void SwitchAvatar()
		{
		}

		private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
		{
			return default(UniTaskVoid);
		}

		private void ButtonsSetup()
		{
		}

		public GameControl_SprintBridge04()
			: base()
		{
		}
	}
}
