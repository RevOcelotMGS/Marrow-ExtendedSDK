using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Props.Weapons;
using UnityEngine;

public class AmmoPouchTester : MonoBehaviour
{
	public Spawnable[] magazines;

	public CartridgeData cartridge;

	private List<Magazine> _magazineArts;

	private int _curMagIdx;

	private Spawnable _nextMagazine;

	private bool _isSwitching;

	private bool _hasMagazineInQueue;

	[ContextMenu("TestSwitch")]
	private void TestSwitch()
	{
	}

	[ContextMenu("TestSwitchSpam")]
	private void TestSwitchSpam()
	{
	}

	private UniTaskVoid SwitchMagazine(Spawnable spawnable)
	{
		return default(UniTaskVoid);
	}

	private UniTask SpawnAndPlaceMagazine(Spawnable spawnable)
	{
		return default(UniTask);
	}

	public AmmoPouchTester()
		: base()
	{
	}
}
