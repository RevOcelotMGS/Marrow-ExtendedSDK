using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using UnityEngine;

public class RandomAvatar : MonoBehaviour
{
	public RigManager rm;

	[Header("Avatars")]
	public AvatarCrate[] avatarCrates;

	public void RANDOMAVATAR()
	{
	}

	private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
	{
		return default(UniTaskVoid);
	}

	public RandomAvatar()
		: base()
	{
	}
}
