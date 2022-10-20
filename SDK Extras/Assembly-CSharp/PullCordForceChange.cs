using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using UnityEngine;

public class PullCordForceChange : MonoBehaviour
{
	public AvatarCrateReference avatarCrate;

	public int optionalPullCordStopIndex;

	[SerializeField]
	public LayerMask LayerFilter;

	public bool onlyTriggerOnce;

	private RigManager rigManager;

	private bool used;

	private int choice;

	public bool randomize;

	private List<AvatarCrateReference> defaultFavoriteAvatarsBarcodes;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void ForceChange(GameObject other)
	{
	}

	private UniTaskVoid SwapAvatar(AvatarCrateReference avatarCrate)
	{
		return default(UniTaskVoid);
	}

	public PullCordForceChange()
		: base()
	{
	}
}
