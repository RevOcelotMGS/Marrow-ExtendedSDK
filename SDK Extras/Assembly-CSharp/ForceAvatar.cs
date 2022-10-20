using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using UnityEngine;

public class ForceAvatar : MonoBehaviour
{
	public RigManager rm;

	[Header("Avatar")]
	public AvatarCrate avatarCrate;

	[Header("Settings")]
	public bool saveAvatar;

	public void FORCEAVATAR()
	{
	}

	private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
	{
		return default(UniTaskVoid);
	}

	public ForceAvatar()
		: base()
	{
	}
}
