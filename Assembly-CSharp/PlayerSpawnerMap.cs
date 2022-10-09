using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Proxy;
using SLZ.Rig;
using UnityEngine;

public class PlayerSpawnerMap : BoneProxyMap<PlayerSpawner, RigManager>
{
	public RigManager rigManager;

	public bool generating;

	public UniTaskVoid SpawnPlayer()
	{
		return default(UniTaskVoid);
	}

	public IEnumerator FindRigManager()
	{
		return null;
	}

	public PlayerSpawnerMap()
		: base()
	{
	}
}
