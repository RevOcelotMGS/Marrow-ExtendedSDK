using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Proxy;
using UnityEngine;

public class BoxGripProxyMap : BoneProxyMap<BoxGripProxy, BoxGrip>
{

	public UniTaskVoid SetupHandPoses()
	{
		return default(UniTaskVoid);
	}


	public BoxGripProxyMap()
		: base()
	{
	}
}
