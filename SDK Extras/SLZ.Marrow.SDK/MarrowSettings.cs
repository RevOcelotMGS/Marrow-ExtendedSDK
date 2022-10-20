using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using UnityEngine;

public class MarrowSettings : ScriptableObject
{
	[SerializeField]
	private LevelCrateReference _defaultLoadingLevel;

	[SerializeField]
	private SpawnableCrateReference _defaultPlayerRig;

	public static readonly string settingsKey;

	private static MarrowSettings _runtimeInstance;

	public LevelCrateReference DefaultLoadingLevel
	{
		get
		{
			return null;
		}
	}

	public SpawnableCrateReference DefaultPlayerRig
	{
		get
		{
			return null;
		}
	}

	public static MarrowSettings RuntimeInstance
	{
		get
		{
			return null;
		}
	}

	public static UniTask LoadRuntimeSettings()
	{
		return default(UniTask);
	}

	public MarrowSettings()
		: base()
	{
	}
}
