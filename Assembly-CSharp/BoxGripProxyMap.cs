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
	protected override void MapProperties()
	{
	}

	public override void BeforeGenerateReal()
	{
	}

	public override void AfterGenerateReal()
	{
	}

	public UniTaskVoid SetupHandPoses()
	{
		return default(UniTaskVoid);
	}

	public override void MapMethods()
	{
	}

	public BoxGripProxyMap()
		: base()
	{
	}
}
