using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Proxy;
using UnityEngine;

public class BarrelGripProxyMap : BoneProxyMap<BarrelGripProxy, BarrelGrip>
{

	public UniTaskVoid SetupHandPose()
	{
		return default(UniTaskVoid);
	}

	public BarrelGripProxyMap()
		: base()
	{
	}
}
